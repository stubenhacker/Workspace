using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laufzeitfehler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRechnen_Click(object sender, EventArgs e)
        {
            try
            {
                int zahl1 = Convert.ToInt32(txtInputZahl1.Text);
                int zahl2 = Convert.ToInt32(txtInputZahl2.Text);
                int ergebnis = zahl1 / zahl2;
                lblErgebnis.Text += " " + ergebnis;
            }
            catch (FormatException ex)
            {
                lblErgebnis.Text += "Fehler: falsches Eingabeformat! " + ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                lblErgebnis.Text += "Fehler: Sie können nicht durch die Zahl 0 dividieren!";
            }
            catch (Exception ex)
            {
                lblErgebnis.Text += "Fehler: allgemeiner Fehler!";
            }
        }
    }
}
