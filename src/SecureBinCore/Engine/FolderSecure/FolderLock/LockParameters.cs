#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace SecureBinCore.Engine.FolderSecure.FolderLock
{

    static class LockParameters
    {
        static Dictionary<int, string> AllFiles = new Dictionary<int, string>();
        static Dictionary<int, FileAttrib> FileProperty = new Dictionary<int, FileAttrib>();

        public static Dictionary<int, string> LockFiles
        {
            get
            {
                return (AllFiles);
            }
            set
            {
                AllFiles = value;
                GenerateFileAttrib();
            }
        }

        private static void GenerateFileAttrib()
        {
            int key = 0;
            for (key = 0; key < AllFiles.Count; ++key)
            {

                FileAttrib SelectFileAttrib;
                if ((key - 1) != -1)
                {
                    FileInfo finfo = new FileInfo(AllFiles[key - 1]);
                    long prev_end = GetFileAttrib(key - 1).FileEndLocation;
                    ++prev_end;
                    finfo = new FileInfo(AllFiles[key]);
                    long SelectFileSize = finfo.Length;
                    SelectFileSize--;
                    SelectFileAttrib.FileName = AllFiles[key];
                    SelectFileAttrib.FileStartLocation = prev_end;
                    SelectFileAttrib.FileEndLocation = SelectFileAttrib.FileStartLocation + SelectFileSize;

                }
                else
                {
                    FileInfo finfo = new FileInfo(AllFiles[key]);
                    long FileEnd = finfo.Length;
                    SelectFileAttrib.FileStartLocation = 0;
                    FileEnd--;
                    SelectFileAttrib.FileEndLocation = FileEnd;
                    SelectFileAttrib.FileName = AllFiles[key];
                }
                FileProperty.Add(key, SelectFileAttrib);


            }

        }

        public static FileAttrib GetFileAttrib(int index)
        {
            return (FileProperty[index]);

        }

        public static long NumberOfFiles
        {
            get
            {
                long NumberOfFiles = FileProperty.Count;
                return (NumberOfFiles);
            }
        }

        public static void FlushAll()
        {
            if (AllFiles.Count > 0)
            {
                AllFiles.Clear();
            }

            if (FileProperty.Count > 0)
            {
                FileProperty.Clear();
            }



        }

    }
}

#endregion