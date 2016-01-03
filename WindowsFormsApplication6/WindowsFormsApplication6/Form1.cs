using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOben_Click(object sender, EventArgs e)
        {
            pnlQuadrat.Location = new Point(pnlQuadrat.Location.X, pnlQuadrat.Location.Y - 10);
        }

        private void cmdLinks_Click(object sender, EventArgs e)
        {
            pnlQuadrat.Location = new Point(pnlQuadrat.Location.X - 10, pnlQuadrat.Location.Y);
        }

        private void cmdRechts_Click(object sender, EventArgs e)
        {
            pnlQuadrat.Location = new Point(pnlQuadrat.Location.X + 10, pnlQuadrat.Location.Y);
        }

        private void cmdUnten_Click(object sender, EventArgs e)
        {
            pnlQuadrat.Location = new Point(pnlQuadrat.Location.X, pnlQuadrat.Location.Y + 10);
        }
    }
}
