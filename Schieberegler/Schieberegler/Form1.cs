using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schieberegler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FarbenAnzeigen();
        }

        private void FarbenAnzeigen()
        {
            pnlColorChange.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value);
            lblAnzeigenRed.Text = "" + trkRed.Value;
            lblAnzeigenGreen.Text = "" + trkGreen.Value;
            lblAnzeigenBlue.Text = "" + trkBlue.Value;
        }

        private void FarbenGewechselt(object sender, EventArgs e)
        {
            FarbenAnzeigen();
        }

      
    }
}
