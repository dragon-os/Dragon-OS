using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace util
{
    class Setup
    {

        public static void setup()
        {
            OS.Kernel.fsc.DrawFilledRectangle(new Cosmos.System.Graphics.Pen(Color.BlueViolet), new Cosmos.System.Graphics.Point(), 100, 100);
        }

    }
}
