#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;
using System.IO;
using System.Runtime.InteropServices;
using SecureBinCore.Engine.FolderSecure.FolderLock;
using SecureBinCore.Engine.FolderSecure.FolderUnlock;
using System.Configuration;
using SecureBinCore.Crypter;
using SecureBinCore.Engine.FactoryClass;
using SecureBinCore.Validation;


namespace SecureBinCore.Engine.FolderSecure
{
    class SecureFolder : ISecureFolder
    {

        #region Constants
        const long SECURITYCODE = 123;
        const long ENDMARKER = 123;
        #endregion
        public void LockFolder(string absoluteFolderPath, string Password)
        {
            #region LockFolder implementation
            LockParameters.FlushAll();
            Validate PasswordValidate = new PasswordValidation(Password);
            PasswordValidate.ValidateData();
            string DirectoryName = GetLeafDirectoryName(absoluteFolderPath);
            Validate FolderExistsValidate = new SBNExists(Path.GetFileName(DirectoryName));
            FolderExistsValidate.ValidateData();
            CreateFolderHierarchy createFolderHierarchy = new CreateFolderHierarchy(absoluteFolderPath);
            Root fileSystemHierarchyManager = createFolderHierarchy.FolderHierarchy;
            string DirName = Path.GetFileName(absoluteFolderPath);
            ConfigurationManager SaveConfiguration = new ConfigurationManager();
            SaveConfiguration.WriteFileHierarchyXml("HierarchySize.xml", fileSystemHierarchyManager);
            System.IO.FileInfo finfo = new FileInfo("HierarchySize.xml");
            long SizeOfXmlBlock = finfo.Length;
            try
            {
                CreateSTF STF = new CreateSTF(SECURITYCODE, SizeOfXmlBlock, DirName, ENDMARKER, fileSystemHierarchyManager);
            }
            catch (Exception ex)
            {

                throw (new ApplicationException(ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"] + " File Creation Failed"));
            }
            IEncrypt Encrypter = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["Encrypter_Assembly"], DirName, Password) as IEncrypt;
            Encrypter.EncryptFile();
            System.IO.File.Delete(ConfigurationSettings.AppSettings["AllEntityLocation"] + DirName + "." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]);
            if (bool.Parse(ConfigurationSettings.AppSettings["DeleteSource"]) == true)
            {
                if (System.IO.Directory.Exists(absoluteFolderPath))
                {
                    System.IO.Directory.Delete(absoluteFolderPath, true);
                }
            }

            if (System.IO.File.Exists("HierarchySize.xml"))
            {
                System.IO.File.Delete("HierarchySize.xml");
            }





            #endregion

        }

        private string GetLeafDirectoryName(string Dirpath)
        {
            string Dirname = Dirpath;
            if (Dirpath.LastIndexOf("\\") == Dirpath.Length - 1)
            {
                Dirname = Dirpath.Substring(0, Dirpath.Length - 1);
            }

            return (Dirname);
        }

        public void UnlockFolder(string Filename, string NewRoot, string Password)
        {

            #region Unlock Folder Implementation
            Validate PasswordValidate = new PasswordValidation(Password);
            PasswordValidate.ValidateData();
            string SBNFilename = GetSBNName(Filename);
            string STFFilename = GetSTFName(Filename);
            IDecrypt Decrypter = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["Decrypter_Assembly"], Path.GetFileName(SBNFilename), Password) as IDecrypt;
            try
            {
                Decrypter.DecryptFile();
            }
            catch (Exception DecryptException)
            {
                throw (new ApplicationException("Incorrect password"));
            }

            ExtractSTF ExtractSTFFile = new ExtractSTF(STFFilename);
            UnlockParameters STFContents = ExtractSTFFile.ExtractSTFContents();
            VerifySTFIntegrity CheckIntegrity = new VerifySTFIntegrity();
            if (!CheckIntegrity.Verify(STFContents.FooterCode))
            {
                throw (new ApplicationException("Incorrect password"));
            }
            DirectoryStructure CreateNewDirStructure = new DirectoryStructure(NewRoot, STFContents.XmlHeirarchy);
            CreateNewDirStructure.CreateDirectoryStructure();
            RestoreFiles RestoreFilesFromSTF = new RestoreFiles(STFContents.XmlHeirarchy, STFContents.FileAttributes, NewRoot, STFFilename);
            RestoreFilesFromSTF.ExecuteRestore();
            if (System.IO.File.Exists(STFFilename))
            {
                System.IO.File.Delete(STFFilename);
            }
            if (System.IO.File.Exists(ConfigurationSettings.AppSettings["AllEntityLocation"] + SBNFilename))
            {
                System.IO.File.Delete(ConfigurationSettings.AppSettings["AllEntityLocation"] + SBNFilename);
            }
            if (System.IO.File.Exists("GeneratedHierarchy.xml"))
            {
                System.IO.File.Delete("GeneratedHierarchy.xml");
            }





            #endregion
        }

        private string GetSBNName(string filename)
        {
            string SBNName = string.Format("{0}.{1}", filename, ConfigurationSettings.AppSettings["SecureExtension"]);
            return SBNName;
        }



        private string GetSTFName(string filename)
        {
            string STFName = string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]);
            return STFName;
        }




    }
}

#endregion