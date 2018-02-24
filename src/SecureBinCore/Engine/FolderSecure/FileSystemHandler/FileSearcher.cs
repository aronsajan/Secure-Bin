#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;

namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler
{
    class FileSearcher
    {
        Root DirStruct;
        public FileSearcher(Root Hierarchy)
        {
            DirStruct = Hierarchy;
        }
        public string SearchFile(long FileID)
        {
            string rootdir = DirStruct.Name;
            bool filefound = false;
            string filePath = rootdir;
            foreach (File file in DirStruct.Files)
            {
                if (file.UniqueID == FileID)
                {
                    filefound = true;
                    filePath += @"\" + file.Name;
                    break;
                }
            }
            if (!filefound)
            {

                filePath = CheckFileExists(DirStruct.Directories, FileID);
                //if (!FileFound)
                //{
                //    throw (new ApplicationException("File restoring step failed"));
                //}
                //else
                //{
                filePath = DirStruct.Name + @"\" + filePath;
                //}

            }
            return (filePath);

        }
        private string CheckFileExists(Directories dirs, long FileID)
        {
            #region Search File Implementation
            bool fileFound = false;
            string RetVal = "";
            foreach (Directory dir in dirs)
            {
                foreach (File file in dir.Files)
                {
                    if (file.UniqueID == FileID)
                    {
                        fileFound = true;
                        RetVal = dir.Name + @"\" + file.Name;
                        break;

                    }
                }
                if (fileFound == true)
                {
                    break;

                }
                else
                {
                    string Val;
                    Val = CheckFileExists(dir.Directories, FileID);
                    if (!string.IsNullOrEmpty(Val))
                    {
                        RetVal = dir.Name + @"\" + Val;
                        break;
                    }
                    else
                    {
                        RetVal = "";
                    }
                }

            }

            return (RetVal);
            #endregion



        }

    }
}

#endregion