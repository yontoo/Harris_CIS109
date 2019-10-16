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
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\media\Speech Sleep.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Win");
            Close();
        }

        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

    }
}
