#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace Crypter.Encryption.Initialize
{
    static class EncryptHelperClass
    {
        #region Encryption Support Functions
        public static void split(string FileName)
        {

            string RelativeName = string.Format("{0}{1}.{2}", ConfigurationSettings.AppSettings["AllEntityLocation"], FileName, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]);
            RelativeName = Environment.CurrentDirectory + @"\" + RelativeName;
            string EncryptFolder = string.Format("{0}{1}", ConfigurationSettings.AppSettings["AllEntityLocation"], ConfigurationSettings.AppSettings["EncryptionFolder"]);
            EncryptFolder = Environment.CurrentDirectory + @"\" + EncryptFolder;
            FileStream ReadSTF = new FileStream(RelativeName, FileMode.Open, FileAccess.Read);
            FileStream WriteSTFSegmentOne = new FileStream(string.Format("{0}{1}{2}.{3}", EncryptFolder, FileName, "_1", ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]), FileMode.Create, FileAccess.Write);
            FileStream WriteSTFSegmentTwo = new FileStream(string.Format("{0}{1}{2}.{3}", EncryptFolder, FileName, "_2", ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]), FileMode.Create, FileAccess.Write);
            byte[] DataSegmentOne = new byte[9];

            ReadSTF.Read(DataSegmentOne, 0, DataSegmentOne.Length);
            WriteSTFSegmentOne.Write(DataSegmentOne, 0, DataSegmentOne.Length);
            WriteSTFSegmentOne.Close();



            int data;
            while ((data = ReadSTF.ReadByte()) != -1)
            {
                WriteSTFSegmentTwo.WriteByte((byte)data);
            }
            WriteSTFSegmentTwo.Close();
            ReadSTF.Close();

        }

        public static void InitFolderSettings()
        {
            string EncryptFolder = string.Format("{0}{1}", ConfigurationSettings.AppSettings["AllEntityLocation"], ConfigurationSettings.AppSettings["EncryptionFolder"]);
            EncryptFolder = Environment.CurrentDirectory + @"\" + EncryptFolder;
            if (Directory.Exists(EncryptFolder))
            {

                Directory.Delete(EncryptFolder, true);

            }
            Directory.CreateDirectory(EncryptFolder);
        }
        #endregion

    }
}

#endregion