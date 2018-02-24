#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using SecureBinCore.Crypter;
using System.IO;
using System.Configuration;

namespace Crypter.Decryption
{
    public class Decrypt
    {
        string FileName, Password;
        #region Constructor
        public Decrypt(string filename, string password)
        {
            FileName = filename;
            Password = password;
        }
        #endregion
        public void DecryptFile()
        {
            #region Code for decrypting a file

            byte[] PasswordBytes = new UnicodeEncoding().GetBytes(Password.ToCharArray());
            byte[] KeyBytes;
            RijndaelManaged Crypter = new RijndaelManaged();

            KeyBytes = new GenerateIV(Password).Get256bitIV();
            Crypter.BlockSize = KeyBytes.Length * 8;
            FileStream ReadSBN = new FileStream(string.Format("{0}{1}", ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["DecryptionFolder"], FileName + "_2." + ConfigurationSettings.AppSettings["SecureExtension"]), FileMode.Open, FileAccess.Read);

            FileStream WriteSTF = new FileStream(string.Format("{0}{1}", ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["DecryptionFolder"], FileName + "_3." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]), FileMode.Create, FileAccess.Write);
            CryptoStream WriteDecrypted = new CryptoStream(WriteSTF, Crypter.CreateDecryptor(PasswordBytes, KeyBytes), CryptoStreamMode.Write);

            for (int index = 0; index < ReadSBN.Length; ++index)
            {
                byte data = (byte)ReadSBN.ReadByte();
                WriteDecrypted.WriteByte(data);
            }
            WriteDecrypted.Close();
            WriteSTF.Close();
            ReadSBN.Close();
            #endregion

        }

    }
}


#endregion