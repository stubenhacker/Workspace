using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜDatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdCalcMin_Click(object sender, EventArgs e)
        {
            /* Anzeige und ListBox bereinigen */
            lblAnzeige.Text = "";
            lstFeld.Items.Clear();

            /* eindimensionales Feld initialisieren */
            int[] a = new int[10];
            int[] b;


            /* Feld a fuellen mit 10 Werten, Zufallzahlen im Bereich 20-40 */
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 41);
                lstFeld.Items.Add(a[i]);
            }
            // Variable für minimalen Wert des Feldes, hier erster Wert aus Feld, Index 0
            // dient als Vergleichswert für die anderen Werte
            int minWert = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minWert)
                {
                    minWert = a[i];
                }
            }

            lblAnzeige.Text += "MinWert: " + minWert + "\n";

            // Klonen des Feldes a nach b
            // weitere Prüfung erfolgt mit Feld b
            // Zeigt die Position, den Index, aller Vorkommen des minWertes an
            b = (int[])a.Clone();

            for (int j = 0; j < b.Length; j++)
            {
                if (b[j] == minWert)
                {
                    lblAnzeige.Text += " an Position: " + j + "\n";
                }
            }
        }
    }
}
