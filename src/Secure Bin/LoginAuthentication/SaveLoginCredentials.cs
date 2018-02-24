#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using Secure_Bin.LoginAuthentication.Crypter;

namespace Secure_Bin.LoginAuthentication
{
    class SaveLoginCredentials
    {
        const long HEADERCODE = 123;
        string CredentialFile;
        string username, password;
        public SaveLoginCredentials(string username, string password)
        {
            CredentialFile = Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["SettingsDirectory"] + ConfigurationSettings.AppSettings["LoginCredentilsFile"];
            this.username = username;
            this.password = password;
        }
        public void SaveCredentialsExecute()
        {

            FileStream SaveCredentials = new FileStream(CredentialFile, FileMode.Create, FileAccess.Write);
            BinaryWriter CredentialWriter = new BinaryWriter(SaveCredentials);
            CredentialWriter.Write(HEADERCODE);//Writing Header Code
            CredentialWriter.Write(new ASCIIEncoding().GetBytes(username));//Writing username
            CredentialWriter.Close();
            SaveCredentials.Close();
            EncryptData();
            try
            {
                File.Delete(CredentialFile);
            }
            catch (Exception PasswordFileDeletionFailure)
            {
            }



        }
        private void EncryptData()
        {
            Encrypt EncryptCredentials = new Encrypt();

            try
            {
                EncryptCredentials.ExecuteEncrypt(CredentialFile, password);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Account creation failed");
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