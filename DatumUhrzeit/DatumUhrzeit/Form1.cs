using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumUhrzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(2015, 7, 18, 16, 35, 12);
            DateTime d2 = new DateTime(2015, 8, 23);
            DateTime d3, d4 = new DateTime();

            lstAnzeigen.Items.Add("d1: " + d1);
            lstAnzeigen.Items.Add("d2: " + d2.ToShortDateString());
            d3 = DateTime.Now;
            d4 = DateTime.Today;
            lstAnzeigen.Items.Add("d3: " + d3);
            lstAnzeigen.Items.Add("d4: " + d4.ToShortDateString());

            lstAnzeigen.Items.Add("Tag der Woche: " + d1.DayOfWeek);
            if (d1.DayOfWeek == DayOfWeek.Sunday)
            {
                lstAnzeigen.Items.Add("Sonntag");
            }
            else
            {
                lstAnzeigen.Items.Add("Kein Sonntag");
            }

            lstAnzeigen.Items.Add("Tag des Jahres: " + d1.DayOfYear);
            lstAnzeigen.Items.Add("Datum: " + d1.Date);
            lstAnzeigen.Items.Add("Uhrzeit: " + d1.TimeOfDay);
        }
    }
}
