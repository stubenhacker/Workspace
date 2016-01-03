using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int zahlZufall;

        private void cmdCreateRandom_Click(object sender, EventArgs e)
        {
            zahlZufall = r.Next(1, 101);
            lblRandom.Text += "" + zahlZufall;
        }

        private void cmdCheckNumber_Click(object sender, EventArgs e)
        {
            int zahlEingabe = Convert.ToInt32(txtInput.Text);
            

            bool zahlGefunden = false;

            while (!zahlGefunden)
            {

                if(zahlEingabe > zahlZufall)
                {
                    lblAnzeigen.Text = "Die Zahl " + zahlEingabe + " ist zu groß.";
                    break;
                }
                else if (zahlEingabe < zahlZufall)
                {
                    lblAnzeigen.Text = "Die Zahl " + zahlEingabe + " ist zu klein.";
                    break;
                }
                else
                {
                    lblAnzeigen.Text = "Die Zahl " + zahlEingabe + " ist korrekt.";
                    // gefunden
                    zahlGefunden = true;
                    
                }
            }
        }
    }
}
