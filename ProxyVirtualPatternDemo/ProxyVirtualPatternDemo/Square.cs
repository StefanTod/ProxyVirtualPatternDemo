using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyVirtualPatternDemo
{
    class Square : Shape
    {
        private Point MoveToPoint;
        private Circle circle;

        public Square()
        {
            Timer timer = new Timer(new TimerCallback(TimeProc));
            timer.Change(5000,)
        }

        public void move(Point p)
        {
            
        }

        public void TimeProc(object state)
        {
            Timer t = (Timer) state;
            t.


        }
    }
}
