using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Crypter
{
    class GenerateIV
    {
        string Password;
        public GenerateIV(string password)
        {
            Password = password;
        }

        public byte[] Get256bitIV()
        {
            byte[] PasswordBytes = new UnicodeEncoding().GetBytes(Password);
            MD5 Md5hash = new MD5CryptoServiceProvider();
            byte[] hash = Md5hash.ComputeHash(PasswordBytes);
            byte[] ModifiedHash = ModifyHash(hash);
            return ModifiedHash;
        }

        private byte[] ModifyHash(byte[] ActualHash)
        {
            byte[] ModifiedHash = new byte[ActualHash.Length * 2];
            int index, count = 0;
            for (index = 0; index < ActualHash.Length; ++index)
            {
                ModifiedHash[count] = ActualHash[index];
                ModifiedHash[++count] = ActualHash[index];
                ++count;

            }
            return ModifiedHash;
        }
    }
}
