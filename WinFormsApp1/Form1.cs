using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        bool drag = false;

        bool existedPolygon = false;
        List<Shape> shapes = new List<Shape>();
        List<Shape> clickedShape = new List<Shape>();
        int zoom = 0;
        bool zooming = false;
        bool onDelete = false;
        int ButtonState = (int)ButtonClick.Null;
        DashStyle dashStyle = DashStyle.Solid;
        int position;
        Point mousePosition;
        
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
            this.width =  Int32.Parse(textBoxSize.Text.Trim());
            if (Form.ModifierKeys == Keys.Control)
                this.onDelete = true;

            if (this.ButtonState == (int)ButtonClick.Line)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                Line line = new Line(p1,p2 ,gp, width, color,dashStyle,zoom);
                

                this.shapes.Add(line);
            }

            if (this.ButtonState == (int)ButtonClick.Eclipse)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                Eclipse eclipse = new Eclipse(p1, p2, gp, width, color, dashStyle, zoom);

                this.shapes.Add(eclipse);
            }
            if (this.ButtonState == (int)ButtonClick.FilledEclipse)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                FilledEclipse filledEclipse = new FilledEclipse(p1, p2, gp, width, color, dashStyle, zoom);

                this.shapes.Add(filledEclipse);
            }

            if (this.ButtonState == (int)ButtonClick.Rectangle)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                RectangleS rectangleS = new RectangleS(p1, p2, gp, width, color, dashStyle, zoom);

                this.shapes.Add(rectangleS);
            }

            if (this.ButtonState == (int)ButtonClick.Circle)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                CircleS circleS = new CircleS(p1, p2, gp, width, color, dashStyle, zoom);

                this.shapes.Add(circleS);
            }

            if (this.ButtonState == (int)ButtonClick.FilledCircle)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                FilledCircle filledCircle = new FilledCircle(p1, p2, gp, width, color, dashStyle, zoom);

                this.shapes.Add(filledCircle);
            }


            if (this.ButtonState == (int)ButtonClick.Arc)
            {
                Point p1 = e.Location;
                Point p2 = e.Location;
                Arc arc = new Arc(p1, p2, gp, width, color, dashStyle, zoom);

                this.shapes.Add(arc);
            }


            if (this.ButtonState == (int)ButtonClick.Polygon)
            {
                if (existedPolygon)
                {
                    Point p1 = e.Location;
                    Point p2 = e.Location;

                    Polygon polygon = new Polygon(p1, p2, gp, width, color, dashStyle, zoom);
                    this.shapes.Add(polygon);
                }
                else
                {
                    shapes[this.shapes.Count - 1].p2 = e.Location;
                    plMain.Refresh();
                }
            }
            if (this.ButtonState == (int)ButtonClick.FilledPolygon)
            {
                if (existedPolygon)
                {
                    Point p1 = e.Location;
                    Point p2 = e.Location;

                    FilledPolygon filledPolygon = new FilledPolygon(p1, p2, gp, width, color, dashStyle, zoom);
                    this.shapes.Add(filledPolygon);

                }
                else
                {
                    shapes[this.shapes.Count - 1].p2 = e.Location;
                    plMain.Refresh();
                }
            }
            if(this.ButtonState == (int) ButtonClick.Null )
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].Drag(e.Location))
                    {
                        position = i;
                        this.drag = true;
                        this.mousePosition = e.Location;
                        if(onDelete)
                        {
                            this.clickedShape.Add(shapes[i]);
                        }
                    }
                }
                
            }
            
        }



        private void buttonLine_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Line;
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart && drag == false && this.ButtonState != (int) ButtonClick.Null)
            {
                this.shapes[this.shapes.Count - 1].p2 =
               e.Location;//Update second endpoint
                this.plMain.Refresh();//Call event Paint of plMain 

            }
            if (drag)
            {
                
                Point currentPosition = e.Location;
                int offSetX = currentPosition.X - mousePosition.X;
                int offSetY = currentPosition.Y - mousePosition.Y;

                mousePosition = currentPosition;

                this.shapes[position].p1.X = this.shapes[position].p1.X + offSetX;
                this.shapes[position].p1.Y = this.shapes[position].p1.Y + offSetY;
                this.shapes[position].p2.X = this.shapes[position].p2.X + offSetX;
                this.shapes[position].p2.Y = this.shapes[position].p2.Y + offSetY;
                this.plMain.Refresh();
            }
        }


        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            if (this.isStart || this.zooming )
            {
                for (int i = 0; i < this.shapes.Count; i++)
                {
                    this.shapes[i].zoom = this.zoom;
                    this.shapes[i].Draw();
                }

            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if(drag == false && this.ButtonState != (int)ButtonClick.Null)
            {
                this.shapes[this.shapes.Count - 1].p2 =
           e.Location;//Update second endpoint
            this.plMain.Refresh();
            }
            

            if (ButtonState == (int)ButtonClick.Polygon || ButtonState == (int)ButtonClick.FilledPolygon)
            {
                this.existedPolygon = false;
            }

            this.isStart = false;
            this.ButtonState = (int) ButtonClick.Null;
            this.drag = false;
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

        private void buttonFilledPolygon_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int) ButtonClick.FilledPolygon;
            this.existedPolygon = true;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Circle;
           
        }

        private void buttonFilledCircle_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.FilledCircle;
          
        }

        private void buttonArc_Click(object sender, EventArgs e)
        {
            this.ButtonState = (int)ButtonClick.Arc;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (clickedShape.Count == 0)
                return;
            foreach (var item in clickedShape)
            {
                this.shapes.Remove(item);
            }
            plMain.Refresh();
        }

        private void comboBoxDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDashStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxDashStyle.SelectedItem.ToString())
            {
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    dashStyle = DashStyle.DashDotDot;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
            }
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxColor_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxColor_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxColor.SelectedItem.ToString())
            {
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Red":
                    color = Color.Red;
                    break;
                case "Yellow":
                    color = Color.Yellow;
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.zoom = trackBar1.Value;
          
            this.zooming = true;
            this.plMain.Refresh();
        }
    }
}
