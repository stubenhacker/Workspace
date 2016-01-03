using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vererbung_Konstruktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            PKW fiat = new PKW("Limousine", 50, 2);
            PKW peugeot = new PKW();
            lblAnzeigen.Text = fiat.ausgabe() + "\n" + peugeot.ausgabe();
        }
    }
}
