using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLänge_Click(object sender, EventArgs e)
        {
            string s = txtInputString.Text;
            lblAnzeige.Text = "Länge: " + s.Length;
        }

        private void cmdZeichen_Click(object sender, EventArgs e)
        {
            string s = txtInputString.Text;
            for (int i = 0; i < s.Length; i++)
            {
                lblAnzeige.Text += "Index: " + i + " Zeichen: " + s[i] + "\n";
            }
        }

        private void cmdTrim_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string s = txtInputString.Text;
            string ausgabe;
            ausgabe = s.Trim(' ', ';', '#');
            lblAnzeige.Text = "|" + ausgabe + "|";
        }

        private void cmdSplit_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe = txtInputString.Text;
            string[] teile = eingabe.Split(';');
            foreach (string s in teile)
            {
                lblAnzeige.Text += s.Trim() + "\n";
            }
        }

        private void cmdSuche1_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe = txtInputString.Text;
            string sucheZeichen = txtInputSuche.Text;

            lblAnzeige.Text = "Gefunden bei Index: ";
            lblAnzeige.Text += eingabe.IndexOf(sucheZeichen);
        }

        private void cmdSucheAlle_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe, such, ausgabe;
            int position;
            int suchstart = 0, anzahl = 0;

            eingabe = txtInputString.Text;
            such = txtInputSuche.Text;

            if (eingabe == "" || such == "")
            {
                return;
            }

            ausgabe = "Suchtext bei Zeichen: " + "\n";

            do
            {
                position = eingabe.IndexOf(such, suchstart); /* erster möglicher Treffer auf Position 0 */
                suchstart = position + 1; /* weitere Suche fortsetzen nach letzten Position, wo Übereinstimmung erfolgte */

                if (position != -1) /* gesuchte Zeichenkette gefunden*/
                {
                    ausgabe += position + "\n";
                    anzahl++;
                }

            } while (position != -1);

            ausgabe += "Anzahl: " + anzahl + "\n";
            lblAnzeige.Text = ausgabe;

            int count  = CountOf(eingabe, such);
            lblAnzeige.Text += "alternative Methode: " + count;

            // test
            int x = 5, y = 1;
            int erg = 1 % 2;
            lblAnzeige.Text += "test: " + erg + "\n";

            int testrec = f1(4,5);
            lblAnzeige.Text = "test 2: " + testrec;            
        }

        private int f1(int x, int y)
        {
            if (y <= 0) return 1;

            if (y % 2 == 0)
                return f1(x * x, y / 2);
            else
                return -x - f1(x, y - 1);
        }

        private void txtInputString_TextChanged(object sender, EventArgs e)
        {
            numInsertPosition.Maximum = txtInputString.Text.Length;
            numDeletePosition.Maximum = txtInputString.Text.Length;
            numSubStringLength.Maximum = txtInputString.Text.Length;
            numSubStringPosition.Maximum = txtInputString.Text.Length - 1;
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe, ausgabe, fuegeEin;
            eingabe = txtInputString.Text;
            fuegeEin = txtInputInsert.Text;

            ausgabe = eingabe.Insert((int)numInsertPosition.Value, fuegeEin);
            lblAnzeige.Text = ausgabe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe, ausgabe;
            eingabe = txtInputString.Text;
            ausgabe = eingabe.Remove((int)numDeleteLength.Value, (int)numDeletePosition.Value);
            lblAnzeige.Text = ausgabe;

        }

        private void numDeletePosition_ValueChanged(object sender, EventArgs e)
        {
            numDeleteLength.Maximum = txtInputString.Text.Length - numDeletePosition.Value;
        }

      
        private void cmdSubString_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe, ausgabe;
            eingabe = txtInputString.Text;
            ausgabe = eingabe.Substring((int)numSubStringPosition.Value, (int)numSubStringLength.Value);
            lblAnzeige.Text = ausgabe;
        }

        private void cmdSubString2_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe, ausgabe;
            eingabe = txtInputString.Text;
            ausgabe = eingabe.Substring((int)numSubStringPosition.Value);
            lblAnzeige.Text = ausgabe;
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            string eingabe, ausgabe, suchen, ersetzen;
            eingabe = txtInputString.Text;
            suchen = txtInputReplace.Text;
            ersetzen = txtInputReplaceBy.Text;
            ausgabe = eingabe.Replace(suchen, ersetzen);
            lblAnzeige.Text = ausgabe;
        }

        private void cmdReverse_Click(object sender, EventArgs e)
        {
            string eingabe;
            string ausgabe = "";
            eingabe = txtInputString.Text;
            for (int i = eingabe.Length-1; i >= 0; i--)
            {
                ausgabe += eingabe[i];
            }
            lblAnzeige.Text = ausgabe;
        }

        private void cmdReverse2_Click(object sender, EventArgs e)
        {
            string eingabe = txtInputString.Text;
            string ausgabe = "";
            ausgabe = reverseString(eingabe);
            lblAnzeige.Text = ausgabe;
           
        }

        private string reverseString(string eingabe)
        {
            if (eingabe == null || eingabe.Length == 1 || eingabe.Length == 0)
            {
                return eingabe;
            }
            else
            {
                return reverseString(eingabe.Substring(1)) + eingabe.Substring(0, 1);
            }
        }

        

        private void numSubStringPosition_ValueChanged(object sender, EventArgs e)
        {
            numSubStringLength.Maximum = txtInputString.Text.Length - numSubStringPosition.Value;
        }

        private int CountOf(string input, string substring)
        {
            string[] seperator = { substring };
            string[] test;
            int count = 0;
            try
            {
                test = input.Split(seperator, StringSplitOptions.None);
                count = input.Split(seperator, StringSplitOptions.None).Count()-1;
            }
            catch
            {
            }
            return count;
        }
    }
}
