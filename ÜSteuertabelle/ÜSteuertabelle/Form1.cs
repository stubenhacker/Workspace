using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜSteuertabelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            int steuersatz, steuerbetrag, gehaltOhneSteuer;


            for (int i = 5000; i <= 35000; i = i + 3000)
            {
                // Steuersatz ermitteln

                if (i <= 12000)
                {
                    steuersatz = 12;   
                }
                else if (i <= 20000)
                {
                    steuersatz = 15;
                }
                else if (i <= 30000)
                {
                    steuersatz = 20;
                }
                else
                {
                    steuersatz = 25;
                }
                steuerbetrag = i * steuersatz / 100;
                gehaltOhneSteuer = i - steuerbetrag;
                lblAnzeigen.Text += i + " €, " + steuersatz + " %, " + steuerbetrag + " €, " + gehaltOhneSteuer + " €" + "\n";
            }
        }
    }
}
