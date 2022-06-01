using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Model
{
    abstract class Shape
    {
        public Point p1;
        public Point p2;
        public int width;
        public abstract Color color { get; set; }
        public abstract Graphics gp { get; set; }

        public abstract void Draw();
        public abstract bool Drag(Point point);

    }
}
