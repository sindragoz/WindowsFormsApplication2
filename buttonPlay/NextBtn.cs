using ButtonView;
using ElementBaseView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonPlay
{
   public class NextBtn: AbstrButton
    {
        Image play_pic = Resource1.Next_btn;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            SolidBrush br = new SolidBrush(Theme);
            pevent.Graphics.FillEllipse(new SolidBrush(Theme), Width / 4, Height / 5, 2*Width / 3, Height / 2);
            pevent.Graphics.DrawImage(play_pic, 0, 0, Width, Height);
            
        }
    }
}
