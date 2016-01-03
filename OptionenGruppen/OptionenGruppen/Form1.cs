using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionenGruppen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string AusgabeUrlaubsort = "Berlin";
        private string AusgabeUnterkunft = "Pension";

        private void grpUrlaubsort_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBerlin.Checked)
            {
                AusgabeUrlaubsort = rbBerlin.Text;
            }
            else if (rbParis.Checked)
            {
                AusgabeUrlaubsort = rbParis.Text;
            }
            else
            {
                AusgabeUrlaubsort = rbRom.Text;
            }

            Anzeigen();
            //lblAnzeigen.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }

        private void grpUnterkunft_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAppartment.Checked)
            {
                AusgabeUnterkunft = rbAppartment.Text;
            }
            else if (rbPension.Checked)
            {
                AusgabeUnterkunft = rbPension.Text;
            }
            else
            {
                AusgabeUnterkunft = rbHotel.Text;
            }

            Anzeigen();
            //lblAnzeigen.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }

        private void Anzeigen()
        {
            lblAnzeigen.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Anzeigen();
        }
    }
}
