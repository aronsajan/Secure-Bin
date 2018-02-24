#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.UI
{
    public interface IUISystem
    {
        List<string> ListAllFolders(bool FullPathName);
        List<string> ListAllFiles(bool FullPathName);
        void DeleteFile(string FileName);
    }
}

#endregion