using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnabledVisible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput1.Text != "" && txtInput2.Text != "")
            {
                cmdRechnen1.Enabled = true;
                cmdRechnen2.Visible = true;
            }
            else
            {
                cmdRechnen1.Enabled = false;
                cmdRechnen2.Visible = false;
            }
        }

        private void cmdCalc_Click(Object sender, EventArgs e)
        {
            try
            {
                lblAnzeigen.Text = "Ergebnis: " + (Convert.ToInt32(txtInput1.Text) + Convert.ToInt32(txtInput2.Text));
            }
            catch (Exception ex)
            {

                lblAnzeigen.Text = "Fehler: " + ex.Message;
            }
        }
    }
}
