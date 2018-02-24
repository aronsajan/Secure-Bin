#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SecureBinCore.Engine.FileSecure.FileUnlock
{
    class ExtractSTF
    {
        public UnlockParameters ExtractContents(string filepath)
        {
            FileStream ReadSTF = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            long headerCode = Read64bits(ReadSTF);//Reading header code
            ReadSTF.ReadByte();//Omitting isFolder flag
            long FileNameLength = Read64bits(ReadSTF);
            string FileName = GetFileName(ReadSTF, FileNameLength);
            long StartAddress = Read64bits(ReadSTF);
            long EndAddress = Read64bits(ReadSTF);
            ReadSTF.Position = ReadSTF.Length - 8;
            long FooterCode = Read64bits(ReadSTF);
            ReadSTF.Close();
            UnlockParameters unlockParams = new UnlockParameters();
            unlockParams.HeaderCode = headerCode;
            unlockParams.FooterCode = FooterCode;
            unlockParams.FileName = FileName;
            unlockParams.FileStartAddress = StartAddress;
            unlockParams.FileEndAddress = EndAddress;
            return (unlockParams);



        }

        private long Read64bits(FileStream STFReader)
        {
            byte[] OutputByte = new byte[8];
            STFReader.Read(OutputByte, 0, OutputByte.Length);
            long Output = BitConverter.ToInt64(OutputByte, 0);
            return Output;
        }
        private string GetFileName(FileStream STFReader, long Length)
        {
            int index;
            byte[] FileNameBytes = new byte[(int)Length];
            for (index = 0; index < (int)Length; ++index)
            {
                FileNameBytes[index] = (byte)STFReader.ReadByte();
            }
            string Filename = new ASCIIEncoding().GetString(FileNameBytes);
            return Filename;
        }

    }
}

#endregion