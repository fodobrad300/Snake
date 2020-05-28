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
        bool grow;
        bool die;
        public Display()
        {
            InitializeComponent();
            scoreLbl.Text = "Score: " + "0";
            die = Snake.death();
        }
        
        private void Display_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Pen snake = new Pen(Color.Black, Snake.width);
            Pen objects = new Pen(Color.Red, Object.radius);
            Pen decay = new Pen(Color.RosyBrown, Object.radius);
            SolidBrush gameField = new SolidBrush(Color.White);
            canvas.Clear(Color.Black);

            //draw rectangle for playing field
            canvas.FillRectangle(gameField, 10, 80, ClientSize.Width - 20, ClientSize.Height - 90);
            if(Object.decay < 100)
            {
                canvas.DrawPie(objects, Object.pos_x, Object.pos_y, Object.radius, Object.radius, 0, 360);
            }
            else if(Object.decay < 200)
            {
                canvas.DrawPie(decay, Object.pos_x, Object.pos_y, Object.radius, Object.radius, 0, 360);
            }
            else
            {
                Object.spawn();
            }
            for (int i = 0; i < Snake.length - 1; i++)
            {
                canvas.DrawLine(snake, Snake.coords_x[i], Snake.coords_y[i], Snake.coords_x[i + 1], Snake.coords_y[i + 1]);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //move snake and repaint
            Object.decay++;
            grow = Snake.move();
            if (grow)
            {
                Snake.grow();
                Object.spawn();
                scoreLbl.Text = "Score: " + Snake.score;
            }
            else if (die)
            {
                scoreLbl.Text = "Score: " + Snake.score;
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