#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace Secure_Bin.Stability
{
    class RemoveTemporaryFiles
    {
        public void Remove()
        {
            if (Directory.Exists(ConfigurationSettings.AppSettings["EncryptionFolder"]))
            {
                Directory.Delete(ConfigurationSettings.AppSettings["EncryptionFolder"], true);
            }
            if (Directory.Exists(ConfigurationSettings.AppSettings["DecryptionFolder"]))
            {
                Directory.Delete(ConfigurationSettings.AppSettings["DecryptionFolder"], true);
            }
            RemoveSTFFiles();

        }

        private void RemoveSTFFiles()
        {
            List<string> STFFiles = Directory.GetFiles(ConfigurationSettings.AppSettings["AllEntityLocation"], "*." + ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]).ToList();
            foreach (string file in STFFiles)
            {
                File.Delete(file);
            }
        }
    }
}

#endregion