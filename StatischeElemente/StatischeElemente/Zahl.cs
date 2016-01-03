using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeElemente
{
    class Zahl
    {
        private double wert;
        private int nummer;
        private static int anzahl = 0;
        public static double pi = 3.1415926;

        public Zahl(double x)
        {
            anzahl += 1;
            nummer = anzahl;
            wert = x;
        }

        public void malDrei()
        {
            wert = wert * 3;
        }

        public static double verdoppeln(double x)
        {
            return x * 2;
        }

        public string ausgabe()
        {
            return "Object Nr. " + nummer + " Wert: " + wert;
        }

    }
}
