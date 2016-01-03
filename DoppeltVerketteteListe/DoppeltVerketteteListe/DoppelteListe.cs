using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoppeltVerketteteListe
{
    class DoppelteListe
    {
        private DoppelListenElement anfang;
        private DoppelListenElement ende;

        public const int VORWAERTS = 0;
        public const int RUECKWAERTS = 1;

        public DoppelteListe()
        {
            this.anfang = null;
            this.ende = null;
        }

        public string toString(int richtung)
        {
            string ergebnis = "";
            switch (richtung)
            {
                case VORWAERTS:
                    ergebnis = "";
                    for (DoppelListenElement laeufer = anfang; laeufer != null; laeufer = laeufer.getWeiter())
                    {
                        ergebnis += laeufer.getDaten() + " / ";
                    }
                    return ergebnis.Substring(0, ergebnis.Length - 3);
                case RUECKWAERTS:
                    ergebnis = "";
                    for (DoppelListenElement laeufer = ende; laeufer != null; laeufer = laeufer.getZurueck())
                    {
                        ergebnis += laeufer.getDaten() + " / ";
                    }
                    return ergebnis.Substring(0, ergebnis.Length - 3);
                default:
                    return "Illegale Richtungsangabe";
            }
        }

        public void fuegeEinAmAnfang(Object daten)
        {
            anfang = new DoppelListenElement(daten, anfang, null);

            if (ende != null)
            {
                anfang.getWeiter().setZurueck(anfang);
            }
            else
            {
                ende = anfang;
            }
        }

        public void fuegeEinAmEnde(Object daten)
        {
            ende = new DoppelListenElement(daten, null, ende);

            if (anfang != null)
            {
                ende.getZurueck().setWeiter(ende);
            }
            else
            {
                anfang = ende;
            }
        }

        public void loescheAmAnfang()
        {
            // Voraussetzung: Liste ist nicht leer
            anfang = anfang.getWeiter();
            if (anfang != null)
            {
                anfang.setZurueck(null);
            }
            else
            {
                ende = null;
            }
        }

        public void loescheAmEnde()
        {
            // Voraussetzung: Liste ist nich leer
            ende = ende.getZurueck();
            if (ende != null)
            {
                ende.setWeiter(null);
            }
            else
            {
                anfang = null;
            }
        }

        public Object getElementAmEnde()
        {
            return ende.getDaten();
        }

        public Object getElementAmAnfang()
        {
            return anfang.getDaten();
        }

        public bool istLeer()
        {
            return anfang == null;
        }

        public int anzahlElemente()
        {
            int anzahl = 0;
            for (DoppelListenElement laeufer = anfang; laeufer != null; laeufer = laeufer.getWeiter())
            {
                ++anzahl;
            }
            return anzahl;
        }
    }
}
