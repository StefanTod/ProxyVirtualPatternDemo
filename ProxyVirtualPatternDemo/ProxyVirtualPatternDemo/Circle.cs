using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ProxyVirtualPatternDemo
{
    class Circle : IShape
    {
        public static int width = 50, height = 50;
        private Graphics gForm;
        private Point position;
        private Point moveTo;

        public Circle(Graphics g, Point position)
        {
            gForm = g;
            this.position = position;

        }

        public void Move(Point point)
        {
            if(point.X >= 0)
                moveTo = point;
            if(moveTo != null)
            {
                if (position.X != moveTo.X)
                {
                    if (position.X > moveTo.X)
                    {
                        position.X--;
                    }
                    else
                        position.X++;
                }
                if (position.Y != moveTo.Y)
                {
                    if (position.Y > moveTo.Y)
                    {
                        position.Y--;
                    }
                    else
                        position.Y++;
                }
            }
        }

        public void Draw()
        {
            if (moveTo != null)
            {
                gForm.DrawLine(new Pen(Brushes.Gray), position, moveTo);
                int shWidth = width / 3, shHeight = height / 3;
                gForm.FillEllipse(Brushes.Gray, moveTo.X - (shWidth / 2), moveTo.Y - (shHeight / 2), shWidth, shHeight);
            }
            gForm.FillEllipse(Brushes.Green, position.X - (width / 2), position.Y - (height / 2), width, height);
        }
    }
}
