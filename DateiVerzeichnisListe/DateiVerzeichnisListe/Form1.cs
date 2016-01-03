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

namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Temp"))
            {
                Directory.SetCurrentDirectory(@"C:\Temp");
            }
            else
            {
                MessageBox.Show(@"Verzeichnis C:\Temp existiert nicht");
            }
            lblAnzeigen.Text = Directory.GetCurrentDirectory();
        }

        private void cmdDateiListe_Click(object sender, EventArgs e)
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFiles(verzeichnis);
            lstAnzeigen.Items.Clear();
            foreach (string item in dateiliste)
            {
                lstAnzeigen.Items.Add(item);
            }
        }

        private void Systemeinträge_Click(object sender, EventArgs e)
        {
            Systemeinträge();
        }

        private void Systemeinträge()
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFileSystemEntries(verzeichnis);
            lstAnzeigen.Items.Clear();

            foreach (string s in dateiliste)
            {
                lstAnzeigen.Items.Add(s);
            }
        }

        private void lstAnzeigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;
            if (lstAnzeigen.SelectedIndex != -1)
            {
                name = lstAnzeigen.Text;
                lblAnzeigenInfo.Text = name + "\nErzeugt: " + File.GetCreationTime(name) + "\nLetzter Zugriff: " + File.GetLastAccessTime(name) + "\n" + "Letzter Schreibzugriff: " + File.GetLastWriteTime(name);
            }
            else
            {
                MessageBox.Show("Kein Eintrag gewählt.");
            }
        }

        private void cmdInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (lstAnzeigen.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(lstAnzeigen.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(lstAnzeigen.Text + " ist kein Verzeichnis");
                }
            }
            else
            {
                MessageBox.Show("Kein Eintrag gewählt");
            }
            lblAnzeigen.Text = Directory.GetCurrentDirectory();
            Systemeinträge();
        }

        private void cmdNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            lblAnzeigen.Text = Directory.GetCurrentDirectory();
            Systemeinträge();
        }
    }
}
