using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVirtualPatternDemo
{
    class MagicFrog : IMonster , IVisitable
    {
        public static int width = 50, height = 50;
        private Graphics gForm;
        private Point position;
        private Point moveTo;
        private int health, maxHealth, armor, magicResistance;
        private Races race;

        public MagicFrog(Graphics g, Point position)
        {
            gForm = g;
            this.position = position;
            Health = 100;
            Armor = 10;
            MagicResistance = 20;
            Race = Races.Magic;
        }

        public MagicFrog()
        {
            Health = 100;
            MaxHealth = 100;
            Armor = 10;
            MagicResistance = 20;
            Race = Races.Magic;
        }

        public int Health {
            get { return health; }
            set
            {
                if (value > 0)
                {
                    health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }
        public int MaxHealth { get; }
        public int Armor { get; }
        public int MagicResistance { get; }
        public Races Race { get; }

        public void Draw()
        {
            if (moveTo != null)
            {
                gForm.DrawLine(new Pen(Brushes.Gray), position, moveTo);
                int shWidth = width / 3, shHeight = height / 3;
                gForm.FillRectangle(Brushes.Gray, moveTo.X - (shWidth / 2), moveTo.Y - (shHeight / 2), shWidth, shHeight);
            }
            gForm.FillRectangle(Brushes.Yellow, position.X - (width / 2), position.Y - (height / 2), width, height);
        }

        public void Move(Point point)
        {
            if (point.X >= 0)
                moveTo = point;
            if (moveTo != null)
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

        public void acceptAttack(IVisitor visitor)
        {
            visitor.attacks(this);
        }
    }
}
