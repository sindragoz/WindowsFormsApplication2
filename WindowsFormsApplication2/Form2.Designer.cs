﻿namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.musicPlayer1 = new MusicPlayer.MusicPlayer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // musicPlayer1
            // 
            this.musicPlayer1.BackColor = System.Drawing.Color.Black;
            this.musicPlayer1.Location = new System.Drawing.Point(12, 12);
            this.musicPlayer1.MaximumSize = new System.Drawing.Size(400, 300);
            this.musicPlayer1.MinimumSize = new System.Drawing.Size(400, 300);
            this.musicPlayer1.Name = "musicPlayer1";
            this.musicPlayer1.Size = new System.Drawing.Size(400, 300);
            this.musicPlayer1.TabIndex = 16;
            this.musicPlayer1.Theme = System.Drawing.Color.SkyBlue;
            this.musicPlayer1.Click += new System.EventHandler(this.musicPlayer1_Click);
            this.musicPlayer1.Paint += new System.Windows.Forms.PaintEventHandler(this.musicPlayer1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 332);
            this.Controls.Add(this.musicPlayer1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MusicPlayer.MusicPlayer musicPlayer1;
    }
}