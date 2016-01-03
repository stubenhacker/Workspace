using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenfeldFüllen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSpeisen.Items.Add("Spaghetti");
            lstSpeisen.Items.Add("Grüne Nudeln");
            lstSpeisen.Items.Add("Tortellini");
            lstSpeisen.Items.Add("Pizza");
            lstSpeisen.Items.Add("Lasagne");
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            lblAnzeigen.Text = "Anzahl der Items: " + lstSpeisen.Items.Count;

            lblAnzeigen2.Text = "Ausgewähltes Item: " + lstSpeisen.SelectedItem;

            lblAnzeigen3.Text = "Indes / Nummer des gewählten Items: " + lstSpeisen.SelectedIndex;

            lblAnzeigen4.Text = "Alle Einträge aus dieser Listbox lauten: " + "\n";
            for (int i = 0; i < lstSpeisen.Items.Count; i++)
            {
                lblAnzeigen4.Text += lstSpeisen.Items[i] + "\n";
            }


            // foreach Schleife
            lblAnzeigen5.Text = "Alle Items dieser Listbox: " + "\n";
            foreach (string s in lstSpeisen.Items)
            {
                lblAnzeigen5.Text += s + "\n";
            }
        }

        private void cmdSelectedChanged_Click(object sender, EventArgs e)
        {
            lstSpeisen.SelectedIndex = 3;
        }

        private void lstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnzeigen7.Text = "Auswahl: " + lstSpeisen.SelectedItem;
        }
    }
}
