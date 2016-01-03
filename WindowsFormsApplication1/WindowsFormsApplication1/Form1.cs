using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x = 0;


        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double y = 0;
            y = y + 0.1;
            x += 0.1;
            lblAnzeigen.Text = "x: " + x + " y: " + y;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0;
            z += 0.1;
            x += 0.1;
            lblAnzeigen.Text = "x: " + x + " z: " + z;
        }
    }
}
