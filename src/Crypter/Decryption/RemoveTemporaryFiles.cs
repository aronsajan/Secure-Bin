#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Crypter.Decryption
{
    class RemoveTemporaryFiles
    {
        #region Remove Temporary Files
        public void Remove()
        {
            string TargetFolder = ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["DecryptionFolder"];
            Directory.Delete(TargetFolder, true);
        }
        #endregion
    }
}

#endregion