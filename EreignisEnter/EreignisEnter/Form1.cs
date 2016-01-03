using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EreignisEnter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstVersand.Items.Add("DHL");
            lstVersand.Items.Add("Hermes");
            lstVersand.Items.Add("UPS");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblHilfe.Text = "";
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            lblHilfe.Text = "Bitte geben Sie Nachname, Vorname ein.";
        }

        private void chkKunde_Enter(object sender, EventArgs e)
        {
            lblHilfe.Text = "Bitte kreuzen Sie an, ob Sie bereits Kunde sind.";
        }

        private void lstVersand_Enter(object sender, EventArgs e)
        {
            lblHilfe.Text = "Wählen Sie den Paketdienst aus.";
        }

        private void grpZahlungsmethode_CheckedChanged(object sender, EventArgs e)
        {
            lblHilfe.Text = "Wählen Sie die Zahlungsform aus.";
        }
    }
}
