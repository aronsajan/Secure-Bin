#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;

namespace SecureBinCore.Engine.FolderSecure.FolderUnlock
{
    class UnlockParameters
    {
        private long _SECURITYCODE;
        private long _xmlheirarchysize;
        private Root _xmlheirarchy;
        private long _numberoffiles;
        private long _FOOTERSECURITYCODE;
        private List<ExtractFileAttrib> FileAttributesList;

        public long SecurityCode
        {
            get
            {
                return _SECURITYCODE;
            }
            set
            {
                _SECURITYCODE = value;
            }
        }

        public long FooterCode
        {
            get
            {
                return _FOOTERSECURITYCODE;
            }
            set
            {
                _FOOTERSECURITYCODE = value;
            }
        }

        public long XmlHeirarchySize
        {
            get
            {
                return _xmlheirarchysize;
            }
            set
            {
                _xmlheirarchysize = value;
            }
        }

        public Root XmlHeirarchy
        {
            get
            {
                return (_xmlheirarchy);
            }
            set
            {
                _xmlheirarchy = value;
            }
        }

        public long NumberOfFiles
        {
            get
            {
                return (_numberoffiles);
            }
            set
            {
                _numberoffiles = value;
            }
        }

        public List<ExtractFileAttrib> FileAttributes
        {
            set
            {
                FileAttributesList = value;
            }
            get
            {
                return (FileAttributesList);
            }
        }

        public ExtractFileAttrib GetFileAttribute(int index)
        {
            return (FileAttributesList[index]);
        }




    }
}

#endregion