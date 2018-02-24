#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler;
using System.IO;

namespace SecureBinCore.Engine.FolderSecure.FolderUnlock
{
    class RestoreFiles
    {
        Root DirectoryStructure;
        List<ExtractFileAttrib> FileAttributes;
        string NewRoot;
        string STFFileName;
        public RestoreFiles(Root FileHierarchy, List<ExtractFileAttrib> FileAttributes, string NewRoot, string STFName)
        {
            DirectoryStructure = FileHierarchy;
            this.FileAttributes = FileAttributes;
            this.NewRoot = NewRoot;
            STFFileName = STFName;
        }
        public void ExecuteRestore()
        {
            foreach (ExtractFileAttrib FileIndex in FileAttributes)
            {
                FileSearcher SearchID = new FileSearcher(DirectoryStructure);
                string path = SearchID.SearchFile(FileIndex.FileID);
                path = NewRoot + @"\" + path;
                FileStream ExtractFileRead = new FileStream(STFFileName, FileMode.Open, FileAccess.Read);
                ExtractFileRead.Seek(FileIndex.FileStartLocation, SeekOrigin.Begin);
                long position;


                FileStream ExtractFileWrite = new FileStream(path, FileMode.Create, FileAccess.Write);

                for (position = FileIndex.FileStartLocation; position <= FileIndex.FileEndLocation; ++position)
                {
                    byte data = (byte)ExtractFileRead.ReadByte();
                    ExtractFileWrite.WriteByte(data);

                }
                ExtractFileWrite.Close();
                ExtractFileRead.Close();
            }
        }
    }
}

#endregion