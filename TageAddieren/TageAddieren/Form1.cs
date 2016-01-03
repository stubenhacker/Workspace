using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TageAddieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdWorkingDays_Click(object sender, EventArgs e)
        {
            DateTime startDatum = dtpStartDatum.Value;
            int anzahlTage = (int)numInputDays.Value;


            for (int i = 0; i < anzahlTage; i++)
            {
                if (startDatum.DayOfWeek + 1 == DayOfWeek.Saturday || startDatum.DayOfWeek + 2 == DayOfWeek.Sunday)
                {
                    startDatum = startDatum.AddDays(3);
                }
                else
                {
                    startDatum = startDatum.AddDays(1);
                }
            }

            lblAnzeigen.Text = startDatum.DayOfWeek + ", " + startDatum.ToShortDateString();
        }
    }
}
