using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Main_Menu()
        {
            InitializeComponent();
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
    }
}
