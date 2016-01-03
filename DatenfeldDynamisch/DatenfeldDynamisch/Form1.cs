using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldDynamisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random r = new Random();
        private int[] a;

        private void cmdFeldOriginal_Click(object sender, EventArgs e)
        {
            a = new int[4];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                lstFeld.Items.Add(a[i]);
            }

        }

        private void cmdFeldNeu1_Click(object sender, EventArgs e)
        {
            // ref auf Feld a, d.h. das Original wird veraendert
            Array.Resize(ref a, 6);
            // ListBox leeren
            lstFeld.Items.Clear();
            // ListBox erneut fuellen
            for (int i = 0; i < a.Length; i++)
            {
                lstFeld.Items.Add(a[i]);
            }
        }

        private void cmdFeldNeu2_Click(object sender, EventArgs e)
        {
            int newSize = Convert.ToInt32(numFeldGroesse.Value);
            Array.Resize(ref a, newSize);
            lstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                lstFeld.Items.Add(a[i]);
            }

        }
    }
}
