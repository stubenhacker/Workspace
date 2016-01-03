using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optionen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                lblAnzeigen1.Text = "Blau";
            }
            else if (rbGreen.Checked)
            {
                lblAnzeigen1.Text = "Grün";
            }
            else
            {
                lblAnzeigen1.Text = "Rot";
            }
        }

        private void cmdRedRb_Click(object sender, EventArgs e)
        {
            rbRed.Checked = true;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbColorChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                lblAnzeigen2.Text = "Blau";
            }
            else if (rbGreen.Checked)
            {
                lblAnzeigen2.Text = "Grün";
            }
            else
            {
                lblAnzeigen2.Text = "Rot";
            }
        }
    }
}
