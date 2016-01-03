using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜSteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalc_Click(object sender, EventArgs e)
        {
            double gehalt, steuerbetrag, steuersatz;
            gehalt = Convert.ToDouble(txtInput.Text);
            lblAnzeigen.Text = " ";

            if (gehalt <= 12000)
            {
                // 12%
                steuersatz = 12;
            }
            else if(gehalt <= 20000){
                // 15%
                steuersatz = 15;
            }
            else if (gehalt <= 30000)
            {
                // 20%
                steuersatz = 20;
            }
            else
            {
                steuersatz = 30;
            }

            steuerbetrag = gehalt * steuersatz / 100;
            lblAnzeigen.Text = "Steuerbetrag: " + steuerbetrag;


        }
    }
}
