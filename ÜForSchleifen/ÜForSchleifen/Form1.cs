using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜForSchleifen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchleife1_Click(object sender, EventArgs e)
        {
            for (double d = 35; d >= 20; d = d - 2.5)
            {
                lblAnzeigeSchleife.Text += d + "\n";
            }
        }

        private void cmdSchleife2_Click(object sender, EventArgs e)
        {
            double summe = 0;
            double mittelwert = 0;
            int counter = 0;
            for (double d = 35; d >= 20; d = d - 2.5)
            {
                lblAnzeigeSchleife.Text += d + "\n";
                summe += d;
                counter++;
            }
            mittelwert = summe / counter;
            lblAnzeigeSchleife.Text += "Summe: " + summe + "\n";
            lblAnzeigeSchleife.Text += "Mittelwert: " + mittelwert + "\n";


        }

        private void cmdSchleifen3_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(txtInput.Text);

            if (inputValue > 0.001)
            {
               
                while (inputValue > 0.001)
                {
                    inputValue = inputValue / 2;
                    lblAnzeigeSchleife.Text += inputValue + "\n";
                }
            }
        }
    }
}
