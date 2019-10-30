using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void CboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(CboLocation.Text);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(CboLocation.Text);
        }
    }
}
