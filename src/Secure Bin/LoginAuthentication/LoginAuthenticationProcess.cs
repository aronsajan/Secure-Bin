#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Secure_Bin.LoginAuthentication.Crypter;
using System.Configuration;
using System.IO;

namespace Secure_Bin.LoginAuthentication
{
    class LoginAuthenticationProcess
    {
        const long HEADERCODE = 123;
        string Username, Password;
        bool _validLogin;
        public LoginAuthenticationProcess(string username, string password)
        {
            Username = username;
            Password = password;
            _validLogin = false;
        }
        public void DecryptLogin()
        {
            string DecryptFile = Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["SettingsDirectory"] + ConfigurationSettings.AppSettings["LoginCredentilsFile"];


            try
            {
                Decrypt Decryptlogin = new Decrypt(DecryptFile, Password);
                Decryptlogin.DecryptFile();

                string ActualUserName = GetUsername(GetWithoutExtension(DecryptFile) + "_DEC.LCK");

                if (_validLogin)
                {
                    if (ActualUserName.CompareTo(Username) == 0)
                    {
                        _validLogin = true;
                    }
                    else
                    {
                        _validLogin = false;
                    }

                }



            }
            catch (Exception LoginFailed)
            {
                _validLogin = false;
            }

            if (File.Exists(GetWithoutExtension(DecryptFile) + "_DEC.LCK"))
            {
                File.Delete(GetWithoutExtension(DecryptFile) + "_DEC.LCK");
            }


        }

        private string GetUsername(string DecryptFile)
        {
            long filelen = new FileInfo(DecryptFile).Length;
            long UsernameLen = filelen - 8;
            FileStream ReadUsername = new FileStream(DecryptFile, FileMode.Open, FileAccess.Read);
            byte[] Header = new byte[8];
            byte[] Userbyte = new byte[(int)(UsernameLen)];
            string Username = "";
            ReadUsername.Read(Header, 0, Header.Length);
            int Data, Index = 0;
            if (BitConverter.ToInt64(Header, 0) == HEADERCODE)
            {
                _validLogin = true;
                ReadUsername.Read(Userbyte, 0, Userbyte.Length);
                Username = new ASCIIEncoding().GetString(Userbyte, 0, Userbyte.Length);

            }
            else
            {
                _validLogin = false;
            }
            ReadUsername.Close();
            return (Username);

        }

        public bool ValidLogin
        {
            get
            {
                return _validLogin;
            }
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