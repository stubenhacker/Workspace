using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
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

        public override string ausgabe()
        {
            return base.ausgabe() + "Insassen: " + insassen + "\n";
        }

        public override string ToString()
        {
            return base.ToString() + "Insassen: " + insassen + "\n";
        }
    }
}
