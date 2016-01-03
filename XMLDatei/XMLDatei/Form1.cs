using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLDatei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdXMLSchreiben_Click(object sender, EventArgs e)
        {
            XmlTextWriter xw = new XmlTextWriter(
                "C:\\Temp\\firma.xml", new UnicodeEncoding());
            xw.WriteStartDocument();
            xw.WriteStartElement("firma");

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Maier");
            xw.WriteAttributeString("vorname", "Hans");
            xw.WriteAttributeString("personalnummer", "6714");
            xw.WriteAttributeString("gehalt", "3500.0");
            xw.WriteAttributeString("geburtstag", "15.03.1962");
            xw.WriteEndElement();

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Schmitz");
            xw.WriteAttributeString("vorname", "Peter");
            xw.WriteAttributeString("personalnummer", "81343");
            xw.WriteAttributeString("gehalt", "3750.0");
            xw.WriteAttributeString("geburtstag", "12.04.1958");
            xw.WriteEndElement();

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Mertens");
            xw.WriteAttributeString("vorname", "Julia");
            xw.WriteAttributeString("personalnummer", "2297");
            xw.WriteAttributeString("gehalt", "3621.5");
            xw.WriteAttributeString("geburtstag", "30.12.1959");
            xw.WriteEndElement();

            xw.WriteEndElement();
            xw.Close();
        }

        private void cmdXMLLesen_Click(object sender, EventArgs e)
        {
            lblAnzeigen.Text = "";

            if (!File.Exists("C://Temp/firma.xml"))
            {
                return;
            }

            XmlReader xr = new XmlTextReader("C://Temp/firma.xml");

            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    if (xr.AttributeCount > 0)
                    {
                        while (xr.MoveToNextAttribute())
                        {
                            lblAnzeigen.Text += xr.Name + " -> " + xr.Value + "\n";
                        }
                        lblAnzeigen.Text += "\n";
                    }
                }
            }
            xr.Close();
        }

        private void cmdObjektIn_Click(object sender, EventArgs e)
        {
            Person[] personFeld = new Person[3];
            personFeld[0] = new Person("Maier", "Hans", 6714, 3500.0, new DateTime(1962, 3, 5));
            personFeld[1] = new Person("Schmitz", "Peter", 81343, 3750.0, new DateTime(1958, 4, 12));
            personFeld[2] = new Person("Mertens", "Julia", 2297, 3621.5, new DateTime(1959, 12, 30));

            XmlTextWriter xw = new XmlTextWriter("C:\\Temp\\firma.xml", new UnicodeEncoding());
            xw.WriteStartDocument();
            xw.WriteStartElement("firma");

            foreach (Person p in personFeld)
            {
                p.AlsXmlElementSchreiben(xw);
            }
            ////xw.WriteEndElement();
            xw.Close();
        }

        private void cmdObjekteLesen_Click(object sender, EventArgs e)
        {
            lblAnzeigen.Text = "";

            if (!File.Exists("C:\\Temp\\firma.xml"))
            {
                return;
            }

            Person[] personFeld = new Person[3];
            string na = "";
            string vo = "";
            int pe = 0;
            double ge = 0.0;
            DateTime gt = new DateTime();
            int i;

            XmlReader xr = new XmlTextReader("C:\\Temp\\firma.xml");

            i = 0;

            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    if (xr.AttributeCount > 0)
                    {
                        while (xr.MoveToNextAttribute())
                        {
                            switch (xr.Name)
                            {
                                case "name":
                                    na = xr.Value;
                                    break;
                                case "vorname":
                                    vo = xr.Value;
                                    break;
                                case "personalnummer":
                                    pe = Convert.ToInt32(xr.Value);
                                    break;
                                case "gehalt":
                                    ge = Convert.ToSingle(xr.Value);
                                    break;
                                case "geburtstag":
                                    int jahr = Convert.ToInt32(xr.Value.Substring(6, 4));
                                    int monat = Convert.ToInt32(xr.Value.Substring(3, 2));
                                    int tag = Convert.ToInt32(xr.Value.Substring(0, 2));
                                    gt = new DateTime(jahr, monat, tag);
                                    break;
                            }
                            personFeld[i] = new Person(na, vo, pe, ge, gt);
                            i = i + 1; 

                        }
                        xr.Close();
                        foreach (Person p in personFeld)
                        {
                            lblAnzeigen.Text += p.ausgabe() + "\n";
                        }
                    }
                }
            }
        }
    }
}
