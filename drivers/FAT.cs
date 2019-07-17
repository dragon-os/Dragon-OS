using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;
using Cosmos.Common;
using Cosmos.System.FileSystem;
using System.IO;

namespace drivers.file
{
    class FAT
    {
        CosmosVFS fs = new Sys.FileSystem.CosmosVFS();            

        public string[] ReadLines(string FileAdr) //Returns the lines of text in string[].
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            string[] FileRead;
            FileRead = File.ReadAllLines(FileAdr);
            return FileRead;
        }

        public string ReadText(string FileAddr) //Returns the file in a single string.
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            string f_contents = "";
            f_contents = File.ReadAllText(FileAddr);
            return f_contents;
        }

        public byte[] ReadByte(string FileAdr) //Returns the read file in bytes.
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            byte[] FileRead;
            FileRead = File.ReadAllBytes(FileAdr);
            return FileRead;
        }

        public string[] GetFromAddr(string Adr) // Get Files From Address
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            string[] Files = new string[256];
            if (Directory.GetFiles(Adr).Length > 0)
                Files = Directory.GetFiles(Adr);
            else
                Files[0] = "No files found.";
            return Files;
        }
        public string[] GetDirsFromAddress(string Adr) // Get Directories From Address
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            var Dirs = Directory.GetDirectories(Adr);
            return Dirs;
        }
    }
}
