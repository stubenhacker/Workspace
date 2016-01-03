using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodenÜbergabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;
            lblAnzeigen.Text = "Vorher: x: " + x + ", y: " + y;
            TauscheKopie(x, y);
            lblAnzeigen.Text += "\nNachher: x: " + x + ", y: " + y;
        }

        // Tausch der übergebenen Parameter a, b hat keine Auswirkungen nach außen. 
        // Der Tausch findet nur intern/innerhalb der TauscheKopie-Methode statt.
        // Das Original bleibt unangetastet.
        private void TauscheKopie(int a, int b)
        {
            //Hilfsvariable zum Tauschen: Ringtausch
            int c;
            c = a;
            a = b;
            b = c;
        }


        private void cmdReference_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;
            lblAnzeigen.Text = "Vorher x: " + x + ", y: " + y;
            tauscheReferenz(ref x, ref y);
            lblAnzeigen.Text += "\nNachher x: " + x + ", y: " + y;
        }

        private void tauscheReferenz(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        private void cmdEinDimFeld_Click(object sender, EventArgs e)
        {
            int[] a = { 6, 7, 2 };
            Verdoppeln(a);
            for (int i = 0; i < a.Length; i++)
            {
                lblAnzeigen.Text += "Wert verdoppelt: " + a[i] + "\n";
            }
        }

        private void Verdoppeln(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * 2;
            }
        }

        private void cmdDreiDimFeld_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double[,,] x = new double[2, 5, 3];
            for (int i = 0; i <= x.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= x.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= x.GetUpperBound(2); k++)
                    {
                        x[i, j, k] = r.NextDouble();
                    }
                }
            }
            Mittelwert(x);

        }

        private void Mittelwert(double[,,] z)
        {
            double summe = 0;
            for (int i = 0; i <= z.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= z.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= z.GetUpperBound(2); k++)
                    {
                        summe += z[i, j, k];
                    }
                }
            }
            lblAnzeigen.Text = "Mittelwert: " + summe / z.Length;
        }

        private void cmdOut_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 3;
            Addieren(a, b, out c);
            lblAnzeigen.Text = "Ergebnis: " + c;
        }

        private void Addieren(int x, int y, out int z)
        {
            z = x + y;
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 17;
            c = MaxWert(a, b);
            lblAnzeigen.Text = "Maximum: " + c;
        }

        private int MaxWert(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
