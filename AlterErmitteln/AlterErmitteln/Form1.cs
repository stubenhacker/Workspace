using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterErmitteln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string ausgabe = "";

            // Geburtstag aus DateTimePicker Komponente
            DateTime gebDat = dtpBirthday.Value;

            // Das Alter in Jahren anhand der Differenz
            int alter = DateTime.Now.Year - gebDat.Year;

            // Prüfen, ob der Geburtstag bereits dieses Jahr stattgefunden hat oder nicht
            // Sollte der Tag (Monat und Tag) erst nach dem aktuellen Tag erfolgen, hat die Person
            // dieses Jahr noch keinen Geburtstag gehabt
            if (DateTime.Today.Month < gebDat.Month)
            {
                alter = alter - 1;
            }

            if (DateTime.Today.Month == gebDat.Month && DateTime.Today.Day < gebDat.Day)
            {
                alter = alter - 1;
            }

            if (DateTime.Today.Month == gebDat.Month && DateTime.Today.Day == gebDat.Day)
            {
                ausgabe = "Herzlichen Glückwunsch zum " + alter + ". Geburtstag heute!";

            }
            else
            {
                ausgabe = "Sie sind " + alter + " Jahre alt.";
            }

            lblAnzeige.Text = ausgabe;
            



        }
    }
}
