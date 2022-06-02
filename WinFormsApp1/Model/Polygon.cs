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
        public override Graphics gp { get; set; }
        

        Point[] points = { };
        List<Point> listPointContainer = new List<Point>();
        int height;
        
        Pen pen;

        public Polygon(Point p1, Point p2, Graphics gp, int width, Color color,DashStyle dashStyle,int zoom)
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

            this.listPointContainer.Add(p1);
        }

        public override void Draw()
        {
            if (!listPointContainer.Contains(p2) && p2 != p1)
                this.listPointContainer.Add(p2);

            points = this.listPointContainer.ToArray();
            gp.DrawPolygon(pen, points);
        }

        public override bool Drag(Point point)
        {
            return false;
        }

    }
}
