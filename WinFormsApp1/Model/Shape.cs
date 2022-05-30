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
        public abstract Point p1 { get; set; }
        public abstract Point p2 { get; set; }
        public abstract int width { get; set; }
        public abstract Color color { get; set; }
        public abstract Graphics gp { get; set; }

        public abstract void Draw();

    }
}
