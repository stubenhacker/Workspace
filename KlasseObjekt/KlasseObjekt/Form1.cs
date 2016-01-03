using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasseObjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            Fahrzeug schwalbe = new Fahrzeug("Moped");
            Fahrzeug yamaha = new Fahrzeug(50);
            Fahrzeug honda = new Fahrzeug("Motorrad", 75);

            lblAnzeige.Text = vespa.ausgabe() + "\n" + schwalbe.ausgabe() + "\n" + yamaha.ausgabe() + "\n" + honda.ausgabe();
        }

        private void cmdReferenzZuweisen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Mopped", 50);
            Fahrzeug schwalbe;
            schwalbe = vespa;
            MessageBox.Show(vespa.ausgabe() + " / " + schwalbe.ausgabe());
            vespa.beschleunigen(35);
            MessageBox.Show(vespa.ausgabe() + " / " + schwalbe.ausgabe());
        }

        private void cmdReferenzVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if (vespa == schwalbe)
            {
                MessageBox.Show("Die beiden Objekteverweise verweisen auf dasselbe Objekt");
            }
            else
            {
                MessageBox.Show("Die beiden Objektverweise zeigen nicht auf dasselbe Objekt");
            }
        }

        private void cmdObjektVergleich_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);
            if (vespa.Equals(schwalbe)) 
            {
                MessageBox.Show("Die beiden Objekte sind gleich");
            }
            else
            {
                MessageBox.Show("Die beiden Objekte sind nicht gleich");
            }
        }

        private void cmdKlasseErmitteln_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            MessageBox.Show("Objekt vespa ist vom Typ: " + vespa.GetType().ToString());
            MessageBox.Show("Die Klasse heißt " + typeof(Fahrzeug));

            vespa = null;
            if (vespa == null)
            {
                MessageBox.Show("Verweis vespa zeigt auf kein Objekt");
            }
                
        }
    }
}
