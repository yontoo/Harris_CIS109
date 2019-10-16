using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Win");
            Close();
        }

        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }
    }
}
