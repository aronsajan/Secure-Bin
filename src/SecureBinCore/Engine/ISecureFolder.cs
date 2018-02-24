#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.Engine
{
    public interface ISecureFolder
    {
        #region ISecureFolder Functions
        void LockFolder(string absoluteFolderPath, string Password);
        void UnlockFolder(string folderName, string NewRoot, string Password);

        #endregion
    }
}

#endregion