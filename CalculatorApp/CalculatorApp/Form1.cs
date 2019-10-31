using System;
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
        Double resultValue = 0;
        string operatorClicked = "";

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

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operatorClicked = btn.Text;
            resultValue = Double.Parse(resultBox.Text);

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultValue = 0;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            switch(operatorClicked)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                    break;

                case "-":
                    resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                    break;

                case "×":
                    resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                    break;

                case "÷":
                    resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                    break;

                default:
                    break;

            }
        }
    }
}
