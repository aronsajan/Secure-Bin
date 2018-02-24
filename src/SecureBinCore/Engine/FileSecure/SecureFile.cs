#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FileSecure.FileLock;
using SecureBinCore.Crypter;
using SecureBinCore.Engine.FactoryClass;
using System.Configuration;
using System.IO;
using SecureBinCore.Engine.FileSecure.FileUnlock;
using SecureBinCore.Validation;

namespace SecureBinCore.Engine.FileSecure
{
    public class SecureFile : ISecureFile
    {
        const long HEADERCODE = 123;
        const long ENDMARKER = 123;
        public void LockFile(string filepath, string password)
        {
            Validate PasswordValidate = new PasswordValidation(password);
            PasswordValidate.ValidateData();
            Validate FileExistsValidate = new SBNExists(Path.GetFileName(filepath));
            FileExistsValidate.ValidateData();
            CreateSTF GenerateSTF = new CreateSTF(filepath, HEADERCODE, ENDMARKER);
            GenerateSTF.GenerateSTF();

            IEncrypt Encrypter = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["Encrypter_Assembly"], Path.GetFileName(filepath), password) as IEncrypt;
            Encrypter.EncryptFile();
            string STFFilename = ConfigurationSettings.AppSettings["AllEntityLocation"] + Path.GetFileName(filepath) + "." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"];
            if (File.Exists(STFFilename))
            {
                File.Delete(STFFilename);
            }
            if (bool.Parse(ConfigurationSettings.AppSettings["DeleteSource"]) == true)
            {
                if (System.IO.File.Exists(filepath))
                {
                    System.IO.File.Delete(filepath);
                }
            }


        }
        public void UnlockFile(string filename, string destination, string password)
        {
            Validate PasswordValidate = new PasswordValidation(password);
            PasswordValidate.ValidateData();
            IDecrypt Decrypter = new InstantiateElement().CreateNewInstance(ConfigurationSettings.AppSettings["Decrypter_Assembly"], GetSBNName(filename), password) as IDecrypt;
            try
            {
                Decrypter.DecryptFile();
            }
            catch (Exception DecryptFailure)
            {

                throw (new ApplicationException("Incorrect password"));

            }
            ExtractSTF STFContents = new ExtractSTF();

            UnlockParameters FileUnlockParams = STFContents.ExtractContents(string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]));
            if (!Directory.Exists(destination))
            {
                throw (new ApplicationException("The destination directory does not exists"));

            }
            else
            {
                RestoreFile RestoreOriginalFile = new RestoreFile();
                RestoreOriginalFile.ExecuteRestore(FileUnlockParams, string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]), destination);
                if (File.Exists(string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"])))
                {
                    File.Delete(string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]));
                }
                if (File.Exists(string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureExtension"])))
                {
                    File.Delete(string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], filename, ConfigurationSettings.AppSettings["SecureExtension"]));
                }

            }

        }
        private string GetSBNName(string filename)
        {
            string SBNName = string.Format("{0}.{1}", filename, ConfigurationSettings.AppSettings["SecureExtension"]);
            return SBNName;
        }
    }
}

#endregion