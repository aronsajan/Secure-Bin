#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace Crypter.Encryption
{
    class CombineSBN
    {
        public void CombineFiles(string FileName)
        {
            #region Function implementation for combining header and encrypted file
            string SrcFolder = ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["EncryptionFolder"];
            string SrcFileOne = SrcFolder + FileName + "_1." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"];
            string SrcFileTwo = SrcFolder + FileName + "_Enc." + ConfigurationSettings.AppSettings["SecureExtension"];
            FileStream WriteNewSBN = new FileStream(ConfigurationSettings.AppSettings["AllEntityLocation"] + FileName + "." + ConfigurationSettings.AppSettings["SecureExtension"], FileMode.Create, FileAccess.Write);
            WriteFile(SrcFileOne, WriteNewSBN);
            WriteFile(SrcFileTwo, WriteNewSBN);
            WriteNewSBN.Close();

            #endregion
        }
        #region Support function for combining header and encrypted content
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
        #endregion
    }
}

#endregion