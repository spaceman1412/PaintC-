using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics gp;

        Color color;
        int width;
        enum ButtonClick
        {
            Line,
            Eclipse,
            FilledEclipse,
            Rectangle,
            FilledRectangle,
            Circle,
            FilledCircle,
            Arc,
            Polygon,
            FilledPolygon,
            Null
        }
        bool isStart = false;//a flag

        bool existedPolygon = false;
        List<Shape> shapes = new List<Shape>();
        int ButtonState = (int)ButtonClick.Null;

        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            color = Color.Blue;
            width = 5;

        }

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.isStart = true;


            if (this.ButtonState == (int)ButtonClick.Line)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                Line line = new Line(p1, p2, gp, width, color);

                this.shapes.Add(line);
            }

            if (this.ButtonState == (int)ButtonClick.Eclipse)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                Eclipse eclipse = new Eclipse(p1, p2, gp, width, color);

                this.shapes.Add(eclipse);
            }
            if (this.ButtonState == (int)ButtonClick.FilledEclipse)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                FilledEclipse filledEclipse = new FilledEclipse(p1, p2, gp, width, color);

                this.shapes.Add(filledEclipse);
            }

            if (this.ButtonState == (int)ButtonClick.Rectangle)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                RectangleS rectangleS = new RectangleS(p1, p2, gp, width, color);
                
                this.shapes.Add(rectangleS);
            }

            if (this.ButtonState == (int)ButtonClick.Polygon)
            {
                if(existedPolygon)
                {
                    Point p1 = e.Location;
                    Point p2 = e.Location;

                    Polygon polygon = new Polygon(p1,p2,gp,width,color);
                    this.shapes.Add(polygon);

                }else
                {
                    shapes[this.shapes.Count - 1].p2 = e.Location;
                    plMain.Refresh();
                }

               
                
            }

        }



        private void buttonLine_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Line;
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart == true)
            {
                this.shapes[this.shapes.Count - 1].p2 =
               e.Location;//Update second endpoint
                this.plMain.Refresh();//Call event Paint of plMain 

            }
        }


        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            if (this.isStart == true)
            {
                for (int i = 0; i < this.shapes.Count; i++)
                {
                    this.shapes[i].Draw();
                }

            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.shapes[this.shapes.Count - 1].p2 =
           e.Location;//Update second endpoint
            this.plMain.Refresh();

            if(ButtonState == (int) ButtonClick.Polygon || ButtonState == (int)ButtonClick.FilledPolygon)
            {
                this.existedPolygon = false;
            }

            this.isStart = false;
            this.ButtonState = (int)ButtonClick.Null;
        }

        private void buttonEclipse_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Eclipse;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFilledEclipse_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.FilledEclipse;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Rectangle;
        }

        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Polygon;
            this.existedPolygon = true;

        }
    }
}
