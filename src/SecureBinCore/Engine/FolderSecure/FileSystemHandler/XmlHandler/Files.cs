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
    public class Files : CollectionBase
    {

        public File this[int index]
        {
            get
            {
                return (List[index] as File);
            }
        }

        public void Add(File NewFile)
        {
            List.Add(NewFile);
        }






    }

}

#endregion