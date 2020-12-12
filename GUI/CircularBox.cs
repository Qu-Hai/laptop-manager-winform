using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace GUI
{
    class CircularBox : IconButton
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graph = new GraphicsPath();
            graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graph);
            base.OnPaint(pevent);
            base.OnPaint(pevent);
        }
    }
}
