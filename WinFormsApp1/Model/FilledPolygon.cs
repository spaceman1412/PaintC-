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
    class FilledPolygon : Shape
    {
        public override Color color { get; set; }
        public override Graphics gp { get; set; }
   

        Point[] points = { };
        List<Point> listPointContainer = new List<Point>();
        int height;

        Brush brush;

        public FilledPolygon(Point p1, Point p2, Graphics gp, int width, Color color)
        {
            this.color = color;
            this.width = width;
            this.gp = gp;
            this.p1 = p1;
            this.p2 = p2;

            brush = new SolidBrush(color);
            this.listPointContainer.Add(p1);
        }

        public override void Draw()
        {
            if (!listPointContainer.Contains(p2) && p2 != p1)
                this.listPointContainer.Add(p2);

            points = this.listPointContainer.ToArray();
            gp.FillPolygon(brush, points);
        }

        public override bool Drag(Point point)
        {
            return false;
        }
    }
}
