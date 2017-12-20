using ButtonView;
using ElementBaseView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonPlay
{
    public class PlayBtn:AbstrButton
    {
        Image play_pic =Resource1.Play_btn;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
            BackColor = Color.Transparent;
            Invalidate();
            Parent = null;

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ClientRectangle);
            Region r = new Region(gp);
            Region = r;
            base.OnPaint(pevent);
            pevent.Graphics.FillEllipse(new SolidBrush(Theme),Width/4,Height/4,Width/2,Height/2);
            pevent.Graphics.DrawImage(play_pic,0,0,Width,Height);
        }
    }
}
