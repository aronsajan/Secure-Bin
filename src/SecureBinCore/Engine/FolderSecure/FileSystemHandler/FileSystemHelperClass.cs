#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;


namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler
{
    class FileSystemHelperClass
    {
        public static string GetAbsoluteName(string FileSystemElement)
        {
            string Absolutename = FileSystemElement.Substring(FileSystemElement.LastIndexOf("\\") + 1);
            return (Absolutename);
        }

        public static void AddRange(File[] FileElements, Files Destination)
        {
            foreach (File FileElement in FileElements)
            {
                Destination.Add(FileElement);
            }
        }

    }

}

#endregion