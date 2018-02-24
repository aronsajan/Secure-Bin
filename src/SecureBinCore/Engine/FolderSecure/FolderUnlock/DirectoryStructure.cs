#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;
using io = System.IO;


namespace SecureBinCore.Engine.FolderSecure.FolderUnlock
{
    class DirectoryStructure
    {
        private string NewRoot;
        Root DirectoryHierarchy;
        public DirectoryStructure(string NewRoot, Root Hierarchy)
        {
            DirectoryHierarchy = Hierarchy;
            this.NewRoot = NewRoot;
        }
        public void CreateDirectoryStructure()
        {


            string NewPath = NewRoot + @"\" + DirectoryHierarchy.Name;
            if (io.Directory.Exists(NewPath) == false)
            {
                io.Directory.CreateDirectory(NewPath);
            }
            ExecuteDirectoryCreate(DirectoryHierarchy.Directories, NewPath);
        }

        private void ExecuteDirectoryCreate(Directories DirContainer, string path)
        {

            for (int dirIndex = 0; dirIndex < DirContainer.Count; ++dirIndex)
            {
                string GeneratedPath = path + @"\" + DirContainer[dirIndex].Name;

                if ((io.Directory.Exists(GeneratedPath) == false))
                {
                    io.Directory.CreateDirectory(GeneratedPath);
                }


                ExecuteDirectoryCreate(DirContainer[dirIndex].Directories, GeneratedPath);
            }

        }
    }
}

#endregion