using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openBrowseFile.ShowDialog() == DialogResult.OK)
            {
                FilePathBox.Text = openBrowseFile.FileName;

            }
            Player.URL = FilePathBox.Text;

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
