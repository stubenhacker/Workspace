using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllgemeineListe
{
    class AllgemeinesListenElement
    {
        private Object daten;
        private AllgemeinesListenElement weiter;

        public AllgemeinesListenElement(Object daten)
        {
            this.daten = daten;
            this.weiter = null;
        }

        public AllgemeinesListenElement(Object daten, AllgemeinesListenElement weiter)
        {
            this.daten = daten;
            this.weiter = weiter;
        }

        public void setDaten(Object daten)
        {
            this.daten = daten;
        }

        public Object getDaten()
        {
            return daten;
        }

        public void setWeiter(AllgemeinesListenElement weiter)
        {
            this.weiter = weiter;
        }

        public AllgemeinesListenElement getWeiter()
        {
            return weiter;
        }

        public string toString()
        {
            return daten.ToString();
        }

    }
}
