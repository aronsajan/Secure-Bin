#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler
{
    [XmlType]
    public class File
    {
        private string _name;
        private int _uid;
        [XmlAttribute]
        public string Name
        {
            get
            {
                return (_name);

            }
            set
            {
                _name = value;
            }
        }
        [XmlAttribute]
        public int UniqueID
        {
            get
            {
                return (_uid);
            }
            set
            {
                _uid = value;
            }
        }
    }
}

#endregion