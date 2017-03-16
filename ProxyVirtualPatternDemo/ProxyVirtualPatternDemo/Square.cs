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
    class Square : Shape
    {
        private Point MoveToPoint;
        private Circle circle;

        public Square()
        {
            Timer timer = new Timer(5000);
            timer.Elapsed += OnElapseCircle;
            timer.Close();
        }

        private void OnElapseCircle(object sender, ElapsedEventArgs e)
        {
            circle = new Circle();
            if (MoveToPoint != null)
            {
                circle.move(MoveToPoint);
            }
            
        }


        public void move(Point p)
        {
            if (circle != null)
            {
                circle.move(MoveToPoint);
            }
            else
            {
                MoveToPoint = new Point(MoveToPoint.X,MoveToPoint.Y);
            }
        }
    }
}
