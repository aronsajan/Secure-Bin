#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SecureBinCore.Engine.FileSecure.FileUnlock
{
    class RestoreFile
    {
        public void ExecuteRestore(UnlockParameters FileDescriptor, string sourceFile, string destination)
        {
            string TargetFileName = string.Format("{0}{1}", destination, FileDescriptor.FileName);
            FileStream WriteFile = new FileStream(TargetFileName, FileMode.Create, FileAccess.Write);
            FileStream ReadSTF = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            ReadSTF.Position = FileDescriptor.FileStartAddress;
            WriteContents(WriteFile, ReadSTF, FileDescriptor.FileEndAddress);
            WriteFile.Close();
            ReadSTF.Close();

        }

        private void WriteContents(FileStream Target, FileStream Source, long EndAddr)
        {

            while (Source.Position < EndAddr)
            {
                byte data = (byte)Source.ReadByte();
                Target.WriteByte((byte)data);
            }

        }
    }
}

#endregion