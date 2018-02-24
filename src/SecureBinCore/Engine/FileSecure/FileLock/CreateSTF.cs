#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace SecureBinCore.Engine.FileSecure.FileLock
{
    class CreateSTF
    {
        string FilePath;
        long HeaderCode, EndCode;
        public CreateSTF(string filepath, long HeaderCode, long EndCode)
        {
            this.FilePath = filepath;
            this.HeaderCode = HeaderCode;
            this.EndCode = EndCode;
        }
        public void GenerateSTF()
        {
            string FileName = Path.GetFileName(FilePath);
            FileStream WriteSTF = new FileStream(string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], FileName, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]), FileMode.Create, FileAccess.Write);
            FileStream ReadFile = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            BinaryWriter STFWriter = new BinaryWriter(WriteSTF);

            STFWriter.Write(HeaderCode);//Writing HeaderCode
            bool isFolder = false;
            STFWriter.Write(isFolder);//Writing isFolder value as false
            long FileNameLength = (long)FileName.Length;
            STFWriter.Write(FileNameLength);//Writing the length of filename
            STFWriter.Write(new ASCIIEncoding().GetBytes(FileName));//Writing filename
            long FileLen = ReadFile.Length;
            long OffsetLen = 33 + FileNameLength;
            long FileStartAddr = OffsetLen + 0;
            long FileEndAddr = FileStartAddr + FileLen;
            STFWriter.Write(FileStartAddr);//Writing file start address
            STFWriter.Write(FileEndAddr);//Writing file end address
            int data;
            while ((data = ReadFile.ReadByte()) != -1)
            {
                STFWriter.Write((byte)data);  //Writing file contents
            }

            STFWriter.Write(EndCode);//Writing End marker

            STFWriter.Close();
            WriteSTF.Close();
            ReadFile.Close();



        }

    }
}

#endregion