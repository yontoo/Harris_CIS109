using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If user clicks ok,
            // Change the PictureBox control's background to selected color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clears picture
            pictureBox1.Image = null;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            // Show the open file dialog, if user clicks ok load the picture they chose
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // if the user selects the Stretch check box
            // change the PictureBox's size mode to Stretch
            // if the user clears the box, change it to normal

            if(checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
