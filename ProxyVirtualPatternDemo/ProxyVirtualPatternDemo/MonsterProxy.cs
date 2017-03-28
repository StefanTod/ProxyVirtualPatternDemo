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
    class MonsterProxy : IMonster
    {
        private Point MoveToPoint;
        private Graphics gForm;
        private Point tempCoords;
        private Timer timer;
        private IMonster monster;

        public MonsterProxy(Graphics g, Point coordinates,IMonster monster)
        {
            this.monster = monster;
            gForm = g;
            MoveToPoint = coordinates;
            tempCoords = coordinates;
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new Timer(5000)
            {
                Enabled = true
            };
            timer.Elapsed += OnElapseShape;
            timer.Start();
        }

        private void OnElapseShape(object sender, ElapsedEventArgs e)
        {
            timer.Enabled = false;
            monster.Move(MoveToPoint);
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
                monster.Move(p);   
            }
        }

        private void DrawShadow(Brush color, Point coordinates, int width, int height,IMonster monster)
        {
            switch (monster.GetType().ToString())
            {
                case "ProxyVirtualPatternDemo.Wolf":
                    gForm.FillEllipse(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
                    break;
                case "ProxyVirtualPatternDemo.MagicFrog":
                    gForm.FillRectangle(color, coordinates.X - (width / 2), coordinates.Y - (height / 2), width, height);
                    break;
            }
        }

        public void Draw()
        {
            if (timer.Enabled == true)
            {
                DrawShadow(Brushes.Gray, MoveToPoint, Wolf.width / 3, Wolf.height / 3, monster);
                DrawShadow(Brushes.Gray, tempCoords, Wolf.width / 2, Wolf.height / 2, monster);
            }
            else
                monster.Draw();
        }
    }
}
 