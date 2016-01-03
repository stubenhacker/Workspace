using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrollKästchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            if (chkSchalter.Checked)
            {
                lblAnzeigenPrüfung1.Text = "An";
            }
            else
            {
                lblAnzeigenPrüfung1.Text = "Aus";
            }
        }

        private void cmdSwitchCheck_Click(object sender, EventArgs e)
        {
            chkSchalter.Checked = !chkSchalter.Checked;
        }

        private void chkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSchalter.Checked)
            {
                lblAnzeigenPrüfung2.Text = "An";
            }
            else
            {
                lblAnzeigenPrüfung2.Text = "Aus";
            }
        }
    }
}
