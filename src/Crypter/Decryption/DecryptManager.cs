#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Crypter;
using Crypter.Decryption.Initialize;

namespace Crypter.Decryption
{
    public class DecryptManager : IDecrypt
    {
        string FileName, Password;
        public DecryptManager(string filename, string password)
        {
            FileName = filename;
            Password = password;
        }

        public void DecryptFile()
        {
            DecryptHelperClass.InitFolderSettings();
            DecryptHelperClass.Split(FileName);
            Decrypt DecryptFile = new Decrypt(DecryptHelperClass.GetFileNameWithoutExtn(FileName), Password);
            DecryptFile.DecryptFile();
            CombineSTF joinSTF = new CombineSTF();
            joinSTF.CombineFiles(DecryptHelperClass.GetFileNameWithoutExtn(FileName));
            new RemoveTemporaryFiles().Remove();
        }
    }
}

#endregion