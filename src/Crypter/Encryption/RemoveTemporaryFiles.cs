#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace Crypter.Encryption
{
    class RemoveTemporaryFiles
    {
        #region Functions for removing temporary files created during encryption
        public void Remove()
        {
            string TargetFolder = ConfigurationSettings.AppSettings["AllEntityLocation"] + ConfigurationSettings.AppSettings["EncryptionFolder"];
            Directory.Delete(TargetFolder, true);
        }
        #endregion
    }
}

#endregion