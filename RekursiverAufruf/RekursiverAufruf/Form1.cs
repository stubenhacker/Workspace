using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekursiverAufruf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchleife_Click(object sender, EventArgs e)
        {
            double a = 22;
            lblAnzeigen.Text = "Wert: " + a + "\n";
            while (a > 0.1)
            {
                a = a / 2;
                lblAnzeigen.Text += "Wert: " + a + "\n";
            }
        }

        private void cmdRekursion_Click(object sender, EventArgs e)
        {
            double a = 22;
            lblAnzeigen.Text = "Wert: " + a + "\n";
            Halbieren(ref a);
            lblAnzeigen.Text += "Wert: " + a;
        }

        private void Halbieren(ref double x)
        {
            x = x / 2;
            if (x>0.1)
            {
                lblAnzeigen.Text += "Wert: " + x + "\n";
                Halbieren(ref x);
            }    
        }

        private void cmdRekursion2_Click(object sender, EventArgs e)
        {
            string a = "Hallo";

            
        }
    }
}
