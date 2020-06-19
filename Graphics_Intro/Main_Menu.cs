using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Intro
{
    public partial class Main_Menu : Form
    {
        public static Size defaultResolution = new Size(550, 300);
        public static Size resolution = defaultResolution;
        bool modeChange = false;
        public static string mode;
        public static List<int> classicScores = new List<int>();
        public static List<int> arcadeScores = new List<int>();
        public static List<int> chaoticScores = new List<int>();
        public Main_Menu()
        {
            InitializeComponent();
            int count = 1;
            foreach (string line in File.ReadLines(@"scores.txt", Encoding.UTF8))
            {
                if (count <= 10)
                {
                    classicScores.Add(Convert.ToInt32(line));
                }
                else if (count <= 20)
                {
                    arcadeScores.Add(Convert.ToInt32(line));
                }
                else
                {
                    chaoticScores.Add(Convert.ToInt32(line));
                }
                count++;
            }
            
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            if (modeChange)
            {
                Display display = new Display();
                display.Show();
                this.Dispose();
                
            }
            else
            {
                helpLbl.Text = "Select a mode before playing";
            }
        }

        private void resolutionUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            string input = ((string)resolutionUpDown.SelectedItem);
            int size_x = Convert.ToInt32(input.Substring(0, 4).Trim());
            int size_y = Convert.ToInt32(input.Substring(6, input.Length - 1));
            resolution = new Size(size_x, size_y);
        }

        private void modeUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            modeChange = true;
            mode = (string)modeUpDown.SelectedItem;
        }

        private void highscoreLbl_Click(object sender, EventArgs e)
        {
            //set visible to true and set datasources
            scoresPnl.Location = new System.Drawing.Point(0, 0);
            scoresPnl.Size = ClientSize;
            scoresPnl.Visible = true;

            classicScoresListbx.DataSource = classicScores;
            arcadeScoresListbx.DataSource = arcadeScores;
            chaoticScoresListbx.DataSource = chaoticScores;
        }

        //misc menu events (Changing fonts when entering and leaving and such)
        private void returnBtn_Click(object sender, EventArgs e)
        {
            scoresPnl.Visible = false;
        }

        private void highscoreLbl_MouseEnter(object sender, EventArgs e)
        {
            highscoreLbl.Font =  new System.Drawing.Font("Impact", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void highscoreLbl_MouseLeave(object sender, EventArgs e)
        {
            highscoreLbl.Font = new System.Drawing.Font("Impact", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void returnBtn_MouseEnter(object sender, EventArgs e)
        {
            returnBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void returnBtn_MouseLeave(object sender, EventArgs e)
        {
            returnBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void launchBtn_MouseEnter(object sender, EventArgs e)
        {
            launchBtn.Font = new System.Drawing.Font("Impact", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void launchBtn_MouseLeave(object sender, EventArgs e)
        {
            launchBtn.Font = new System.Drawing.Font("Impact", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("scores.txt", String.Empty);
            StreamWriter menuWriter = new StreamWriter("scores.txt");
            foreach (int i in Main_Menu.classicScores)
            {
                menuWriter.WriteLine(Convert.ToString(i));
            }
            foreach (int i in Main_Menu.arcadeScores)
            {
                menuWriter.WriteLine(Convert.ToString(i));
            }
            foreach (int i in Main_Menu.chaoticScores)
            {
                menuWriter.WriteLine(Convert.ToString(i));
            }
            menuWriter.Close();
            Application.Exit();
        }
    }
}
