using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ereigniskette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            lblAnzeige1.Text = "";
            lblAnzeige2.Text = "";
        }

        private void cmdEvent1_Click(object sender, EventArgs e)
        {
            lblAnzeige1.Text = "Eins";
        }

        private void cmdEvent2_Click(object sender, EventArgs e)
        {
            lblAnzeige2.Text = "Zwei";
        }

        private void cmdEvent3_Click(object sender, EventArgs e)
        {
            cmdEvent1_Click(sender, e);
            cmdEvent2_Click(sender, e);
        }
    }
}
