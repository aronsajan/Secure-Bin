#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.Engine.FolderSecure
{
    struct FileAttrib
    {
        public string FileName;
        public long FileStartLocation;
        public long FileEndLocation;
    }

    struct ExtractFileAttrib
    {
        public long FileID;
        public long FileStartLocation;
        public long FileEndLocation;
    }
}

#endregion