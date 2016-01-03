using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Fahrzeug
    {
        private int geschwindigkeit;

        public void beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }
        public string ausgabe()
        {
            return "Geschwindigkeit: " + geschwindigkeit + "\n";
        }

    }
}
