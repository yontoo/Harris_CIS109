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
        public FormMPG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
