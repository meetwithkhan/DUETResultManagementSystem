using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    class CornerRoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            gp.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            gp.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            gp.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            gp.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new System.Drawing.Region(gp);
            base.OnPaint(pevent);
        }
    }
}
