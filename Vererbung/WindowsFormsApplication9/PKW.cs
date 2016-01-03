using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class PKW : Fahrzeug
    {
        private int insassen;

        public void einsteigen(int anzahl)
        {
            insassen += anzahl;     
        }

        public new string ausgabe()
        {
            return "Insassen: " + insassen + "\n" + base.ausgabe();
        }
    }
}
