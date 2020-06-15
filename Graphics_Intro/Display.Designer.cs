namespace Graphics_Intro
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLbl = new System.Windows.Forms.Label();
            this.startLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLbl.Location = new System.Drawing.Point(730, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(55, 20);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score:";
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.BackColor = System.Drawing.Color.Transparent;
            this.startLbl.Location = new System.Drawing.Point(318, 290);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(122, 20);
            this.startLbl.TabIndex = 1;
            this.startLbl.Text = "Press D to Start";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.scoreLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Display";
            this.Text = "Snake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Display_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label startLbl;
    }
}

