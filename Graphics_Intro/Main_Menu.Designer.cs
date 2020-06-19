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
            this.classicScoresListbx = new System.Windows.Forms.ListBox();
            this.scoresPnl = new System.Windows.Forms.Panel();
            this.returnBtn = new System.Windows.Forms.Button();
            this.chaoticScoresListbx = new System.Windows.Forms.ListBox();
            this.arcadeScoresListbx = new System.Windows.Forms.ListBox();
            this.classicLbl = new System.Windows.Forms.Label();
            this.arcadeLbl = new System.Windows.Forms.Label();
            this.chaoticLbl = new System.Windows.Forms.Label();
            this.highscoresLbl = new System.Windows.Forms.Label();
            this.scoresPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchBtn
            // 
            this.launchBtn.Font = new System.Drawing.Font("Impact", 9.5F);
            this.launchBtn.Location = new System.Drawing.Point(654, 367);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(135, 71);
            this.launchBtn.TabIndex = 0;
            this.launchBtn.Text = "Launch Snake";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            this.launchBtn.MouseEnter += new System.EventHandler(this.launchBtn_MouseEnter);
            this.launchBtn.MouseLeave += new System.EventHandler(this.launchBtn_MouseLeave);
            // 
            // highscoreLbl
            // 
            this.highscoreLbl.AutoSize = true;
            this.highscoreLbl.Font = new System.Drawing.Font("Impact", 9.5F);
            this.highscoreLbl.Location = new System.Drawing.Point(649, 319);
            this.highscoreLbl.Name = "highscoreLbl";
            this.highscoreLbl.Size = new System.Drawing.Size(140, 23);
            this.highscoreLbl.TabIndex = 1;
            this.highscoreLbl.Text = "View Highscores";
            this.highscoreLbl.Click += new System.EventHandler(this.highscoreLbl_Click);
            this.highscoreLbl.MouseEnter += new System.EventHandler(this.highscoreLbl_MouseEnter);
            this.highscoreLbl.MouseLeave += new System.EventHandler(this.highscoreLbl_MouseLeave);
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
            // classicScoresListbx
            // 
            this.classicScoresListbx.FormattingEnabled = true;
            this.classicScoresListbx.ItemHeight = 20;
            this.classicScoresListbx.Location = new System.Drawing.Point(4, 98);
            this.classicScoresListbx.Name = "classicScoresListbx";
            this.classicScoresListbx.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.classicScoresListbx.Size = new System.Drawing.Size(255, 344);
            this.classicScoresListbx.TabIndex = 9;
            // 
            // scoresPnl
            // 
            this.scoresPnl.Controls.Add(this.highscoresLbl);
            this.scoresPnl.Controls.Add(this.chaoticLbl);
            this.scoresPnl.Controls.Add(this.arcadeLbl);
            this.scoresPnl.Controls.Add(this.classicLbl);
            this.scoresPnl.Controls.Add(this.returnBtn);
            this.scoresPnl.Controls.Add(this.chaoticScoresListbx);
            this.scoresPnl.Controls.Add(this.arcadeScoresListbx);
            this.scoresPnl.Controls.Add(this.classicScoresListbx);
            this.scoresPnl.Location = new System.Drawing.Point(103, -4);
            this.scoresPnl.Name = "scoresPnl";
            this.scoresPnl.Size = new System.Drawing.Size(540, 442);
            this.scoresPnl.TabIndex = 10;
            this.scoresPnl.Visible = false;
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(4, 9);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(102, 45);
            this.returnBtn.TabIndex = 12;
            this.returnBtn.Text = "Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            this.returnBtn.MouseEnter += new System.EventHandler(this.returnBtn_MouseEnter);
            this.returnBtn.MouseLeave += new System.EventHandler(this.returnBtn_MouseLeave);
            // 
            // chaoticScoresListbx
            // 
            this.chaoticScoresListbx.FormattingEnabled = true;
            this.chaoticScoresListbx.ItemHeight = 20;
            this.chaoticScoresListbx.Location = new System.Drawing.Point(534, 98);
            this.chaoticScoresListbx.Name = "chaoticScoresListbx";
            this.chaoticScoresListbx.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chaoticScoresListbx.Size = new System.Drawing.Size(259, 344);
            this.chaoticScoresListbx.TabIndex = 11;
            // 
            // arcadeScoresListbx
            // 
            this.arcadeScoresListbx.FormattingEnabled = true;
            this.arcadeScoresListbx.ItemHeight = 20;
            this.arcadeScoresListbx.Location = new System.Drawing.Point(269, 98);
            this.arcadeScoresListbx.Name = "arcadeScoresListbx";
            this.arcadeScoresListbx.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.arcadeScoresListbx.Size = new System.Drawing.Size(259, 344);
            this.arcadeScoresListbx.TabIndex = 10;
            // 
            // classicLbl
            // 
            this.classicLbl.AutoSize = true;
            this.classicLbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLbl.Location = new System.Drawing.Point(63, 66);
            this.classicLbl.Name = "classicLbl";
            this.classicLbl.Size = new System.Drawing.Size(84, 29);
            this.classicLbl.TabIndex = 13;
            this.classicLbl.Text = "Classic";
            // 
            // arcadeLbl
            // 
            this.arcadeLbl.AutoSize = true;
            this.arcadeLbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcadeLbl.Location = new System.Drawing.Point(345, 66);
            this.arcadeLbl.Name = "arcadeLbl";
            this.arcadeLbl.Size = new System.Drawing.Size(82, 29);
            this.arcadeLbl.TabIndex = 14;
            this.arcadeLbl.Text = "Arcade";
            // 
            // chaoticLbl
            // 
            this.chaoticLbl.AutoSize = true;
            this.chaoticLbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaoticLbl.Location = new System.Drawing.Point(631, 66);
            this.chaoticLbl.Name = "chaoticLbl";
            this.chaoticLbl.Size = new System.Drawing.Size(88, 29);
            this.chaoticLbl.TabIndex = 15;
            this.chaoticLbl.Text = "Chaotic";
            // 
            // highscoresLbl
            // 
            this.highscoresLbl.AutoSize = true;
            this.highscoresLbl.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresLbl.Location = new System.Drawing.Point(280, 6);
            this.highscoresLbl.Name = "highscoresLbl";
            this.highscoresLbl.Size = new System.Drawing.Size(207, 48);
            this.highscoresLbl.TabIndex = 16;
            this.highscoresLbl.Text = "Highscores";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoresPnl);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.scoresPnl.ResumeLayout(false);
            this.scoresPnl.PerformLayout();
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
        private System.Windows.Forms.ListBox classicScoresListbx;
        private System.Windows.Forms.Panel scoresPnl;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.ListBox chaoticScoresListbx;
        private System.Windows.Forms.ListBox arcadeScoresListbx;
        private System.Windows.Forms.Label highscoresLbl;
        private System.Windows.Forms.Label chaoticLbl;
        private System.Windows.Forms.Label arcadeLbl;
        private System.Windows.Forms.Label classicLbl;
    }
}