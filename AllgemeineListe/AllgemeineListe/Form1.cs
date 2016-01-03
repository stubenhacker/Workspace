using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllgemeineListe
{
    public partial class Form1 : Form
    {
        AllgemeineListe al;

        public Form1()
        {
            InitializeComponent();
        }

   
        private void cmdListeAnlegen_Click(object sender, EventArgs e)
        {
            al = new AllgemeineListe();
            if (al.istLeer())
            {
                lstAusgabe.Items.Add("Die Liste ist leer.");
            }
            else
            {
                //lblAnzeige.Text = "Inhalt: " + al.toString() + "\n";
            }
        }

        private void cmdAction_Click(object sender, EventArgs e)
        {
            int eingabe = Convert.ToInt32(txtInput.Text);

            if (rbFuegeEinAmAnfang.Checked)
            {
                al.fuegeEinAmAnfang(eingabe);
                ausgabe();
            }
            else if(rbFuegeEinAmEnde.Checked)
            {
                al.fuegeEinAmEnde(eingabe);
                ausgabe();    
            }
            else if (rbLoescheAmAnfang.Checked)
            {
                al.loescheAmAnfang();
                ausgabe();
            }
            else if (rbLoescheAmEnde.Checked)
            {
                al.loescheAmEnde();
                ausgabe();
            }

        }

        public void ausgabe()
        {
            if (al.istLeer())
            {
                lstAusgabe.Items.Add("Die Liste ist leer.");
            }
            else
            {
                string ausgabe = "";
                ausgabe += "Inhalt: " + al.toString() + " ";
                ausgabe += "Anzahl: " + al.getAnzahlElemente() + " ";
                ausgabe += "Erstes Element: " + al.getElementAmAnfang() + " ";
                ausgabe += "Letztes Element: " + al.getElementAmEnde() + " ";
                lstAusgabe.Items.Add(ausgabe);
            }
        }
       
    }
}
