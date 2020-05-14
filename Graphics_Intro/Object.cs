using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Graphics_Intro
{
    class Object
    {
        public static int pos_x;
        public static int pos_y;
        public static int radius = 5;
        public Random generator = new Random();

        public Object()
        {
            spawn();
        }
        public void spawn()
        {
            //Spawn in reasonable area
            pos_x = generator.Next(10, 520);
            pos_y = generator.Next(10, 280);
        }
    }
}
