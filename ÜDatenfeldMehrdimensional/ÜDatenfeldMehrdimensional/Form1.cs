using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜDatenfeldMehrdimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            int[,,] a;
            a = new int[6, 3, 4];
            int minWert;

            lblAnzeigen.Text = "";
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    lblAnzeigen.Text += " ( ";
                    for (int k = 0; k <= a.GetUpperBound(2); k++)
                    {
                        a[i, j, k] = r.Next(20, 31);
                        lblAnzeigen.Text += a[i, j, k] + " ";
                    }
                    lblAnzeigen.Text += " )";
                }
                lblAnzeigen.Text += "\n";
            }

            minWert = a[0, 0, 0];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= a.GetUpperBound(2); k++)
                    {
                        if (a[i,j,k] < minWert)
                        {
                            minWert = a[i, j, k];
                        }
                    }
                }
            }

            lblAnzeigen2.Text = "MinWert: " + minWert + " auf Position: " + "\n";

            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= a.GetUpperBound(2); k++)
                    {
                        if (a[i,j,k] == minWert)
                        {
                            //Zeile, Gruppe, Element [i,j,k]
                            lblAnzeigen2.Text += "Zeile: " + i + " Gruppe: " + j + " Element: " + k + "\n";
                        }
                    }
                }
            }


                 
        }
    }
}
