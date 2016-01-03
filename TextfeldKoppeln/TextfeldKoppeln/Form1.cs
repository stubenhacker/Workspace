using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextfeldKoppeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Kopplung;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput1.SelectAll();
            Kopplung = true;
        }

        private void txtInput1_TextChanged(object sender, EventArgs e)
        {
            if (Kopplung)
            {
                txtInput2.Text = txtInput1.Text;
            }
        }

        private void txtInput2_Click(object sender, EventArgs e)
        {
            Kopplung = false;
        }
    }
}
