using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    class Circular_Image : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Circular Image
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);
        }
    }
}
