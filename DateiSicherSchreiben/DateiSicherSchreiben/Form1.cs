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

namespace DateiSicherSchreiben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            string dateiName = "aus.txt";

            try
            {
                fs = new FileStream(dateiName, FileMode.Create);
                sw = new StreamWriter(fs);
                sw.WriteLine(txtInput.Text);
                sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
