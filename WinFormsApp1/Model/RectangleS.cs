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
        
        public override Graphics gp { get; set; }
      


        int height;
        Pen pen;

        public RectangleS(Point p1, Point p2, Graphics gp, int width, Color color, DashStyle dashStyle,int zoom)
        {
            this.color = color;
            this.width = width;
            this.gp = gp;
            this.p1 = p1;
            this.p2 = p2;
            this.dashStyle = dashStyle;
            this.zoom = zoom;

            pen = new Pen(color, width);
            pen.DashStyle = dashStyle;
        }

        public override void Draw()
        {
            this.width = Math.Abs(this.p2.X - this.p1.X)+ this.zoom;
            this.height = Math.Abs(this.p2.Y - this.p1.Y) + this.zoom;


            Rectangle rectangle = new Rectangle(Math.Min(this.p1.X, this.p2.X),
                       Math.Min(this.p1.Y, this.p2.Y),
                       this.width, this.height);
            gp.DrawRectangle(pen, rectangle);

        }

        public override bool Drag(Point point)
        {
            this.width = Math.Abs(this.p2.X - this.p1.X) + this.zoom;
            this.height = Math.Abs(this.p2.Y - this.p1.Y) + this.zoom;

            Rectangle rectangle = new Rectangle(Math.Min(this.p1.X, this.p2.X),
                        Math.Min(this.p1.Y, this.p2.Y),
                        this.width, this.height);

            if (rectangle.Contains(point))
            {
                return true;
            }
            else
                return false;
        }
    }
}
