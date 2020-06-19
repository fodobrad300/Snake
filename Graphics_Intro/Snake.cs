using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Deployment.Application;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Graphics_Intro
{
    class Snake
    {
        public int length;
        public int width;
        public int headX;
        public int headY;
        public int speed;
        public float score = 0;
        

        public List<int> coords_x = new List<int>();
        public List<int> coords_y = new List<int>();
        public string direction;

        public Snake(string direction, int length, int width, int headX, int headY, int speed)
        {
            this.direction = direction;
            this.width = width;
            this.length = length;
            this.headX = headX;
            this.headY = headY;
            this.speed = speed;

            for (int i = 0; i < length; i++)
            {
                coords_x.Add(headX - (width * i));
            }
            for (int i = 0; i< length; i++)
            {
                coords_y.Add(headY);
            }
        }
        public bool death()
        {
            bool done = false;
            //check for a highscore and reset game
            if (Main_Menu.mode == "Classic (1 Object)")
            {
                for (int i = 9; done == false; i--)
                {
                    if(score/2 > Main_Menu.classicScores[i])
                    {
                        if (i == 9)
                        {
                            Main_Menu.classicScores[i] = (int)score/2;
                        }
                        else
                        {
                            Main_Menu.classicScores[i + 1] = Main_Menu.classicScores[i];
                            Main_Menu.classicScores[i] = (int)score/2;
                            if (i == 0)
                            {
                                done = true;
                            }
                        }
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            else if (Main_Menu.mode == "Arcade (3 Objects)")
            {

            }
            else 
            {

            }
            direction = null;
            score = 0;
            coords_x.Clear();
            coords_y.Clear();
            Object.pos_x.Clear();
            Object.pos_y.Clear();
            Object.decay.Clear();
            Object.spawnAll();
            Display.play = false;
            
            for (int i = 0; i < length; i++)
            {
                coords_x.Add(headX - (5 * i));
            }
            for (int i = 0; i < length; i++)
            {
                coords_y.Add(headY);
            }
            return true;
        }
        public int move()
        {
            if (direction == "up")
            {
                //precheck to see if the user will touch edge on next tick
                if (coords_y[0] - 5 <= 80 || coords_x[0]-5<= 10)
                {
                    death();
                }
                else
                {
                    //update coordinates
                    for (int i = coords_x.Count - 1; i > 0; i--)
                    {
                        coords_y[i] = coords_y[i - 1];
                        coords_x[i] = coords_x[i - 1];
                    }
                    //move snake
                    coords_y[0] -= speed;
                }
            }
            else if (direction == "down")
            {
                //precheck to see if the user will die on the next tick
                if (coords_y[0] + 5 >= headY*2-10|| coords_x[0] >= headX * 2-10)
                {
                     death();
                }
                else
                {
                    //update coordinates
                    for (int i = coords_x.Count - 1; i > 0; i--)
                    {
                        coords_y[i] = coords_y[i - 1];
                        coords_x[i] = coords_x[i - 1];
                    }
                    //move snake
                    coords_y[0] += speed;
                }
            }
            else if (direction == "left")
            {
                //precheck to see if the user will die on the next tick
                if (coords_x[0] - 5 <= 10|| coords_y[0] - 5 <= 80)
                {
                    death();
                }
                else
                {
                    //update coordinates
                    for (int i = coords_x.Count - 1; i > 0; i--)
                    {
                        coords_y[i] = coords_y[i - 1];
                        coords_x[i] = coords_x[i - 1];
                    }
                    //move snake
                    coords_x[0] -= speed;
                }
            }
            else if (direction == "right")
            {
                //precheck to see if the user will die on the next tick
                if (coords_x[0] >= headX*2-10|| coords_y[0] + 5 >= headY * 2-10)
                {
                    death();
                }
                else
                {
                    //update coordinates
                    for (int i = coords_x.Count - 1; i > 0; i--)
                    {
                        coords_y[i] = coords_y[i - 1];
                        coords_x[i] = coords_x[i - 1];
                    }
                    //move snake
                    coords_x[0] += speed;
                }
            }
            //see if user will touch itself
            for (int i = 1; i < coords_x.Count - 1; i++)
            {
                if (coords_x[0] == coords_x[i] && coords_y[0] == coords_y[i])
                {
                    death();
                }
            }
            for (int i = 0; i <= Object.pos_x.Count - 1; i++)
            {
                //check to see if any objects are hit
                if (coords_x[0] >= Object.pos_x[i] - Object.radius && coords_x[0] <= Object.pos_x[i] + 2 * Object.radius && coords_y[0] >= Object.pos_y[i] - Object.radius && coords_y[0] <= Object.pos_y[i] + 2 * Object.radius)
                {
                    score++;
                    return i;
                }
            }
            //return a value that won't grow anything
            return -1;
        }
        public void grow(int number)
        {
            //adds a length to the snake depending on the direction it is moving
            //or takes length away if snake touches a bad object
            int grow = 0;
            if (Object.decay[number] < 100) 
            {
                grow = 1;
                score+=grow;
                
                if (direction == "up")
                {
                    coords_x.Add(coords_x[coords_x.Count - 1]);
                    coords_y.Add(coords_y[coords_y.Count - 1] + width);
                }
                else if (direction == "down")
                {
                    coords_x.Add(coords_x[coords_x.Count - 1]);
                    coords_y.Add(coords_y[coords_y.Count - 1] - width);
                }
                else if (direction == "left")
                {
                    coords_x.Add(coords_x[coords_x.Count - 1] + width);
                    coords_y.Add(coords_y[coords_y.Count - 1]);
                }
                else if (direction == "right")
                {
                    coords_x.Add(coords_x[coords_x.Count - 1] - width);
                    coords_y.Add(coords_y[coords_y.Count - 1]);
                }
            }
            else if (Object.decay[number] < 200)
            {
                
                grow = -5;
                score += grow;
                for(int i = 0; i < -grow; i++)
                {
                    coords_x.RemoveAt(coords_x.Count-1);
                    coords_y.RemoveAt(coords_y.Count - 1);
                    if (coords_x.Count <= 1)
                    {
                        death();
                    }
                }
                if (coords_x.Count <= 1)
                {
                    death();
                }
            }
        }
    }
}
