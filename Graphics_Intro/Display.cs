using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Intro
{
    public partial class Display : Form
    {
        
        Snake Snake = new Snake(null, 5, 5, 533/2, 292/2, 5);
        Object Object = new Object();

        public Display()
        {
            InitializeComponent();
        }
        
        private void Display_Paint(object sender, PaintEventArgs e)
        {
            testLbl.Text = (ClientSize.Width + ", " + ClientSize.Height);
            Graphics canvas = e.Graphics;
            canvas.Clear(Color.White);
            Pen snake = new Pen(Color.Black, Snake.width);
            Pen objects = new Pen(Color.Red, Object.radius);

            canvas.DrawPie(objects, Object.pos_x, Object.pos_y, Object.radius, Object.radius, 0, 360);

            for(int i=0; i<Snake.length-1; i++)
            {
                canvas.DrawLine(snake, Snake.coords_x[i], Snake.coords_y[i], Snake.coords_x[i+1], Snake.coords_y[i+1]);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //move snake and repaint
            bool grow = Snake.move();
            if (grow)
            {
                Snake.grow();
                Object.spawn();
            }
            this.Invalidate();
        }

        private void Display_KeyPress(object sender, KeyPressEventArgs e)
        {
            //D key
            if (e.KeyChar == 100)
            {
                if (Snake.direction != "left")
                {
                    Snake.direction = "right";
                }
            }
            //A key
            else if (e.KeyChar == 97)
            {
                if (Snake.direction != "right")
                {
                    Snake.direction = "left";
                }
            }
            //S key
            else if (e.KeyChar == 115)
            {
                if(Snake.direction != "up")
                {
                    Snake.direction = "down";
                }
            }
            //W key
            else if (e.KeyChar == 119)
            {
                if (Snake.direction  != "down")
                {
                    Snake.direction = "up";
                }
            }
        }
    }
}