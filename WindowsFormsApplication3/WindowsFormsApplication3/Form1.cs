using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            bool ausdruck1 = 12 - 3 >= 4 * 2.5;
            lblAnzeige.Text = "12 - 3 >= 4 * 2.5 = " + ausdruck1;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            bool ausruck2 = "Meier" != "Mayer";
            lblAnzeige.Text = "Meier != Mayer = " + ausruck2; 
        }
    }
}
