#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.Engine.FileSecure.FileUnlock
{
    class UnlockParameters
    {
        long _headerCode;
        string _filename;
        long _fileStartAddr;
        long _fileEndAddr;
        long _footerCode;

        public long HeaderCode
        {
            get
            {
                return _headerCode;
            }
            set
            {
                _headerCode = value;
            }
        }
        public long FooterCode
        {
            get
            {
                return _footerCode;
            }
            set
            {
                _footerCode = value;
            }
        }
        public long FileStartAddress
        {
            get
            {
                return _fileStartAddr;
            }
            set
            {
                _fileStartAddr = value;
            }
        }

        public long FileEndAddress
        {
            get
            {
                return _fileEndAddr;
            }
            set
            {
                _fileEndAddr = value;
            }
        }

        public string FileName
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
            }
        }



    }
}

#endregion