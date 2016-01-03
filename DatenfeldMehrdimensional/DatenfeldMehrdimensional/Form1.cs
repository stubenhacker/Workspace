using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldMehrdimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            int[,] a;
            // d.h. 7 Werte in 3 Spalten
            a = new int[7, 3];

            lstOrt1.Items.Clear();
            lstOrt2.Items.Clear();
            lstOrt3.Items.Clear();

            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= a.GetUpperBound(1); k++)
                {
                    a[i, k] = r.Next(20, 31);
                }
                  lstOrt1.Items.Add(a[i, 0]);
                    lstOrt2.Items.Add(a[i, 1]);
                    lstOrt3.Items.Add(a[i, 2]);
            }
        }

        private void lstOrtListe_Click(object sender, EventArgs e)
        {
            int x;
            if (sender == lstOrt1)
            {
                x = 0;
            }
            else if (sender == lstOrt2)
            {
                x = 1;
            }
            else
            {
                x = 2;
            }

            lblAnzeigen.Text = "Indizes: " + (sender as ListBox).SelectedIndex + ", " + x;
            
        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            // Beispiele für direktes initialisieren von Datenfeldern / Arrays
            // 
            int[] a = { 0, 5, -2, 7 };

            //[2,3]
            double[,] b = { { 6.2, 2.0, -1.8 }, { 9.3, 3.6, -2.3 } };

            //[2,2,3]
            int[,,] c = { { {9,-3,2 }, {2,1,-5 } }, { {3,9,8 } , {6,3,-8 } } };

            lblAnzeigen2.Text = "";
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    lblAnzeigen2.Text += " ( ";
                    for (int k = 0; k <= c.GetUpperBound(2); k++)
                    {
                        lblAnzeigen2.Text += c[i, j, k] + " ";
                    }

                    lblAnzeigen2.Text += " ) ";
                }

                lblAnzeigen2.Text += "\n";
            }
        }
    }
}
