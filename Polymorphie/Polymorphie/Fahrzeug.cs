using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Fahrzeug
    {
        private string bezeichnung;
        private int geschwindigkeit;

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

        public virtual string ausgabe()
        {
            return "\nBezeichnung: " + bezeichnung + "\n" + "Geschwindigkeit: " + geschwindigkeit + "\n";
        }

        public override string ToString()
        {
            return "\nBezeichnung: " + bezeichnung + "\n" + "Geschwindigkeit: " + geschwindigkeit + "\n";
        }

    }
}
