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
    class Polygon  : Shape
    {
        public override Color color { get; set; }
        public override int width { get; set; }
        public override Graphics gp { get; set; }
        public override Point p1 { get; set; }
        public override Point p2 { get; set; }

        Point[] points = { };
        List<Point> listPointContainer = new List<Point>();
        int height;
        
        Pen pen;

        public Polygon(Point p1, Point p2, Graphics gp, int width, Color color)
        {
            this.color = color;
            this.width = width;
            this.gp = gp;
            this.p1 = p1;
            this.p2 = p2;

            pen = new Pen(color, width);
            this.listPointContainer.Add(p1);
        }

        public override void Draw()
        {
            if (!listPointContainer.Contains(p2) && p2 != p1)
                this.listPointContainer.Add(p2);

            points = this.listPointContainer.ToArray();
            gp.DrawPolygon(pen, points);
        }

    }
}
