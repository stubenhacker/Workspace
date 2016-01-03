using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLDatei
{
    class Person
    {
        private string name;
        private string vorname;
        private int personalnummer;
        private double gehalt;
        private DateTime geburtstag;

        public Person(string na, string vo, int pn, double ge, DateTime gt)
        {
            this.name = na;
            this.vorname = vo;
            this.personalnummer = pn;
            this.gehalt = ge;
            this.geburtstag = gt;            
        }

        public void AlsXmlElementSchreiben(XmlTextWriter xw)
        {
            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", name);
            xw.WriteAttributeString("vorname", vorname);
            xw.WriteAttributeString("personalnummer", personalnummer.ToString());
            xw.WriteAttributeString("gehalt", gehalt.ToString());
            xw.WriteAttributeString("geburtstag", geburtstag.ToShortDateString());
            xw.WriteEndElement();
        }

        public string ausgabe()
        {
            return name + ", " + vorname + ", " + personalnummer + ", " + gehalt + ", " + geburtstag.ToShortDateString();
        }
    }
}
