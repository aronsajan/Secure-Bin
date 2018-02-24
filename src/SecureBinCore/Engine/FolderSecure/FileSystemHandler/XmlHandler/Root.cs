#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler
{
    [XmlRoot]
    [XmlType("RootFolder")]
    public class Root
    {
        private string _name;
        private Directories Dirs = new Directories();
        private Files RootFiles = new Files();

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
        public Directories Directories
        {
            get
            {
                return (Dirs);
            }
        }

        public Files Files
        {
            get
            {
                return (RootFiles);
            }
        }
    }
}

#endregion