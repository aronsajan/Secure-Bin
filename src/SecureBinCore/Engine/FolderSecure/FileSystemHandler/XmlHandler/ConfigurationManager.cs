#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using io = System.IO;
using System.Xml.Serialization;


namespace SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler
{
    class ConfigurationManager
    {
        public Root ReadFileHierarchyXml(string filename)
        {

            io.Stream Reader = new io.FileStream(filename, io.FileMode.Open, io.FileAccess.Read);
            Root Element = new Root();
            XmlSerializer Deserializer = new XmlSerializer(Element.GetType());
            Element = Deserializer.Deserialize(Reader) as Root;
            Reader.Close();
            return (Element);

        }


        public void WriteFileHierarchyXml(string filename, Root Element)
        {

            io.Stream Writer = new io.FileStream(filename, io.FileMode.Create, io.FileAccess.Write);

            XmlSerializer Serializer = new XmlSerializer(Element.GetType());
            Serializer.Serialize(Writer, Element);
            Writer.Close();

        }
    }
}

#endregion