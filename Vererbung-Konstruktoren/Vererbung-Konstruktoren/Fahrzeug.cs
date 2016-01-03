using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_Konstruktoren
{
    class Fahrzeug
    {
        private int geschwindigkeit;
        private string bezeichnung;

        public Fahrzeug()
        {
            bezeichnung = "(leer)";
            geschwindigkeit = 0;
        }

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public string ausgabe()
        {
            return "Geschwindigkeit: " + geschwindigkeit + " Bezeichnung: " + bezeichnung + "\n";
        }
    }
}
