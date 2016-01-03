using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_Konstruktoren
{
    class PKW : Fahrzeug
    {
        private int insassen;

        public PKW()
        {
            insassen = 0;
        }

        public PKW(string b, int g, int i) : base(b, g)
        {
            insassen = i;
        }

        public string ausgabe()
        {
            return "Insassen: " + insassen + "\n" +base.ausgabe();
        }
    }
}
