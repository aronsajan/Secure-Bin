using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Crypter
{
    public class Encrypt
    {
        public void ExecuteEncrypt(string FileName, string password)
        {
            byte[] passwordBytes = new UnicodeEncoding().GetBytes(password);
            byte[] keyBytes;

            FileStream ReadFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);

            RijndaelManaged Encrypter = new RijndaelManaged();

            GenerateIV generateIV = new GenerateIV(password);
            keyBytes = generateIV.Get256bitIV();
            Encrypter.BlockSize = keyBytes.Length * 8;
            FileStream WriteEncrypted = new FileStream(GetWithoutExtension(FileName) + ".LCK", FileMode.Create, FileAccess.Write);
            CryptoStream EncryptStream = new CryptoStream(WriteEncrypted, Encrypter.CreateEncryptor(passwordBytes, keyBytes), CryptoStreamMode.Write);
            for (int index = 0; index < ReadFile.Length; ++index)
            {
                byte data = (byte)ReadFile.ReadByte();
                EncryptStream.WriteByte(data);
            }
            EncryptStream.Close();
            WriteEncrypted.Close();
            ReadFile.Close();

        }

        private string GetWithoutExtension(string FileName)
        {
            int DotIndex = FileName.LastIndexOf(".");
            string FileWithoutExtn = FileName.Substring(0, DotIndex);
            return FileWithoutExtn;
        }
    }
}
