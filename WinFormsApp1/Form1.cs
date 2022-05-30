using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics gp;
        bool bLine = false;
        bool tamgiacLine = false;
        bool khcnLine = false;
        bool eclipseLine = false;
        bool filleclipseLine = false;
        bool fillkhcn = false;

        Pen myPen;
        Color myColor;
        SolidBrush myBrush;

        Point beginPoint = new Point(); //First endpoint
        bool isStart = true;    //a flag
        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            myColor = Color.Blue;
            myPen = new Pen(myColor, 5);
            myBrush = new SolidBrush(myColor);
        }



    }
}
