#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Secure_Bin.LoginAuthentication
{
    class FirstTimePasswordSet
    {

        public bool IsPasswordToBeSet
        {

            get
            {
                bool PasswordResetRequired = true;
                string CredentialFile = Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["SettingsDirectory"] + ConfigurationSettings.AppSettings["LoginCredentilsFile"];
                CredentialFile = GetWithoutExtension(CredentialFile) + ".LCK";
                if (File.Exists(CredentialFile))
                {
                    FileStream CredentialReader = new FileStream(CredentialFile, FileMode.Open, FileAccess.Read);
                    if (CredentialReader.Length != 32)
                    {
                        PasswordResetRequired = false;

                    }
                    else
                    {
                        byte[] CredentialData = new byte[CredentialReader.Length];
                        CredentialReader.Read(CredentialData, 0, CredentialData.Length);

                        string CredentialString = BitConverter.ToString(CredentialData, 0);
                        if (CredentialString.CompareTo("CF-C3-0C-FD-07-D4-F3-FF-19-5C-CE-D7-4C-42-41-8B-18-71-10-EF-F1-2B-FB-2D-2E-1D-5C-4F-E8-6C-16-15") != 0)
                        {
                            PasswordResetRequired = false;
                        }

                    }
                    CredentialReader.Close();
                }
                else
                {

                    throw new ApplicationException("One of the critical files required for this application to load has been found to be missing.");
                }

                return (PasswordResetRequired);

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