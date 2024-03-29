﻿using ButtonView;
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
    public class PrevBtn: AbstrButton
    {
        Image play_pic = Resource1.Previous_btn;
        public PrevBtn() {

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            
            base.OnPaint(pevent);
            pevent.Graphics.FillEllipse(new SolidBrush(Theme),Width / 7, Height / 5,3*Width / 5, Height / 2);
            pevent.Graphics.DrawImage(play_pic, 0, 0, Width, Height);
        }
    }
    
}
