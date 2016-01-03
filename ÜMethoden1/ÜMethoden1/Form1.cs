using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜMethoden1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int mittelwert; ;
            int[] a = { 5, 5, 5, 5, 5, 5, 5 };
            int[] b = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            mittelwert = BerechneMittelwert(a);
            lblAnzeigen1.Text = "Mittelwert: " + mittelwert;


        }

        private int BerechneMittelwert(int[] a)
        {
            int summe = 0;
            for (int i = 0; i < a.Length; i++)
            {
                summe += a[i];
            }
            return summe / a.Length;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double[] a = { 3.4, 3.5, 1.2, 5.6, 6.8, 9.2 };
            double[] b = { 2.2, 5.7, 4.4, 7.4, 3.4 };
            double[] c;
            lblAnzeigen1.Text = "Länge von a[]: " + a.Length + ", Länge von b[]: " + b.Length;
            Vereinigen(a, b, out c);
            lblAnzeigen1.Text = "Länge von a[]: " + a.Length + ", Länge von b[]: " + b.Length + ", Länge von c[]: " + c.Length + "\n";

            foreach (double item in c)
            {
                lblAnzeigen1.Text += item + "\n";
            }
        }

        private void Vereinigen(double[] a, double[] b, out double[] c)
        {
            c = new double[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int j = 0; j < b.Length; j++)
            {
                c[j + a.Length] = b[j];

            }

        }
    }
}
