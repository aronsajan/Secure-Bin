#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.Engine
{
    public interface ISecureFile
    {
        void LockFile(string filepath, string password);
        void UnlockFile(string filename, string destination, string password);
    }
}

#endregion