using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoppeltVerketteteListe
{
    class DoppelListenElement
    {
        private Object daten;
        private DoppelListenElement weiter;
        private DoppelListenElement zurueck;

        public DoppelListenElement(Object daten)
        {
            this.daten = daten;
        }

        public DoppelListenElement(Object daten, DoppelListenElement weiter, DoppelListenElement zurueck)
        {
            this.daten = daten;
            this.weiter = weiter;
            this.zurueck = zurueck;
        }

        public void setDaten(Object daten)
        {
            this.daten = daten;
        }

        public Object getDaten()
        {
            return daten;
        }

        public void setWeiter(DoppelListenElement weiter)
        {
            this.weiter = weiter;
        }

        public DoppelListenElement getWeiter()
        {
            return weiter;
        }

        public void setZurueck(DoppelListenElement zurueck)
        {
            this.zurueck = zurueck;
        }

        public DoppelListenElement getZurueck()
        {
            return zurueck;
        }

        public string toString()
        {
            return daten.ToString();
        }
    }
}
