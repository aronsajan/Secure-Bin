using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crypter;
using System.IO;

namespace SecureBin_Login_Credential_Creator
{
    class CreateCredential
    {
        public void RunApp()
        {
            int opt = 0;
            while (true)
            {
                Console.WriteLine("\t\tSecure Bin default login file creator\n");
                Console.WriteLine("\t\tDeveloped by Aron Sajan Philip\n\n\n");
                Console.WriteLine("1. Create login credential\n");
                Console.WriteLine("2. Read Hexadecimal content from file\n");
                Console.Write("Option : ");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception NotANumber)
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }
            switch (opt)
            {
                case 1: Console.Write("Insert the header key value : ");
                    long headerCode = int.Parse(Console.ReadLine());
                    Console.Write("Password : ");
                    string password = Console.ReadLine();
                    Encrypt Encrypter = new Encrypt();
                    FileStream WriteData = new FileStream("Login Credentials.ini", FileMode.Create, FileAccess.Write);
                    BinaryWriter Writer = new BinaryWriter(WriteData);
                    Writer.Write(headerCode);
                    Writer.Close();
                    WriteData.Close();
                    Encrypter.ExecuteEncrypt("Login Credentials.ini", password);


                    break;
                case 2:
                    string filename = Console.ReadLine();
                    FileStream ReadFile = new FileStream(filename,FileMode.Open,FileAccess.Read);
                    byte[] Data = new byte[ReadFile.Length];
                    ReadFile.Read(Data, 0, Data.Length);
                    ReadFile.Close();
                    StreamWriter writehxd = new StreamWriter("hxdData.txt");
                    writehxd.Write(BitConverter.ToString(Data,0));
                    writehxd.Close();
                    break;
                default: Console.WriteLine("Invalid option");
                    break;

            }
        }

    }
}
