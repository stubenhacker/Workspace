using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfelderEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int[] a;
            a = new int[7];

            lstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                lstFeld.Items.Add(a[i]);
            }

        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] a;
            a = new int[7];

            int minWert, minIndex, maxWert, maxIndex;

            lstFeld.Items.Clear();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                lstFeld.Items.Add(a[i]);
            }

            // max / min initialisieren
            minWert = a[0];
            minIndex = 0;
            maxWert = a[0];
            maxIndex = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > maxWert)
                {
                    maxWert = a[i];
                    maxIndex = i;
                }

                if (a[i] < minWert)
                {
                    minWert = a[i];
                    minIndex = i;
                }
            }

            lblAnzeigen.Text = "max. Wert: " + maxWert + " bei Index: " + maxIndex + "\n" + "min. Wert: " + minWert + " bei Index: " + minIndex;

        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
