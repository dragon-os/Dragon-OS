using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace drivers
{
    class FAT
    {
        public string[] ReadLines(string FileAdr) //Returns the lines of text in string[].
        {
            string[] FileRead;
            FileRead = System.IO.File.ReadAllLines(FileAdr);
            return FileRead;
        }

        public string ReadText(string FileAddr) //Returns the file in a single string.
        {
            string f_contents = "";
            f_contents = System.IO.File.ReadAllText(FileAddr);
            return f_contents;
        }

        public byte[] ReadByte(string FileAdr) //Returns the read file in bytes.
        {
            byte[] FileRead;
            FileRead = System.IO.File.ReadAllBytes(FileAdr);
            return FileRead;
        }

        public string[] GetFsFadr(string Adr) // Get Files From Address
        {
            string[] Files = new string[256];
            if (System.IO.Directory.GetFiles(Adr).Length > 0)
                Files = System.IO.Directory.GetFiles(Adr);
            else
                Files[0] = "No files found.";
            return Files;
        }
        public string[] GetDirFadr(string Adr) // Get Directories From Address
        {
            var Dirs = System.IO.Directory.GetDirectories(Adr);
            return Dirs;
        }

    }
}
