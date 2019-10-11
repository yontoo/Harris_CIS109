using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class formScSvr : Form
    {
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic
        {
            public int PicNum;
            public float X;
            public float y;
            public float Speed;
        }

        public formScSvr()
        {
            InitializeComponent();
        }

        private void formScSvr_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
