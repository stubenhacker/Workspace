using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatischeElemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Zahl x = new Zahl(2.5);
            Zahl p = new Zahl(-5);
            double y, r;

            // objektbezogene Methoden
            x.malDrei();
            lblAnzeige.Text = x.ausgabe() + "\n" + p.ausgabe();

            // Klassenbezogene und öffentliche Methoden
            y = 4;
            lblAnzeige.Text += "\n" + "Zahl: " + y + "\n" + "Nach Verdopplung: " + Zahl.verdoppeln(y);

        }
    }
}
