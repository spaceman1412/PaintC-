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
    class RectangleS : Shape
    {
        public override Color color { get; set; }
        public override int width { get; set; }
        public override Graphics gp { get; set; }
        public override Point p1 { get; set; }
        public override Point p2 { get; set; }


        int height;
        Pen pen;

        public RectangleS(Point p1, Point p2, Graphics gp, int width, Color color)
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
            this.width = Math.Abs(this.p2.X - this.p1.X);
            this.height = Math.Abs(this.p2.Y - this.p1.Y);


            Rectangle rectangle = new Rectangle(Math.Min(this.p1.X, this.p2.X),
                       Math.Min(this.p1.Y, this.p2.Y),
                       this.width, this.height);
            gp.DrawRectangle(pen, rectangle);

        }
    }
}
