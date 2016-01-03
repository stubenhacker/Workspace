using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteOptional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7, d = 9;
            lblAnzeigen.Text = "Ergebnis: " + Addiere(a, b, c, d);
        }

        private double Addiere(double x, int y, double z=0, int q=0)
        {
            return x + y + z + q;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7;
            lblAnzeigen.Text = "Ergebnis: " + Addiere(a, b, c);
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double a = 4.5;
            int b = 7;
            lblAnzeigen.Text = "Ergebnis: " + Addiere(a, b);
        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2, c = 10.3, d = 9.2;
            lblAnzeigen.Text = "Ergebnis: " + Mittelwerte(a, b, c, d);
        }

        private double Mittelwerte(params double[] x)
        {
            double summe = 0;
            if (x.Length == 0)
            {
                return 0;
            }
            foreach (double z in x)
            {
                summe += z;
            }
            return summe / x.Length;
        }
    }
}
