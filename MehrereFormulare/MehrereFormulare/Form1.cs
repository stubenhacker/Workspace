﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehrereFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStartUnter_Click(object sender, EventArgs e)
        {
            Form2 fu = new Form2(this);
            fu.ShowDialog();

        }

        private void cmdEndeHaupt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
