#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.Engine.FolderSecure.FolderUnlock
{
    class VerifySTFIntegrity
    {

        long ENDMARKER = 123;
        public bool Verify(long FooterCode)
        {
            if (FooterCode == ENDMARKER)
                return (true);
            else
                return (false);
        }
    }
}

#endregion