using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerischeTypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdListString_Click(object sender, EventArgs e)
        {
            List<string> li = new List<string>();
            lstAnzeige1.Items.Clear();

            li.Add("Spanien");
            li.Add("Belgien");
            li.Add("Schweiz");
            ausgabeListString("Zu Beginn", li);

            if (li.Contains("Belgien"))
            {
                lstAnzeige1.Items.Add("Enthält Belgien");
            }

            lstAnzeige1.Items.Add("Enthält Schweiz an Position" + li.IndexOf("Schweiz"));
            lstAnzeige1.Items.Add("Enthält Estland an Position" + li.IndexOf("Estland"));

            if (li.Count >= 2)
            {
                li.Insert(2, "Polen");
            }
            ausgabeListString("Nach Einfügen an Position", li);

            if (li.Count >= 2)
            {
                li.RemoveAt(1);
            }
            ausgabeListString("Nach Löschen an Position", li);

            bool geloescht;
            do
            {
                geloescht = li.Remove("Spanien");
            } while (geloescht);

            ausgabeListString("Nach (mehrfachem) Löschen eines Wertes", li);

        }


        private void ausgabeListString(string v, List<string> li)
        {
            string ausgabe = v + ": ";
            foreach (string s in li)
            {
                ausgabe += s + " ";
            }
            lstAnzeige1.Items.Add(ausgabe);
        }

        private void cmdListLand_Click(object sender, EventArgs e)
        {
            List<Land> li = new List<Land>();

            lstAnzeige1.Items.Clear();

            li.Add(new Land("Spanien", "Madrid"));
            li.Add(new Land("Schweiz", "Bern"));
            ausgabeListLand("Zu Beginn", li);

            if (li.Contains(new Land("Schweiz", "Bern")))
            {
                lstAnzeige1.Items.Add("Enthält Schweiz/Bern");
            }

            lstAnzeige1.Items.Add("Schweiz/Bern an Position" + li.IndexOf(new Land("Schweiz", "Bern")));
            lstAnzeige1.Items.Add("Estland/Tallinn an Position" + li.IndexOf(new Land("Estland", "Tallinn")));

            if (li.Count >= 1)
            {
                li.Insert(1, new Land("Polen", "Warschau"));
            }
            ausgabeListLand("Nach Einfügen an Position", li);

            if (li.Count >= 1)
            {
                li.RemoveAt(0);
            }
            ausgabeListLand("Nach Löschen an Position", li);

            bool geloescht;
            do
            {
                geloescht = li.Remove(new Land("Schweiz", "Bern"));
            } while (geloescht);
            ausgabeListLand("Nach (mehrfachem) Löschen eines Wertes", li);
        }

        private void ausgabeListLand(string v, List<Land> li)
        {
            string ausgabe = v + ": ";
            foreach (Land x in li)
            {
                ausgabe += x + " ";
            }
            lstAnzeige1.Items.Add(ausgabe);
        }

        private void cmdDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, Land> dc = new Dictionary<string, Land>();
            lstAnzeige1.Items.Clear();

            dc["E"] = new Land("Spanien", "Madrid");
            dc["CH"] = new Land("Schweiz", "Bern");

            lstAnzeige1.Items.Add("Anzahl: " + dc.Count);

            ausgabeDictKeys("Schlüssel", dc);
            ausgabeDictValues("Werte", dc);
            ausgabeDict("Zu Beginn", dc);

            if (dc.ContainsKey("CH"))
            {
                lstAnzeige1.Items.Add("Enthält Schlüssel CH");
            }

            if (dc.ContainsValue(new Land("Schweiz", "Bern")))
            {
                lstAnzeige1.Items.Add("Enthält Wert Schweiz/Bern");
            }

            dc["E"] = new Land("Ecuador", "Quito");
            ausgabeDict("Nach Ersetzen über Schlüssel", dc);

            dc.Remove("E");
            ausgabeDict("Nach Löschen über Schlüssel", dc);

        }

        private void ausgabeDict(string v, Dictionary<string, Land> dc)
        {
            string a = v + ": ";
            foreach (string sx in dc.Keys)
            {
                a += sx + "#" + dc[sx] + " ";
            }
            lstAnzeige1.Items.Add(a);
        }

        private void ausgabeDictValues(string v, Dictionary<string, Land> dc)
        {
            string a = v + ": ";
            foreach (Land lx in dc.Values)
            {
                a += lx + " ";
            }
            lstAnzeige1.Items.Add(a);
        }

        private void ausgabeDictKeys(string v, Dictionary<string, Land> dc)
        {
            string a = v + ": ";
            foreach (string sx in dc.Keys)
            {
                a += sx + " ";
            }
            lstAnzeige1.Items.Add(a);

        }
    }
}
