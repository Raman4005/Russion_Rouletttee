namespace RussianRouletteAssignment
{
    partial class frmHighScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVHighScores = new System.Windows.Forms.DataGridView();
            this.DGUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGHighScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadScores = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnClearSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHighScores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "HighScores:";
            // 
            // DGVHighScores
            // 
            this.DGVHighScores.AllowUserToAddRows = false;
            this.DGVHighScores.AllowUserToDeleteRows = false;
            this.DGVHighScores.AllowUserToResizeColumns = false;
            this.DGVHighScores.AllowUserToResizeRows = false;
            this.DGVHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHighScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGUsername,
            this.DGHighScore});
            this.DGVHighScores.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVHighScores.Location = new System.Drawing.Point(13, 35);
            this.DGVHighScores.Name = "DGVHighScores";
            this.DGVHighScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHighScores.Size = new System.Drawing.Size(244, 215);
            this.DGVHighScores.TabIndex = 2;
            // 
            // DGUsername
            // 
            this.DGUsername.HeaderText = "Username:";
            this.DGUsername.Name = "DGUsername";
            this.DGUsername.ReadOnly = true;
            this.DGUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGUsername.Width = 101;
            // 
            // DGHighScore
            // 
            this.DGHighScore.HeaderText = "Highscores:";
            this.DGHighScore.Name = "DGHighScore";
            this.DGHighScore.ReadOnly = true;
            this.DGHighScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnLoadScores
            // 
            this.btnLoadScores.BackColor = System.Drawing.Color.DarkRed;
            this.btnLoadScores.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadScores.Location = new System.Drawing.Point(12, 256);
            this.btnLoadScores.Name = "btnLoadScores";
            this.btnLoadScores.Size = new System.Drawing.Size(75, 23);
            this.btnLoadScores.TabIndex = 3;
            this.btnLoadScores.Text = "Load scores";
            this.btnLoadScores.UseVisualStyleBackColor = false;
            this.btnLoadScores.Click += new System.EventHandler(this.btnLoadScores_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(176, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.BackColor = System.Drawing.Color.DarkRed;
            this.btnClearScores.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearScores.Location = new System.Drawing.Point(182, 256);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(75, 23);
            this.btnClearScores.TabIndex = 5;
            this.btnClearScores.Text = "Clear all scores";
            this.btnClearScores.UseVisualStyleBackColor = false;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.BackColor = System.Drawing.Color.DarkRed;
            this.btnClearSelected.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearSelected.Location = new System.Drawing.Point(85, 256);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(101, 23);
            this.btnClearSelected.TabIndex = 6;
            this.btnClearSelected.Text = "Clear Selected";
            this.btnClearSelected.UseVisualStyleBackColor = false;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(270, 288);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoadScores);
            this.Controls.Add(this.DGVHighScores);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmHighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
            ((System.ComponentModel.ISupportInitialize)(this.DGVHighScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVHighScores;
        private System.Windows.Forms.Button btnLoadScores;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGHighScore;
    }
}