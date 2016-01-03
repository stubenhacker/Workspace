using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseObjekt
{
    class Fahrzeug
    {
        private string bezeichnung;
        private int geschwindigkeit;

        public int Geschwindigkeit
        {
            get
            {
                return geschwindigkeit;
            }
            private set
            {
                if (value > 100)
                {
                    geschwindigkeit = 100;
                }
                else if (value < 0)
                {
                    geschwindigkeit = 0;
                }
                else
                {
                    geschwindigkeit = value;
                }
            }
        }

        // Konstruktor 1
        public Fahrzeug(string b, int g)
        {
            this.bezeichnung = b;
            this.geschwindigkeit = g;
        }

        // Konstruktor 2
        public Fahrzeug(string b)
        {
            bezeichnung = b;
            geschwindigkeit = 0;
        }

        // Konstruktor 3
        public Fahrzeug(int g)
        {
            bezeichnung = "(leer)";
            geschwindigkeit = g;
        }

        // Konstruktor 4
        public Fahrzeug() : this("leer", 0)
        {

        }

        public bool Equals(Fahrzeug x)
        {
            if (bezeichnung == x.bezeichnung && geschwindigkeit == x.geschwindigkeit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public string ausgabe()
        {
            return "Bezeichnung " + bezeichnung + "\n" + 
                    "Geschwindigkeit: " + geschwindigkeit + "\n";
        }

        public void beschleunigen(int wert)
        {
            Geschwindigkeit += wert;
        }
    }

}
