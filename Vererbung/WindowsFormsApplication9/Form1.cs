using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            PKW fiat = new PKW();

            vespa.beschleunigen(35);
            lblAnzeigen.Text = vespa.ausgabe();

            lblAnzeigen.Text += "\n" + fiat.ausgabe();
            fiat.einsteigen(3);
            fiat.beschleunigen(30);
            lblAnzeigen.Text += "\n" + fiat.ausgabe();
        }
    }
}
