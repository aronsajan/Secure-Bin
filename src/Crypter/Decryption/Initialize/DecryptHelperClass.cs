#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Crypter.Decryption.Initialize
{
    public static class DecryptHelperClass
    {
        public static void Split(string FileName)
        {
            FileStream ReadSBN = new FileStream(ConfigurationSettings.AppSettings["AllEntityLocation"] + FileName, FileMode.Open, FileAccess.Read);
            string TargetLocation = ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["DecryptionFolder"];
            string TargetFileOne = TargetLocation + GetFileNameWithoutExtn(FileName) + "_1." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"];
            string TargetFileTwo = TargetLocation + GetFileNameWithoutExtn(FileName) + "_2." + ConfigurationSettings.AppSettings["SecureExtension"];
            FileStream WriteHeader = new FileStream(TargetFileOne, FileMode.Create, FileAccess.Write);
            FileStream WriteEncryptedData = new FileStream(TargetFileTwo, FileMode.Create, FileAccess.Write);
            byte[] header = new byte[9];
            ReadSBN.Read(header, 0, header.Length);
            WriteHeader.Write(header, 0, header.Length);
            WriteHeader.Close();
            int data;
            while ((data = ReadSBN.ReadByte()) != -1)
            {
                WriteEncryptedData.WriteByte((byte)data);
            }
            WriteEncryptedData.Close();
            ReadSBN.Close();


        }
        public static string GetFileNameWithoutExtn(string FileName)
        {
            string WithoutExtn = FileName.Substring(0, FileName.Length - 4);
            return WithoutExtn;
        }

        public static void InitFolderSettings()
        {
            string DecryptFolder = string.Format("{0}{1}", ConfigurationSettings.AppSettings["AllEntityLocation"], ConfigurationSettings.AppSettings["DecryptionFolder"]);
            DecryptFolder = Environment.CurrentDirectory + @"\" + DecryptFolder;
            if (Directory.Exists(DecryptFolder))
            {

                Directory.Delete(DecryptFolder, true);

            }
            Directory.CreateDirectory(DecryptFolder);
        }

    }
}

#endregion