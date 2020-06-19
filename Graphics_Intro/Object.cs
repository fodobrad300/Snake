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
        public static int radius = 5;
        public static int number = 0;
        public static Random generator = new Random();
        public static List<int> pos_x = new List<int>();
        public static List<int> pos_y = new List<int>();
        public static List<int> decay = new List<int>();

        public Object()
        {
            spawnAll();
        }
        public void spawn(int number)
        {
            //Spawn in reasonable area
            pos_x[number] = generator.Next(20, 500);
            pos_y[number] = generator.Next(100, 270);
            decay[number] = 0;
        }
        public static void spawnAll()
        {
            if(Main_Menu.mode == "Chaotic (Loads of Objects)")
            {
                for (int i = 0; i<=300; i++)
                {
                    pos_x.Add(0);
                    pos_y.Add(0);
                    decay.Add(0);
                }
            }
            else if(Main_Menu.mode == "Arcade (3 Objects)")
            {
                for (int i = 0; i <= 2; i++)
                {
                    pos_x.Add(0);
                    pos_y.Add(0);
                    decay.Add(0);
                }
            }
            else
            {
                pos_x.Add(0);
                pos_y.Add(0);
                decay.Add(0);
            }
            for (int i = 0; i < pos_x.Count; i++)
            {
                //Spawn in reasonable area
                pos_x[i] = generator.Next(20, 500);
                pos_y[i] = generator.Next(100, 270);
                decay[i] = 0;
            }
        }
    }
}
