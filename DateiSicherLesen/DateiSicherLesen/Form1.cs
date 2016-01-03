using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DateiSicherLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdExistenz_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiName = "ein.txt";
            string zeile;

            if (!File.Exists(dateiName))
            {
                MessageBox.Show("Datei " + dateiName + " existiert nicht.");
                return;
            }

            fs = new FileStream(dateiName, FileMode.Open);
            sr = new StreamReader(fs);

            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                lblAnzeige.Text += zeile + "\n";
            }
            sr.Close();
        }

        private void cmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string zeile;

            try
            {
                fs = new FileStream("ein.txt", FileMode.Open);
                sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    zeile = sr.ReadLine();
                    lblAnzeige.Text += zeile + "\n";
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
