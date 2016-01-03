using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchleife1_Click(object sender, EventArgs e)
        {
            int i;
            lblSchleife1.Text = "";

            for (i = 3; i <= 7; i++)
            {
                lblSchleife1.Text += i + "\n";
            }
        }

        private void cmdSchleife2_Click(object sender, EventArgs e)
        {
            lblSchleife2.Text = "";

            for (int i = 3; i <= 11; i = i +2)
            {
                lblSchleife2.Text += i + "\n";
            }
        }

        private void cmdSchleife3_Click(object sender, EventArgs e)
        {
            lblSchleife3.Text = "";
            for (int i = 7; i >= 3; i--)
            {
                lblSchleife3.Text += i + "\n";
            }
        }

        private void cmdSchleife4_Click(object sender, EventArgs e)
        {
            lblSchleife4.Text = "";
            for (double d = 3.5; d<= 7.5; d = d + 1.5)
            {
                lblSchleife4.Text += d + "\n";
            }
        }

        private void cmdSchleife5_Click(object sender, EventArgs e)
        {
            lblSchleife5.Text = "";
            for (int i = 3; i <= 20; i++)
            {
                if (i >= 5 && i <= 7)
                {
                    continue;
                }
                if (i >= 11)
                {
                    break;
                }
                lblSchleife5.Text += i + "\n";
            }
        }
    }
}
