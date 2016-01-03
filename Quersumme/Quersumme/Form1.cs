using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quersumme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSumme1_Click(object sender, EventArgs e)
        {
            try
            {
                int eingabe = Convert.ToInt32(txtInputZahl.Text);

                lblAnzeige.Text = "Quersumme von " + eingabe + " ist: " + Quersumme(eingabe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);                    
            }

            
        }

        public int Quersumme(int zahl)
        {
            int summe = 0;
            while (zahl != 0)
            {
                summe = summe +(zahl % 10);
                zahl = zahl / 10;
            }
            return summe;
        }

        public String removeDuplicates(String word)
        {
            if (word == null || word.Length <= 1)
                return word;
            else if (word[0] == word[1])
                return removeDuplicates(word.Substring(1, word.Length - 1));
            else
                return word[0] + removeDuplicates(word.Substring(1, word.Length - 1));
        }

        private void cmdRemoveDuplicates_Click(object sender, EventArgs e)
        {
            string eingabe = txtInputString.Text;
            string ausgabe = "";
            ausgabe = removeDuplicates(eingabe);
            lblAnzeige.Text = ausgabe;
        }
    }
}
