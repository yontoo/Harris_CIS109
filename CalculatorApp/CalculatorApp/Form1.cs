﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Clear();
            }
            Button btn = (Button)sender;
            resultBox.Text = resultBox.Text + btn.Text;
        }
    }
}
