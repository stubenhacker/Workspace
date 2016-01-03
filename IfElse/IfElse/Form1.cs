using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdIf_Click(object sender, EventArgs e)
        {
            int x = (int) numX.Value;
            lblAnzeigen.Text = "";
            
            if(x > 0)
            {
                lblAnzeigen.Text = "x ist größer als 0";
                numX.BackColor = Color.LightGreen;
            }
        }

        private void cmdIfElse_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;

            if (x > 0)
            {
                lblAnzeigen.Text = "x ist größer als 0";
                numX.BackColor = Color.LightGreen;
            }
            else
            {
                lblAnzeigen.Text = "x ist kleiner als 0 oder gleich 0";
                numX.BackColor = Color.LightBlue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;

            lblAnzeigen.Text = x > 0 ? "x > 0" : "x <= 0";
            numX.BackColor = x > 0 ? Color.LightGreen : Color.LightBlue;
        }

        private void cmdIfElseIf_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;

            if (x > 0)
            {
                lblAnzeigen.Text = "x ist größer als 0";
            }
            else
            {
                numX.BackColor = Color.LightBlue;

                if (x < 0)
                {
                    lblAnzeigen.Text = "x ist kleiner als 0";
                }
                else
                {
                    lblAnzeigen.Text = "x ist gleich 0";
                }
            }
        }

        private void cmdLogUnd_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            int y = (int)numY.Value;

            numX.BackColor = Color.White;

            if(x > 0 && y > 0)
            {
                lblAnzeigen.Text = "x und y sind größer als 0";
            }
            else
            {
                lblAnzeigen.Text = "Mind. eine der beiden Zahlen ist nicht größer als 0";
            }
        }

        private void cmdLogOder_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            int y = (int)numY.Value;

            numX.BackColor = Color.White;

            if(x>0 || y > 0)
            {
                lblAnzeigen.Text = "x oder y oder beide sind größer als 0";
            }
            else
            {
                lblAnzeigen.Text = "Keine der Zahlen ist größer als 0";
            }
      
        }

        private void cmdLogExklOder_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            int y = (int)numY.Value;
            numX.BackColor = Color.White;
            lblAnzeigen.Text = "";

            if(x > 0 ^ y > 0)
            {
                lblAnzeigen.Text = "Nur x oder nur y ist größer als 0";
            }
        }
    }
}
