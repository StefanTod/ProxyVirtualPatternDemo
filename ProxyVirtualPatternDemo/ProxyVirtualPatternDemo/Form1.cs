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
        private IMonster monster;
        private IMonster wantedMonster;

        private void createMonster_Click(object sender, EventArgs e)
        {
            switch (choose_shape.SelectedItem.ToString())
            {
                case "Wolf":
                    wantedMonster = new Wolf(this.CreateGraphics(), coords);
                    break;
                case "MagicFrog":
                    wantedMonster = new MagicFrog(this.CreateGraphics(), coords);
                    break;
            }
            monster = new MonsterProxy(this.CreateGraphics(), coords, wantedMonster);
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
            if (monster != null)
            {
                monster.Move(coords);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (monster != null)
            {
                monster.Draw();
            }
        }

        private void UpdateText()
        {
            this.lb_coordinates.Text = string.Format("Coordinates are x: {0}, y: {1}", coords.X, coords.Y);
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            if (monster != null)
            {
                Point point = new Point(-10, -10);
                monster.Move(point);
            }
            Invalidate();
        }

        private void choose_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
