using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyVirtualPatternDemo
{
    public partial class Form1 : Form
    {
        private Point coords = new Point(50, 50);
        private IShape shape;
        private IShape wantedShape;

        private void createShape_Click(object sender, EventArgs e)
        {
            switch (choose_shape.SelectedItem.ToString())
            {
                case "Circle":
                    wantedShape = new Circle(this.CreateGraphics(), coords);
                    break;
                case "Square":
                    wantedShape = new Square(this.CreateGraphics(), coords);
                    break;
            }
            shape = new ShapeProxy(this.CreateGraphics(), coords, wantedShape);
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            UpdateText();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            coords = this.PointToClient(Cursor.Position);
            UpdateText();
            if (shape != null)
            {
                shape.Move(coords);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.Draw();
            }
        }

        private void UpdateText()
        {
            this.lb_coordinates.Text = string.Format("Coordinates are x: {0}, y: {1}", coords.X, coords.Y);
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            if (shape != null)
            {
                Point point = new Point(-10, -10);
                shape.Move(point);
            }
            Invalidate();
        }

        private void choose_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
