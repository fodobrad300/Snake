using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Graphics_Intro
{
    public partial class Display : Form
    {
        
        
        
        Snake Snake = new Snake(null, 5, 5* (Main_Menu.resolution.Width / Main_Menu.defaultResolution.Width), Main_Menu.resolution.Width/2, Main_Menu.resolution.Height/2, 5);
        Object Object = new Object();
        int grow;
        public static bool play = false;
       
        public Display()
        {
            InitializeComponent();
            scoreLbl.Text = "Score: " + "0";
            ClientSize = Main_Menu.resolution;
            if(Main_Menu.mode == "Chaotic(Loads of Objects)")
            {
                timer.Interval = 10;
            }
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
            for(int i = 0;i< Object.pos_x.Count; i++)
            {

                if (Object.decay[i] < 100)
                {
                    canvas.DrawPie(objects, Object.pos_x[i], Object.pos_y[i], Object.radius, Object.radius, 0, 360);
                }
                else if (Object.decay[i] < 200)
                {
                    canvas.DrawPie(decay, Object.pos_x[i], Object.pos_y[i], Object.radius, Object.radius, 0, 360);
                }
                else
                {
                    Object.spawn(i);
                }
            }
            
            for (int i = 0; i < Snake.coords_x.Count-1; i++)
            {
                canvas.DrawLine(snake, Snake.coords_x[i], Snake.coords_y[i], Snake.coords_x[i + 1], Snake.coords_y[i + 1]);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //move snake and repaint
            for (int i = 0; i < Object.pos_x.Count; i++)
            {
                Object.decay[i]++;
            }
            grow = Snake.move();
            if (grow >= 0)
            {
                Snake.grow(grow);
                Object.spawn(grow);
                
                scoreLbl.Text = "Score: " + Snake.score/2;
            }
            else if (!play)
            {
                scoreLbl.Text = "Score: " + Snake.score/2;
                startLbl.Visible = true;
            }
            this.Invalidate();
        }

        private void Display_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (play)
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
                    if (Snake.direction != "up")
                    {
                        Snake.direction = "down";
                    }
                }
                //W key
                else if (e.KeyChar == 119)
                {
                    if (Snake.direction != "down")
                    {
                        Snake.direction = "up";
                    }
                }
            }
            else
            {
                if (e.KeyChar == 100)
                {
                    Snake.direction = "right";
                    startLbl.Visible = false;
                    play = true;
                }
            }
        }

        private void Display_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter displayWriter = new StreamWriter("scores.txt");
            foreach (int i in Main_Menu.classicScores)
            {
                displayWriter.WriteLine(Convert.ToString(i));
            }
            foreach (int i in Main_Menu.arcadeScores)
            {
                displayWriter.WriteLine(Convert.ToString(i));
            }
            foreach (int i in Main_Menu.chaoticScores)
            {
                displayWriter.WriteLine(Convert.ToString(i));
            }
            displayWriter.Close();
            Application.Exit();
        }
    }
}