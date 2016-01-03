using System;

namespace AllgemeineListe
{
    class AllgemeineListe
    {
        private AllgemeinesListenElement anfang;
        private AllgemeinesListenElement ende;

        public AllgemeineListe()
        {
            this.anfang = null;
            this.ende = null;
        }

        public string toString()
        {
            String ergebnis = "";
            for (AllgemeinesListenElement laeufer = anfang; laeufer != null; laeufer = laeufer.getWeiter())
            {
                ergebnis += laeufer.toString() + " / ";
            }
            return ergebnis.Substring(0, ergebnis.Length - 3);
        }

        public void fuegeEinAmAnfang(Object daten)
        {
            anfang = new AllgemeinesListenElement(daten, anfang);

            if (ende == null)
            {
                ende = anfang;
            }
        }

        public void fuegeEinAmEnde(Object daten)
        {
            if (istLeer())
            {
                fuegeEinAmAnfang(daten);
            }
            else
            {
                ende.setWeiter(new AllgemeinesListenElement(daten));
                ende = ende.getWeiter();
            }
        }

        public void loescheAmAnfang()
        {
            if (istLeer())
            {
                return;
            }
            else
            {
                anfang = anfang.getWeiter();
            }

            if (anfang == null)
            {
                ende = null;
            }
        }

        public void loescheAmEnde()
        {
            if (istLeer())
            {
                return;
            }

            if (anfang == ende)
            {
                loescheAmAnfang();
            }
            else
            {
                AllgemeinesListenElement laeufer;
                for (laeufer = anfang; laeufer != ende; laeufer = laeufer.getWeiter()) ;
                ende = laeufer;
                laeufer.setWeiter(null);
            }
        }

        public Object getElementAmAnfang()
        {
            return anfang.getDaten();
        }

        public Object getElementAmEnde()
        {
            return ende.getDaten();
        }

        public int getAnzahlElemente()
        {
            int anzahl = 0;

            for (AllgemeinesListenElement laeufer = anfang; laeufer != null; laeufer = laeufer.getWeiter())
            {
                anzahl++;
            }
            return anzahl;
        }

        public bool istLeer()
        {
            return anfang == null;
        }
    }
}
