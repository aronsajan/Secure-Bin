#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler
{
    [XmlType]
    public class Directory
    {
        private string _name;
        private Files FileNode = new Files();
        private Directories DirNode = new Directories();
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

        public Files Files
        {
            get
            {
                return (FileNode);
            }
        }
        public Directories Directories
        {
            get
            {
                return (DirNode);
            }
        }
    }
}

#endregion