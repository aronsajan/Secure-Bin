#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler
{
    [XmlType]
    public class Directories : CollectionBase
    {

        public Directory this[int index]
        {
            get
            {
                return (List[index] as Directory);
            }
        }

        public void Add(Directory NewDir)
        {
            List.Add(NewDir);
        }
    }
}

#endregion