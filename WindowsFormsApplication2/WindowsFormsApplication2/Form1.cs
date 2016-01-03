using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double ausdruck1 = 3 * -2.5 + 4 * 2;
            lblAnzeigen.Text = "3 * -2.5 + 4 * 2 = " + ausdruck1;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double ausdruck2 = 3 * (-2.5 + 4) * 2;
            lblAnzeigen.Text = "3 * (-2.5 + 4) * 2 = " + ausdruck2;
        }
    }
}
