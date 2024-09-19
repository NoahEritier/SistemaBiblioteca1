using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public class PillButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, this.Height, this.Height, 90, 180);
            path.AddArc(this.Width - this.Height, 0, this.Height, this.Height, 270, 180);
            path.CloseFigure();
            this.Region = new Region(path);
            pevent.Graphics.DrawPath(Pens.Transparent, path);
        }
    }

}
