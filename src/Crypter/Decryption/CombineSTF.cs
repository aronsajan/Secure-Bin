#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Crypter.Decryption
{
    class CombineSTF
    {
        public void CombineFiles(string FileName)
        {

            string SrcFolder = ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["DecryptionFolder"];
            string SrcFileOne = SrcFolder + FileName + "_1." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"];
            string SrcFileTwo = SrcFolder + FileName + "_3." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"];
            FileStream WriteNewSTF = new FileStream(ConfigurationSettings.AppSettings["AllEntityLocation"] + FileName + "." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"], FileMode.Create, FileAccess.Write);
            WriteFile(SrcFileOne, WriteNewSTF);
            WriteFile(SrcFileTwo, WriteNewSTF);
            WriteNewSTF.Close();


        }

        private void WriteFile(string SrcFileName, FileStream CurrentStream)
        {
            FileStream ReadSrc = new FileStream(SrcFileName, FileMode.Open, FileAccess.Read);
            for (int index = 0; index < ReadSrc.Length; ++index)
            {
                byte data = (byte)ReadSrc.ReadByte();
                CurrentStream.WriteByte(data);
            }
            ReadSrc.Close();
        }
    }
}

#endregion