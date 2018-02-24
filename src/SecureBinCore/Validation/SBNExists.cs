#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace SecureBinCore.Validation
{
    class SBNExists : Validate
    {
        string FileName;
        public SBNExists(string filename)
        {
            FileName = filename;
        }

        public override void ValidateData()
        {
            string AbsoluteFileName = ConfigurationSettings.AppSettings["AllEntityLocation"] + FileName + "." + ConfigurationSettings.AppSettings["SecureExtension"];
            if (File.Exists(AbsoluteFileName))
            {
                throw (new ApplicationException("The entity named " + FileName + " is already present in Secure Bin"));
            }
        }
    }
}

#endregion