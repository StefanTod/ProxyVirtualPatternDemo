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
    class CircleProxy : IShape
    {
        private Point MoveToPoint;
        private Circle circle;
        private Graphics gForm;
        private Point tempCoords;
        private Timer timer;

        public CircleProxy(Graphics g, Point coordinates)
        {
            gForm = g;
            MoveToPoint = coordinates;
            tempCoords = coordinates;
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new Timer(5000);
            timer.Enabled = true;
            timer.Elapsed += OnElapseCircle;
            timer.Start();
        }

        private void OnElapseCircle(object sender, ElapsedEventArgs e)
        {
            timer.Enabled = false;
            circle = new Circle(gForm);
            circle.Move(MoveToPoint);
        }

        public void Move(Point p)
        {
            if (circle == null)
            {
                MoveToPoint = p;
            }
            else
            {
                circle.Move(p);   
            }
        }

        private void DrawCircle(Brush color, Point coordinates, int width, int height)
        {
            gForm.FillEllipse(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
        }

        public void Draw()
        {
            if (circle == null)
            {
                DrawCircle(Brushes.Gray, MoveToPoint, Circle.width / 3, Circle.height / 3);
                DrawCircle(Brushes.Gray, tempCoords, Circle.width / 2, Circle.height / 2);
            }
            else
                circle.Draw();
        }

    }
}
 