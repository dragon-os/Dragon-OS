using System;

using drivers;
using util;

using Cosmos.Common;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos;

using System.IO;

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
        String OS_NAME = "DragonOS"; // the name of the operating system.
        String VERSION = "0.00.00"; // the version of the operating system.

        bool hasBootBefore;

        // -------------------- DRIVERS --------------------
        public static Canvas fsc; // the display drivers

        protected override void BeforeRun()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(OS_NAME + " kernel v" + VERSION + " has loaded. ");

        }

        protected override void Run()
        {
            fsc = FullScreenCanvas.GetFullScreenCanvas(new Mode(1920, 1080, ColorDepth.ColorDepth32));

            Console.WriteLine("loading DisplayDriver");

            //String hasBootBeforeFile;

            //if(!File.Exists("hasBootBefore.dconfig"))
            //{
            //    File.Create("hasBootBefore.dconfig"); // the file
            //    File.WriteAllText("hasBootBefore.dconfig", "true");
            //    
            //} else
            //{
            //    hasBootBeforeFile = File.ReadAllText("hasBootBefore.dconfig");
            //}

            Setup.setup();
        }
    }
}
