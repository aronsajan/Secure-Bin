#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using io = System.IO;

using System.Collections;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;
using SecureBinCore.Engine.FolderSecure.FolderLock;

namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler
{
    public class CreateFolderHierarchy
    {
        string RootFolder;
        Root FileSystemManager = new Root();



        int FileCount = 0;
        Dictionary<int, string> AllFiles = new Dictionary<int, string>();
        public CreateFolderHierarchy(string foldername)
        {
            RootFolder = foldername;


        }

        public Root FolderHierarchy
        {
            get
            {
                FileSystemManager.Name = FileSystemHelperClass.GetAbsoluteName(RootFolder);

                string[] DirFiles = io.Directory.GetFiles(RootFolder);
                File[] FileElements = ConvertAsFiles(DirFiles);
                FileSystemHelperClass.AddRange(FileElements, FileSystemManager.Files);


                foreach (string Dir in io.Directory.GetDirectories(RootFolder))
                {
                    Directory DirElement = new Directory();
                    GetSubDirectories(Dir, DirElement);
                    FileSystemManager.Directories.Add(DirElement);

                }
                StoreFilesToBeEncrypted();
                return (FileSystemManager);
            }
        }




        private File[] ConvertAsFiles(string[] FileElements)
        {
            File[] DataFiles = new File[FileElements.Length];
            int index = 0;
            foreach (string _file in FileElements)
            {
                DataFiles[index] = new File();
                DataFiles[index].Name = FileSystemHelperClass.GetAbsoluteName(_file);
                DataFiles[index].UniqueID = FileCount;
                AllFiles.Add(FileCount, _file);
                ++FileCount;
                ++index;
            }
            return (DataFiles);
        }

        public void StoreFilesToBeEncrypted()
        {
            LockParameters.LockFiles = AllFiles;
        }



        private void GetSubDirectories(string RootDir, Directory DirElem)
        {
            DirElem.Name = FileSystemHelperClass.GetAbsoluteName(RootDir);
            FileSystemHelperClass Helper = new FileSystemHelperClass();
            string[] DirFiles = io.Directory.GetFiles(RootDir);
            File[] FileElements = ConvertAsFiles(DirFiles);
            FileSystemHelperClass.AddRange(FileElements, DirElem.Files);
            Directories Dirs = DirElem.Directories;
            foreach (string Folder in io.Directory.GetDirectories(RootDir))
            {
                Directory FolderElem = new Directory();
                GetSubDirectories(Folder, FolderElem);
                Dirs.Add(FolderElem);

            }
        }
    }
}

#endregion