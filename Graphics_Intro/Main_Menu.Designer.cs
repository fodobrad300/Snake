namespace Graphics_Intro
{
    partial class Main_Menu
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
            this.launchBtn = new System.Windows.Forms.Button();
            this.highscoreLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.resolutionLbl = new System.Windows.Forms.Label();
            this.customResolution = new System.Windows.Forms.CheckBox();
            this.resolutionUpDown = new System.Windows.Forms.DomainUpDown();
            this.modeLbl = new System.Windows.Forms.Label();
            this.modeUpDown = new System.Windows.Forms.DomainUpDown();
            this.helpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchBtn
            // 
            this.launchBtn.Location = new System.Drawing.Point(664, 367);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(124, 71);
            this.launchBtn.TabIndex = 0;
            this.launchBtn.Text = "Launch Snake";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // highscoreLbl
            // 
            this.highscoreLbl.AutoSize = true;
            this.highscoreLbl.Location = new System.Drawing.Point(664, 319);
            this.highscoreLbl.Name = "highscoreLbl";
            this.highscoreLbl.Size = new System.Drawing.Size(127, 20);
            this.highscoreLbl.TabIndex = 1;
            this.highscoreLbl.Text = "View Highscores";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(312, 35);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(126, 20);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Snake Launcher";
            // 
            // resolutionLbl
            // 
            this.resolutionLbl.AutoSize = true;
            this.resolutionLbl.Location = new System.Drawing.Point(12, 208);
            this.resolutionLbl.Name = "resolutionLbl";
            this.resolutionLbl.Size = new System.Drawing.Size(85, 20);
            this.resolutionLbl.TabIndex = 2;
            this.resolutionLbl.Text = "Resolution";
            // 
            // customResolution
            // 
            this.customResolution.AutoSize = true;
            this.customResolution.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customResolution.Location = new System.Drawing.Point(12, 181);
            this.customResolution.Name = "customResolution";
            this.customResolution.Size = new System.Drawing.Size(170, 24);
            this.customResolution.TabIndex = 3;
            this.customResolution.Text = "Custom Resolution";
            this.customResolution.UseVisualStyleBackColor = true;
            // 
            // resolutionUpDown
            // 
            this.resolutionUpDown.Location = new System.Drawing.Point(16, 232);
            this.resolutionUpDown.Name = "resolutionUpDown";
            this.resolutionUpDown.ReadOnly = true;
            this.resolutionUpDown.Size = new System.Drawing.Size(166, 26);
            this.resolutionUpDown.TabIndex = 4;
            this.resolutionUpDown.Text = "Default ";
            this.resolutionUpDown.SelectedItemChanged += new System.EventHandler(this.resolutionUpDown_SelectedItemChanged);
            // 
            // modeLbl
            // 
            this.modeLbl.AutoSize = true;
            this.modeLbl.Location = new System.Drawing.Point(12, 319);
            this.modeLbl.Name = "modeLbl";
            this.modeLbl.Size = new System.Drawing.Size(49, 20);
            this.modeLbl.TabIndex = 6;
            this.modeLbl.Text = "Mode";
            // 
            // modeUpDown
            // 
            this.modeUpDown.Items.Add("Classic (1 Object)");
            this.modeUpDown.Items.Add("Arcade (3 Objects)");
            this.modeUpDown.Items.Add("Chaotic (Loads of Objects)");
            this.modeUpDown.Location = new System.Drawing.Point(12, 342);
            this.modeUpDown.Name = "modeUpDown";
            this.modeUpDown.ReadOnly = true;
            this.modeUpDown.Size = new System.Drawing.Size(166, 26);
            this.modeUpDown.TabIndex = 7;
            this.modeUpDown.Text = "Select a Mode";
            this.modeUpDown.SelectedItemChanged += new System.EventHandler(this.modeUpDown_SelectedItemChanged);
            // 
            // helpLbl
            // 
            this.helpLbl.AutoSize = true;
            this.helpLbl.Location = new System.Drawing.Point(349, 392);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(0, 20);
            this.helpLbl.TabIndex = 8;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpLbl);
            this.Controls.Add(this.modeUpDown);
            this.Controls.Add(this.modeLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.resolutionUpDown);
            this.Controls.Add(this.customResolution);
            this.Controls.Add(this.resolutionLbl);
            this.Controls.Add(this.highscoreLbl);
            this.Controls.Add(this.launchBtn);
            this.Name = "Main_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.Label highscoreLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label resolutionLbl;
        private System.Windows.Forms.CheckBox customResolution;
        private System.Windows.Forms.DomainUpDown resolutionUpDown;
        private System.Windows.Forms.Label modeLbl;
        private System.Windows.Forms.DomainUpDown modeUpDown;
        private System.Windows.Forms.Label helpLbl;
    }
}