using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 10;
            bool ausdruck1 = a > 0 && b != 10;
            lblAnzeigen.Text = "a > 0 && b != 10 = " + ausdruck1;

        }


        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 10;
            bool ausdruck2 = a > 0 || b != 10;
            lblAnzeigen.Text = "a > 0 || b != 10 = " + ausdruck2;
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int z = 10;
            int w = 100;
            bool ausdruck3 = z != 0 || z > w || w - z == 90;
            lblAnzeigen.Text = "z != 0 || z > w || w - z == 90 = " + ausdruck3;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int z = 10;
            int w = 100;
            bool ausdruck4 = z == 11 && z > w || w - z == 90;
            lblAnzeigen.Text = "z == 11 && z > w || w - z == 90 = " + ausdruck4;
        }

        private void cmdAnzeigen5_Click(object sender, EventArgs e)
        {
            double x = 1.0;
            double y = 5.7;
            bool ausdruck5 = x >= 0.9 && y <= 5.8;
            lblAnzeigen.Text = "x >= 0.9 && y <= 5.8 = " + ausdruck5;
        }

        private void cmdAnzeigen6_Click(object sender, EventArgs e)
        {
            double x = 1.0;
            double y = 5.7;
            bool ausdruck6 = x >= 0.9 && !(y <= 5.8);
            lblAnzeigen.Text = "x >= 0.9 && !(y <= 5.8) = " + ausdruck6;
        }

        private void cmdAnzeigen7_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            int n2 = 17;
            bool ausdruck7 = n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17;
            lblAnzeigen.Text = "n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17 = " + ausdruck7;
        }

        private void cmdAnzeigen8_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            int n2 = 17;
            bool ausdruck8 = n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17;
            bool ausdruck9 = true && true && false;
            lblAnzeigen.Text = "n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17 = " + ausdruck9;
        }
    }
}
