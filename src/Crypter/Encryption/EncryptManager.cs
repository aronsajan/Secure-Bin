#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SecureBinCore.Crypter;
using System.Configuration;
using Crypter.Encryption.Initialize;

namespace Crypter.Encryption
{
    public class EncryptManager : IEncrypt
    {
        string FileName, Password;
        #region Encrypt Manager Constructor
        public EncryptManager(string filename, string password)
        {
            FileName = filename;
            Password = password;
        }
        #endregion
        public void EncryptFile()
        {
            #region Encrption Implementation
            EncryptHelperClass.InitFolderSettings();
            EncryptHelperClass.split(FileName);
            Encrypt EncryptExec = new Encrypt();
            EncryptExec.ExecuteEncrypt(FileName, Password);
            CombineSBN Combine = new CombineSBN();
            Combine.CombineFiles(FileName);
            new RemoveTemporaryFiles().Remove();


            #endregion
        }

    }
}

#endregion