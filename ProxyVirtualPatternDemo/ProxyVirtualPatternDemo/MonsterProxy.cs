using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Timers;
using System.Xml.XPath;



namespace ProxyVirtualPatternDemo
{
    class ShapeProxy : IShape
    {
        private Point MoveToPoint;
        private Graphics gForm;
        private Point tempCoords;
        private Timer timer;
        private IShape shape;

        public ShapeProxy(Graphics g, Point coordinates,IShape shape)
        {
            this.shape = shape;
            gForm = g;
            MoveToPoint = coordinates;
            tempCoords = coordinates;
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new Timer(5000);
            timer.Enabled = true;
            timer.Elapsed += OnElapseShape;
            timer.Start();
        }

        private void OnElapseShape(object sender, ElapsedEventArgs e)
        {
            timer.Enabled = false;
            shape.Move(MoveToPoint);
        }

        public void Move(Point p)
        {
            if (timer.Enabled == true)
            {
                if(p.X >= 0)
                    MoveToPoint = p;
            }
            else
            {
                shape.Move(p);   
            }
        }

        private void DrawShadow(Brush color, Point coordinates, int width, int height,IShape shape)
        {
            switch (shape.GetType().ToString())
            {
                case "ProxyVirtualPatternDemo.Circle":
                    gForm.FillEllipse(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
                    break;
                case "ProxyVirtualPatternDemo.Square":
                    gForm.FillRectangle(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
                    break;

            }

            //if (shape is Circle)
            //{
            //    gForm.FillEllipse(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
            //}
            //else if (shape is Square)
            //{
            //    gForm.FillRectangle(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
            //}
        }

        public void Draw()
        {
            if (timer.Enabled == true)
            {
                DrawShadow(Brushes.Gray, MoveToPoint, Circle.width / 3, Circle.height / 3, shape);
                DrawShadow(Brushes.Gray, tempCoords, Circle.width / 2, Circle.height / 2, shape);
            }
            else
                shape.Draw();
        }

    }
}
 