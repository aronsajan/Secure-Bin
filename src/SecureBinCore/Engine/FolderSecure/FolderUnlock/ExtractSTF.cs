#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;

namespace SecureBinCore.Engine.FolderSecure.FolderUnlock
{
    class ExtractSTF
    {
        string STFFilename;
        public ExtractSTF(string STFFilename)
        {
            this.STFFilename = STFFilename;
        }
        public UnlockParameters ExtractSTFContents()
        {
            UnlockParameters STFContents = new UnlockParameters();
            FileStream ReadSTF = new FileStream(STFFilename, FileMode.Open, FileAccess.Read);
            long securityCode = GetSecurityCode(ReadSTF);//Extracting security code
            ReadSTF.ReadByte();//Leaving isFolder
            long XmlHierarchySize = GetXMLHeirarchySize(ReadSTF);//Extracting XMLHierarchy size
            Root DirectoryHierarchy = GetXmlHierarchy(ReadSTF, XmlHierarchySize);//Extracting DirectoryHierarchy
            long NumberOfFiles = GetNumberOfFiles(ReadSTF);
            List<ExtractFileAttrib> FileAttribList = GetFileAttributes(ReadSTF, NumberOfFiles);
            long FooterCode = GetFooterSecurityCode(ReadSTF);
            ReadSTF.Close();
            STFContents.FileAttributes = FileAttribList;
            STFContents.NumberOfFiles = NumberOfFiles;
            STFContents.SecurityCode = securityCode;
            STFContents.XmlHeirarchy = DirectoryHierarchy;
            STFContents.XmlHeirarchySize = XmlHierarchySize;
            STFContents.FooterCode = FooterCode;

            return (STFContents);

        }

        private long GetSecurityCode(FileStream STFReader)
        {
            byte[] SecurityCodeByte = new byte[8];
            for (int Index = 0; Index < SecurityCodeByte.Length; ++Index)
            {
                SecurityCodeByte[Index] = (byte)STFReader.ReadByte();
            }
            long SecurityCode = BitConverter.ToInt64(SecurityCodeByte, 0);
            return (SecurityCode);
        }
        private long GetFooterSecurityCode(FileStream STFReader)
        {
            long CurrentStreamPos = STFReader.Position;
            byte[] FooterCodeBytes = new byte[8];
            STFReader.Position = STFReader.Length - FooterCodeBytes.Length;
            int data, index = 0;
            long FooterCode;
            while ((data = STFReader.ReadByte()) != -1)
            {
                FooterCodeBytes[index] = (byte)data;
                ++index;
            }
            FooterCode = BitConverter.ToInt64(FooterCodeBytes, 0);
            STFReader.Position = CurrentStreamPos;
            return (FooterCode);

        }
        private long GetXMLHeirarchySize(FileStream STFReader)
        {
            byte[] XmlHierarchySize = new byte[8];
            for (int Index = 0; Index < XmlHierarchySize.Length; ++Index)
            {
                XmlHierarchySize[Index] = (byte)STFReader.ReadByte();
            }
            long xmlSize = BitConverter.ToInt64(XmlHierarchySize, 0);
            return (xmlSize);
        }

        private long GetNumberOfFiles(FileStream STFReader)
        {
            byte[] numberOfFiles = new byte[8];
            for (int Index = 0; Index < numberOfFiles.Length; ++Index)
            {
                numberOfFiles[Index] = (byte)STFReader.ReadByte();
            }
            long NumberOfFiles = BitConverter.ToInt64(numberOfFiles, 0);
            return (NumberOfFiles);
        }

        private Root GetXmlHierarchy(FileStream STFReader, long xmlsize)
        {
            FileStream WriteXML = new FileStream("GeneratedHierarchy.xml", FileMode.Create, FileAccess.Write);
            Root XMLHierarchy;
            for (long index = 0; index < xmlsize; ++index)
            {
                byte HierarchyByte = (byte)STFReader.ReadByte();
                WriteXML.WriteByte(HierarchyByte);
            }
            WriteXML.Close();
            ConfigurationManager GetRoot = new ConfigurationManager();
            XMLHierarchy = GetRoot.ReadFileHierarchyXml("GeneratedHierarchy.xml");
            return (XMLHierarchy);

        }

        private List<ExtractFileAttrib> GetFileAttributes(FileStream STFReader, long numberOfFiles)
        {
            List<ExtractFileAttrib> FileAttributes = new List<ExtractFileAttrib>();
            for (long fileIndex = 0; fileIndex < numberOfFiles; ++fileIndex)
            {
                ExtractFileAttrib FileAttribute;

                //Getting File's ID
                int index = 0;
                byte[] FileIDByte = new byte[8];
                long FileID;
                for (index = 0; index < FileIDByte.Length; ++index)
                {
                    FileIDByte[index] = (byte)STFReader.ReadByte();
                }
                FileID = BitConverter.ToInt64(FileIDByte, 0);

                //Getting File's Start Location
                index = 0;
                byte[] FileStartLocByte = new byte[8];
                long FileStartLoc;
                for (index = 0; index < FileStartLocByte.Length; ++index)
                {
                    FileStartLocByte[index] = (byte)STFReader.ReadByte();
                }
                FileStartLoc = BitConverter.ToInt64(FileStartLocByte, 0);

                //Getting File's End Location

                index = 0;
                byte[] FileEndLocByte = new byte[8];
                long FileEndLoc;
                for (index = 0; index < FileEndLocByte.Length; ++index)
                {
                    FileEndLocByte[index] = (byte)STFReader.ReadByte();
                }
                FileEndLoc = BitConverter.ToInt64(FileEndLocByte, 0);

                FileAttribute.FileID = FileID;
                FileAttribute.FileStartLocation = FileStartLoc;
                FileAttribute.FileEndLocation = FileEndLoc;
                FileAttributes.Add(FileAttribute);




            }
            return (FileAttributes);
        }



    }
}

#endregion