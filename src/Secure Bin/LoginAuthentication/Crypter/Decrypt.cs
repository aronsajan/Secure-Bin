#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace Secure_Bin.LoginAuthentication.Crypter
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
            FileStream ReadFile = new FileStream(GetWithoutExtension(FileName) + ".LCK", FileMode.Open, FileAccess.Read);

            FileStream WriteFile = new FileStream(GetWithoutExtension(FileName) + "_DEC.LCK", FileMode.Create, FileAccess.Write);
            try
            {
                CryptoStream WriteDecrypted = new CryptoStream(WriteFile, Crypter.CreateDecryptor(PasswordBytes, KeyBytes), CryptoStreamMode.Write);

                for (int index = 0; index < ReadFile.Length; ++index)
                {
                    byte data = (byte)ReadFile.ReadByte();
                    WriteDecrypted.WriteByte(data);
                }
                WriteDecrypted.Close();
            }
            catch (Exception LoginFailure)
            {
                throw new ApplicationException("Authentication Exception");
            }
            finally
            {


                WriteFile.Close();
                ReadFile.Close();
            }

            #endregion

        }

        private string GetWithoutExtension(string FileName)
        {
            int DotIndex = FileName.LastIndexOf(".");
            string FileWithoutExtn = FileName.Substring(0, DotIndex);
            return FileWithoutExtn;
        }

    }
}

#endregion