namespace RussianRouletteAssignment
{
    partial class frmGame
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
            this.btnBulletLoad = new System.Windows.Forms.Button();
            this.btnChamberSpin = new System.Windows.Forms.Button();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBulletsLeft = new System.Windows.Forms.Label();
            this.lblShotOrNot = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAimAwayChances = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnSaveHighScore = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAimHead = new System.Windows.Forms.PictureBox();
            this.pbAimAway = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAimHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAimAway)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBulletLoad
            // 
            this.btnBulletLoad.BackColor = System.Drawing.Color.DarkRed;
            this.btnBulletLoad.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnBulletLoad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulletLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBulletLoad.Location = new System.Drawing.Point(252, 92);
            this.btnBulletLoad.Name = "btnBulletLoad";
            this.btnBulletLoad.Size = new System.Drawing.Size(98, 29);
            this.btnBulletLoad.TabIndex = 0;
            this.btnBulletLoad.Text = "Load bullet!";
            this.btnBulletLoad.UseVisualStyleBackColor = false;
            this.btnBulletLoad.Click += new System.EventHandler(this.btnBulletLoad_Click);
            // 
            // btnChamberSpin
            // 
            this.btnChamberSpin.BackColor = System.Drawing.Color.DarkRed;
            this.btnChamberSpin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnChamberSpin.Enabled = false;
            this.btnChamberSpin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamberSpin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChamberSpin.Location = new System.Drawing.Point(359, 92);
            this.btnChamberSpin.Name = "btnChamberSpin";
            this.btnChamberSpin.Size = new System.Drawing.Size(98, 29);
            this.btnChamberSpin.TabIndex = 1;
            this.btnChamberSpin.Text = "Spin Chamber";
            this.btnChamberSpin.UseVisualStyleBackColor = false;
            this.btnChamberSpin.Click += new System.EventHandler(this.btnChamberSpin_Click);
            // 
            // btnNextRound
            // 
            this.btnNextRound.BackColor = System.Drawing.Color.DarkRed;
            this.btnNextRound.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnNextRound.Enabled = false;
            this.btnNextRound.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextRound.Location = new System.Drawing.Point(12, 335);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(194, 61);
            this.btnNextRound.TabIndex = 2;
            this.btnNextRound.Text = "Next Round!";
            this.btnNextRound.UseVisualStyleBackColor = false;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(9, 11);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(39, 18);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Hello";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Load up, spin the chamber and shoot away!\r\nRemember if you shoot yourself, you lo" +
    "se!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aim at head ";
            // 
            // lblBulletsLeft
            // 
            this.lblBulletsLeft.AutoSize = true;
            this.lblBulletsLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblBulletsLeft.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletsLeft.Location = new System.Drawing.Point(287, 58);
            this.lblBulletsLeft.Name = "lblBulletsLeft";
            this.lblBulletsLeft.Size = new System.Drawing.Size(104, 22);
            this.lblBulletsLeft.TabIndex = 9;
            this.lblBulletsLeft.Text = "Shots left: 6";
            // 
            // lblShotOrNot
            // 
            this.lblShotOrNot.AutoSize = true;
            this.lblShotOrNot.BackColor = System.Drawing.Color.Transparent;
            this.lblShotOrNot.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotOrNot.ForeColor = System.Drawing.Color.Red;
            this.lblShotOrNot.Location = new System.Drawing.Point(250, 369);
            this.lblShotOrNot.Name = "lblShotOrNot";
            this.lblShotOrNot.Size = new System.Drawing.Size(0, 22);
            this.lblShotOrNot.TabIndex = 10;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DarkRed;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnRestart.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(12, 402);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(88, 33);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(287, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(112, 22);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Your score: 0";
            // 
            // lblAimAwayChances
            // 
            this.lblAimAwayChances.AutoSize = true;
            this.lblAimAwayChances.BackColor = System.Drawing.Color.Transparent;
            this.lblAimAwayChances.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAimAwayChances.ForeColor = System.Drawing.Color.Red;
            this.lblAimAwayChances.Location = new System.Drawing.Point(248, 335);
            this.lblAimAwayChances.Name = "lblAimAwayChances";
            this.lblAimAwayChances.Size = new System.Drawing.Size(204, 22);
            this.lblAimAwayChances.TabIndex = 13;
            this.lblAimAwayChances.Text = "Aim away chances left: 2";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(287, 21);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(80, 22);
            this.lblRound.TabIndex = 14;
            this.lblRound.Text = "Round: 1";
            // 
            // btnSaveHighScore
            // 
            this.btnSaveHighScore.BackColor = System.Drawing.Color.DarkRed;
            this.btnSaveHighScore.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnSaveHighScore.Enabled = false;
            this.btnSaveHighScore.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveHighScore.Location = new System.Drawing.Point(116, 402);
            this.btnSaveHighScore.Name = "btnSaveHighScore";
            this.btnSaveHighScore.Size = new System.Drawing.Size(90, 33);
            this.btnSaveHighScore.TabIndex = 15;
            this.btnSaveHighScore.Text = "Save Score";
            this.btnSaveHighScore.UseVisualStyleBackColor = false;
            this.btnSaveHighScore.Click += new System.EventHandler(this.btnSaveHighScore_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnMenu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(359, 402);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 33);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "OR";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pbAimHead
            // 
            this.pbAimHead.BackColor = System.Drawing.Color.Transparent;
            this.pbAimHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAimHead.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbAimHead.Enabled = false;
            this.pbAimHead.Image = global::RussianRouletteAssignment.Properties.Resources.pokerFace2;
            this.pbAimHead.Location = new System.Drawing.Point(12, 149);
            this.pbAimHead.Name = "pbAimHead";
            this.pbAimHead.Size = new System.Drawing.Size(194, 180);
            this.pbAimHead.TabIndex = 6;
            this.pbAimHead.TabStop = false;
            this.pbAimHead.Click += new System.EventHandler(this.pbAimHead_Click);
            // 
            // pbAimAway
            // 
            this.pbAimAway.BackColor = System.Drawing.Color.Transparent;
            this.pbAimAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAimAway.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbAimAway.Enabled = false;
            this.pbAimAway.Image = global::RussianRouletteAssignment.Properties.Resources.aimAway;
            this.pbAimAway.Location = new System.Drawing.Point(252, 149);
            this.pbAimAway.Name = "pbAimAway";
            this.pbAimAway.Size = new System.Drawing.Size(205, 180);
            this.pbAimAway.TabIndex = 19;
            this.pbAimAway.TabStop = false;
            this.pbAimAway.Click += new System.EventHandler(this.pbAimAway_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkRed;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnHelp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Location = new System.Drawing.Point(254, 402);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(96, 33);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Aim away";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbAimAway);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSaveHighScore);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblAimAwayChances);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblShotOrNot);
            this.Controls.Add(this.lblBulletsLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAimHead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.btnChamberSpin);
            this.Controls.Add(this.btnBulletLoad);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAimHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAimAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBulletLoad;
        private System.Windows.Forms.Button btnChamberSpin;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAimHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBulletsLeft;
        private System.Windows.Forms.Label lblShotOrNot;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAimAwayChances;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnSaveHighScore;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbAimAway;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label4;
    }
}