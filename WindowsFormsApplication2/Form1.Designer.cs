namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.musicTrackBar1 = new SoundTrackBar.MusicTrackBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.soundSpectrum2 = new SoundSpectrumVisualisation.SoundSpectrum();
            this.soundSpectrum1 = new SoundSpectrumVisualisation.SoundSpectrum();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicTrackBar1
            // 
            
            this.musicTrackBar1.Location = new System.Drawing.Point(121, 444);
            this.musicTrackBar1.MaximumValue = 100;
            this.musicTrackBar1.MinimumValue = 0;
            this.musicTrackBar1.Name = "musicTrackBar1";
            this.musicTrackBar1.Size = new System.Drawing.Size(445, 20);
            this.musicTrackBar1.TabIndex = 5;
            this.musicTrackBar1.Text = "musicTrackBar1";
            this.musicTrackBar1.Value = 100;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(737, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 526);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // soundSpectrum2
            // 
            this.soundSpectrum2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soundSpectrum2.H_S_Size = 7.390625F;
            this.soundSpectrum2.Location = new System.Drawing.Point(258, 49);
            this.soundSpectrum2.Name = "soundSpectrum2";
            this.soundSpectrum2.Size = new System.Drawing.Size(473, 269);
            this.soundSpectrum2.TabIndex = 8;
            this.soundSpectrum2.Text = "soundSpectrum2";
            this.soundSpectrum2.Click += new System.EventHandler(this.soundSpectrum2_Click);
            // 
            // soundSpectrum1
            // 
            this.soundSpectrum1.H_S_Size = 13.4375F;
            this.soundSpectrum1.Location = new System.Drawing.Point(136, 58);
            this.soundSpectrum1.Name = "soundSpectrum1";
            this.soundSpectrum1.Size = new System.Drawing.Size(430, 189);
            this.soundSpectrum1.TabIndex = 6;
            this.soundSpectrum1.Text = "soundSpectrum1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 587);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.soundSpectrum2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musicTrackBar1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private SoundTrackBar.MusicTrackBar musicTrackBar1;
        private SoundSpectrumVisualisation.SoundSpectrum soundSpectrum1;
        private SoundSpectrumVisualisation.SoundSpectrum soundSpectrum2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        //private SoundTrackBar.MusicTrackBar musicTrackBar1;
    }
}

