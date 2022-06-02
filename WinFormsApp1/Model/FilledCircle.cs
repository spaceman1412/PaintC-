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
    class FilledCircle : Shape
    {
        public override Color color { get; set; }
        public override Graphics gp { get; set; }
      


        int height;
        int radius;
        Brush brush;

        public FilledCircle(Point p1, Point p2, Graphics gp, int width, Color color, DashStyle dashStyle,int zoom)
        {
            this.color = color;
            this.width = width;
            this.gp = gp;
            this.p1 = p1;
            this.p2 = p2;
            this.dashStyle = dashStyle;
            this.zoom = zoom;


            brush = new SolidBrush(color);
        }
        public override void Draw()
        {
            radius = Math.Abs(this.p2.X - this.p1.X) + this.zoom;

            if (Math.Abs(this.p2.Y - this.p1.Y) >= radius)
                radius = Math.Abs(this.p2.Y - this.p1.Y);

            int startPointX = this.p1.X - radius;
            int startPointY = this.p1.Y - radius;

            Rectangle rectangle = new Rectangle(startPointX, startPointY, radius * 2, radius * 2);
            gp.FillEllipse(brush, rectangle);
        }
        public override bool Drag(Point point)
        {
            radius = Math.Abs(this.p2.X - this.p1.X) + this.zoom;

            if (Math.Abs(this.p2.Y - this.p1.Y) >= radius)
                radius = Math.Abs(this.p2.Y - this.p1.Y);

            int startPointX = this.p1.X - radius;
            int startPointY = this.p1.Y - radius;

            Rectangle rectangle = new Rectangle(startPointX, startPointY, radius * 2, radius * 2);

            if (rectangle.Contains(point))
            {
                return true;
            }
            else
                return false;
        }

    }
}
