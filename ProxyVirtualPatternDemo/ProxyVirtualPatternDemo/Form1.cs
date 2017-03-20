﻿using System;
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
        CircleProxy cp;

        private void btn_transform_Click(object sender, EventArgs e)
        {
            cp = new CircleProxy(this.CreateGraphics(), coords);
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
            if (cp != null)
            {
                cp.Move(coords);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (cp != null)
            {
                cp.Draw();
            }
        }

        private void UpdateText()
        {
            this.lb_coordinates.Text = string.Format("Coordinates are x: {0}, y: {1}", coords.X, coords.Y);
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
