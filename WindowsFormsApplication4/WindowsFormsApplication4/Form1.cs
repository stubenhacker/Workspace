using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            bool ausdruck1 = 4 > 3 && -4 > -3;
            lblAnzeigen.Text = "4 > 3 && -4 > -3 " + ausdruck1;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            bool ausdruck2 = 4 > 3 || -4 > -3;
            lblAnzeigen.Text = "4 > 3 || -4 > - 3 " + ausdruck2;
        }
    }
}
