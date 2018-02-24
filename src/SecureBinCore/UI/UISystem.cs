#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace SecureBinCore.UI
{

    public class UISystem : IUISystem
    {
        const long HEADERCODE = 123;
        List<string> AllFolders;
        List<string> AllFiles;
        List<string> AllEntities;
        string FileType;
        public UISystem(string FileType)
        {
            AllFolders = new List<string>();
            AllFiles = new List<string>();
            this.FileType = FileType;
            GenerateEntities();

        }
        private void GenerateEntities()
        {
            List<string> RawEntities = new List<string>();
            RawEntities = Directory.GetFiles(Environment.CurrentDirectory + @"\" + ConfigurationSettings.AppSettings["AllEntityLocation"], "*." + FileType).ToList();
            AllEntities = RawEntities.Where(IsValidFile).ToList();


        }

        private bool IsValidFile(string fileName)
        {
            FileStream ValidRead = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] headerByte = new byte[8];
            ValidRead.Read(headerByte, 0, headerByte.Length);
            ValidRead.Close();
            long headerCode = BitConverter.ToInt64(headerByte, 0);
            if (headerCode == HEADERCODE)
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

        public List<string> ListAllFiles(bool FullPathName)
        {
            foreach (string entity in AllEntities)
            {
                if (!IsFolder(entity))
                {
                    if (FullPathName)
                    {
                        AllFiles.Add(entity);
                    }
                    else
                    {
                        string filename = Path.GetFileName(entity);
                        filename = filename.Substring(0, filename.LastIndexOf("."));
                        AllFiles.Add(filename);
                    }
                }


            }
            return AllFiles;
        }

        public List<string> ListAllFolders(bool FullPathName)
        {
            foreach (string entity in AllEntities)
            {
                if (IsFolder(entity))
                {
                    if (FullPathName)
                    {
                        AllFolders.Add(entity);
                    }
                    else
                    {
                        string filename = Path.GetFileName(entity);
                        filename = filename.Substring(0, filename.LastIndexOf("."));
                        AllFolders.Add(filename);
                    }
                }


            }
            return AllFolders;
        }

        public void DeleteFile(string FileName)
        {
            string ActualFilename = string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], FileName, ConfigurationSettings.AppSettings["SecureExtension"]);
            if (File.Exists(ActualFilename))
            {
                File.Delete(ActualFilename);
            }
        }

        private bool IsFolder(string entityName)
        {
            FileStream ReadFolder = new FileStream(entityName, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[9];
            ReadFolder.Read(data, 0, 9);
            ReadFolder.Close();
            byte[] isFolder = new byte[1];
            isFolder[0] = data[8];
            if (BitConverter.ToBoolean(isFolder, 0) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

#endregion