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
        private Point coordinates;

        public Circle(Graphics g)
        {
            gForm = g;
        }

        public void Move(Point point)
        {
            coordinates = point;
        }

        public void Draw()
        {
            gForm.FillEllipse(Brushes.Green, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
        }
    }
}
