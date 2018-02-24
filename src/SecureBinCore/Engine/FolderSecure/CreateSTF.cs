#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SecureBinCore.Engine.FolderSecure.FolderLock;
using SecureBinCore.Engine.FolderSecure.FileSystemHandler.XmlHandler;
using System.Configuration;


namespace SecureBinCore.Engine.FolderSecure
{
    class CreateSTF
    {
        readonly long ByteOffset;
        public CreateSTF(long securityCode, long xmlBlockSize, string filename, long endMarker, Root DirectoryHierarchyManager)
        {
            #region Routine for creating STF
            FileStream STFStream = new FileStream(string.Format("{0}.{1}", Environment.CurrentDirectory + @"\" + ConfigurationSettings.AppSettings["AllEntityLocation"] + filename, ConfigurationSettings.AppSettings["SecureBinTemporaryExtension"]), FileMode.Create, FileAccess.Write);
            BinaryWriter writeSTF = new BinaryWriter(STFStream);

            writeSTF.Write(securityCode);//Security Code
            writeSTF.Write(true);//Setting IsFolder Property
            writeSTF.Write(xmlBlockSize);//Writing XML File Size
            IncludeXML("HierarchySize.xml", writeSTF);//Writing XML Document

            long numberOfFiles = LockParameters.NumberOfFiles;
            writeSTF.Write(numberOfFiles);//Writing number of files included
            ByteOffset = 25 + xmlBlockSize;//Byte Offset before files
            ByteOffset += numberOfFiles * 24;
            for (long FileKey = 0; FileKey < numberOfFiles; ++FileKey)
            {
                FileAttrib SelectFile = LockParameters.GetFileAttrib((int)FileKey);
                writeSTF.Write(FileKey);//Writing FileID
                writeSTF.Write(LockParameters.GetFileAttrib((int)FileKey).FileStartLocation + ByteOffset);//Writing File Start Location
                writeSTF.Write(LockParameters.GetFileAttrib((int)FileKey).FileEndLocation + ByteOffset);//Writing File End Location
            }

            for (long FileKey = 0; FileKey < numberOfFiles; ++FileKey)
            {
                IncludeFile(LockParameters.GetFileAttrib((int)FileKey), writeSTF);
            }

            writeSTF.Write(endMarker);
            writeSTF.Close();
            STFStream.Close();

            #endregion
        }

        #region STF Creation Support Functions
        private void IncludeFile(FileAttrib FileToWrite, BinaryWriter Writer)
        {
            FileStream Reader = new FileStream(FileToWrite.FileName, FileMode.Open, FileAccess.Read);
            for (int FilePointer = 0; FilePointer < Reader.Length; ++FilePointer)
            {
                byte data = (byte)Reader.ReadByte();
                Writer.Write(data);
            }
            Reader.Close();
        }

        private void IncludeXML(string filename, BinaryWriter STFWriter)
        {
            FileStream ReadXML = new FileStream(filename, FileMode.Open, FileAccess.Read);
            for (int ReadIndex = 0; ReadIndex < ReadXML.Length; ++ReadIndex)
            {
                byte data = (byte)ReadXML.ReadByte();
                STFWriter.Write(data);
            }
            ReadXML.Close();
        }
        #endregion
    }
}

#endregion