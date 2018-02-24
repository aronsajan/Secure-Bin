#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace Crypter.Encryption
{
    class Encrypt
    {
        public void ExecuteEncrypt(string FileName, string password)
        {
            byte[] passwordBytes = new UnicodeEncoding().GetBytes(password);
            byte[] keyBytes;

            FileStream ReadSTF = new FileStream(ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["EncryptionFolder"] + FileName + "_2" + "." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"], FileMode.Open, FileAccess.Read);

            RijndaelManaged Encrypter = new RijndaelManaged();

            GenerateIV generateIV = new GenerateIV(password);
            keyBytes = generateIV.Get256bitIV();
            Encrypter.BlockSize = keyBytes.Length * 8;
            FileStream WriteSBN = new FileStream(ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["EncryptionFolder"] + FileName + "_Enc." + ConfigurationSettings.AppSettings["SecureExtension"], FileMode.Create, FileAccess.Write);
            CryptoStream EncryptStream = new CryptoStream(WriteSBN, Encrypter.CreateEncryptor(passwordBytes, keyBytes), CryptoStreamMode.Write);
            for (int index = 0; index < ReadSTF.Length; ++index)
            {
                byte data = (byte)ReadSTF.ReadByte();
                EncryptStream.WriteByte(data);
            }
            EncryptStream.Close();
            WriteSBN.Close();
            ReadSTF.Close();

        }
    }
}

#endregion