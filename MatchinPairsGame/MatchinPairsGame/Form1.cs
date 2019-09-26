/*  Tray Harris
 *  Reno Technology Academy
 *  CIS109: Coding in C# Imbedded Systems
 *  Udemy: 17 Beginner C# Walkthrough Projects Step By Step
 *  Project 1: Create a Matching Pairs icon Image Game
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchinPairsGame
{
    public partial class FormMPG : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", "b", "b", "w", "w",
             "z", "z", "k", "k", "v", "v", ",", ","
        };

        Label firstClicked, secondClicked;

        public FormMPG()
        {
            InitializeComponent();
            AssignIconsToSquare();
        }

        private void AssignIconsToSquare()
        {
            //foreach (Control control in tableLayoutPanel1.Controls)
            //{
            //    Label iconLabel = control as Label;
            //    if (iconLabel != null)
            //    {
            //        int randomNumber = random.Next(icons.Count);
            //        iconLabel.Text = icons[randomNumber];
            //        iconLabel.ForeColor = iconLabel.BackColor;
            //        icons.RemoveAt(randomNumber);
            //    }
            //}

            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }

                randomNumber = random.Next(icons.Count);
                label.Text = icons[randomNumber];
                label.ForeColor = label.BackColor;
                icons.RemoveAt(randomNumber);

            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
            {
                return;
            }

            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }
        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
            }

                MessageBox.Show("You matched all the icons.");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
