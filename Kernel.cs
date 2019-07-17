using System;

using drivers.display;
using drivers.file;

using Cosmos.Core.IOGroup;
using Cosmos.Common;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;

namespace OS
{
    /*
     * Kernel.cs
     * 
     * The operating system kernal.
    */
    public class Kernel : Sys.Kernel
    {
        // -------------------- OS VARIABLES --------------------
        String OS_NAME = "OS"; // the name of the operating system.
        String VERSION = "0.00.00"; // the version of the operating system.

        // -------------------- DRIVERS --------------------
        private static DisplayDriver displayDriver; // the display driver.
        private static Mouse mouse; // the mouse driver.
        private static FAT fat; // the file system driver.

        protected override void BeforeRun()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(OS_NAME + " bootloader/kernel v" + VERSION + " has loaded. ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(OS_NAME + " loading FAT drivers...");

            Console.ForegroundColor = ConsoleColor.White;
            fat = new FAT();

            CosmosVFS fs = null;
            
            // check the amount of FAT filesystems.
            if(fs.GetVolumes().Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No FAT file system found!");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                fs = new Sys.FileSystem.CosmosVFS();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FAT file system found!");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        protected override void Run()
        {
        }
    }
}
