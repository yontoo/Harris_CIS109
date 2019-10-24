using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingProgram
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                Canvas.Image = bmp;
            }
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void purpleBtn_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void limeBtn_Click(object sender, EventArgs e)
        {
            p.Color = Color.Lime;
        }
    }
}
