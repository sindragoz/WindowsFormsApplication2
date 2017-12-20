using ElementBaseView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
   public class MusicPlayer:BaseElement
    {
        private buttonPlay.NextBtn nextBtn1;
        private buttonPlay.PlayBtn playBtn1;
        private buttonPlay.PrevBtn prevBtn1;
        private SoundTrackBar.VolumeTrackBar volumeTrackBar1;
        private SoundTrackBar.RoundedTrackBar roundedTrackBar1;
        private SoundTrackBar.MusicTrackBar musicTrackBar1;
        private SoundSpectrumVisualisation.SoundSpectrum soundSpectrum1;
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }


        }
        private void InitializeComponent()
        {

            this.nextBtn1 = new buttonPlay.NextBtn();
            this.roundedTrackBar1 = new SoundTrackBar.RoundedTrackBar();
            this.playBtn1 = new buttonPlay.PlayBtn();
            this.prevBtn1 = new buttonPlay.PrevBtn();
            this.volumeTrackBar1 = new SoundTrackBar.VolumeTrackBar();
            this.musicTrackBar1 = new SoundTrackBar.MusicTrackBar();
            this.soundSpectrum1 = new SoundSpectrumVisualisation.SoundSpectrum();
            this.SuspendLayout();
            // 
            // nextBtn1
            //           
            this.nextBtn1.Location = new System.Drawing.Point(260, 192);
            this.nextBtn1.Name = "nextBtn1";
            this.nextBtn1.Size = new System.Drawing.Size(50,50);
            this.nextBtn1.TabIndex = 0;
            this.nextBtn1.Text = "nextBtn1";

            // 
            // roundedTrackBar1
            // 
       
            this.roundedTrackBar1.Location = new System.Drawing.Point(145, 165);
            this.roundedTrackBar1.MaximumValue = 100;
            this.roundedTrackBar1.MinimumValue = 0;
            this.roundedTrackBar1.Name = "roundedTrackBar1";
            this.roundedTrackBar1.Size = new System.Drawing.Size(110, 110);
            this.roundedTrackBar1.TabIndex = 0;
            this.roundedTrackBar1.Text = "roundedTrackBar1";
            this.roundedTrackBar1.Theme = System.Drawing.Color.Empty;
            this.roundedTrackBar1.Value = 0;
            // 
            // playBtn1
            // 

            this.playBtn1.Location = new System.Drawing.Point(170, 190);
            this.playBtn1.Name = "playBtn1";
            this.playBtn1.Size = new System.Drawing.Size(60, 60);
            this.playBtn1.TabIndex = 0;
            this.playBtn1.Text = "playBtn1";

            playBtn1.Click += PlayBtn1_Click;
            // 
            // prevBtn1
            // 
            this.prevBtn1.Location = new System.Drawing.Point(95, 192);
            this.prevBtn1.Name = "prevBtn1";
            this.prevBtn1.Size = new System.Drawing.Size(50, 50);
            this.prevBtn1.TabIndex = 0;
            this.prevBtn1.Text = "prevBtn1";

            // 
            // volumeTrackBar1
            // 

            this.volumeTrackBar1.Location = new System.Drawing.Point(355, 225);
            this.volumeTrackBar1.MaximumValue = 100;
            this.volumeTrackBar1.MinimumValue = 0;
            this.volumeTrackBar1.Name = "volumeTrackBar1";
            this.volumeTrackBar1.Size = new System.Drawing.Size(20, 60);
            this.volumeTrackBar1.TabIndex = 0;
            this.volumeTrackBar1.Text = "volumeTrackBar1";
            this.volumeTrackBar1.Value = 0;
            // 
            // musicTrackBar1
            // 
            
            this.musicTrackBar1.Location = new System.Drawing.Point(25, 270);
            this.musicTrackBar1.MaximumValue = 100;
            this.musicTrackBar1.MinimumValue = 0;
            this.musicTrackBar1.Name = "musicTrackBar1";
            this.musicTrackBar1.Size = new System.Drawing.Size(310, 20);
            this.musicTrackBar1.TabIndex = 0;
            this.musicTrackBar1.Text = "musicTrackBar1";
            this.musicTrackBar1.Theme = System.Drawing.Color.Empty;
            this.musicTrackBar1.Value = 0;
            // 
            // soundSpectrum1
            // 

            this.soundSpectrum1.H_S_Size = 1F;
            this.soundSpectrum1.Location = new System.Drawing.Point(25, 10);
            this.soundSpectrum1.MaximumSize = this.soundSpectrum1.MinimumSize = this.soundSpectrum1.Size=new System.Drawing.Size(350,150);
            this.soundSpectrum1.Name = "soundSpectrum1";
            this.soundSpectrum1.Size = new System.Drawing.Size(100, 100);
            this.soundSpectrum1.TabIndex = 0;
            this.soundSpectrum1.Text = "soundSpectrum1";
            this.soundSpectrum1.Theme = System.Drawing.Color.Red;
            
            // 
            // MusicPlayer
            // 
            MinimumSize = MaximumSize = Size = new System.Drawing.Size(400,300);
            this.Controls.Add(this.nextBtn1);
            
            this.Controls.Add(this.playBtn1);
            this.Controls.Add(this.roundedTrackBar1);
            this.Controls.Add(this.prevBtn1);
            this.Controls.Add(this.volumeTrackBar1);
            this.Controls.Add(this.musicTrackBar1);
            this.Controls.Add(this.soundSpectrum1);
            this.ResumeLayout(true);
            BackColor = Color.Black;
            
           
        }

        private void PlayBtn1_Click(object sender, EventArgs e)
        {
            soundSpectrum1.StartVisualization();
        }

        public MusicPlayer() {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var c in Controls)
            {
                (c as Control).MaximumSize = new System.Drawing.Size(1000, 1000);
                if (c is BaseElement)
                    (c as BaseElement).Theme = Theme;
                if (c is AbstrButton)
                    (c as AbstrButton).Theme = Theme;
            }
        }
    }
}
