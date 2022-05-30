using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Model
{
    class Line : Shape
    {
        public override Color color { get; set; }
        public override int width { get; set; }
        public override Graphics gp { get; set; }
        public override Point p1 { get; set; }
        public override Point p2 { get; set; }


        Pen pen;

        public Line(Point p1, Point p2, Graphics gp, int width, Color color)
        {
            this.color = color;
            this.width = width;
            this.gp = gp;
            this.p1 = p1;
            this.p2 = p2;

            pen = new Pen(color, width);
        }


        public override void Draw()
        {
            gp.DrawLine(pen, this.p1,
                  this.p2);
        }

    }
}
