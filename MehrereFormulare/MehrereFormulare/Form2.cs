using System;
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
    public partial class Form2 : Form
    {
        private Form1 fh;

        public Form2(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtInputUnter.Text = fh.Controls["txtInputHaupt"].Text;
            CheckBox cb = fh.Controls["chkHaupt"] as CheckBox;
            chkUnterFormular.Checked = cb.Checked;
        }

        private void cmdEndeUnter_Click(object sender, EventArgs e)
        {
            fh.Controls["txtInputHaupt"].Text = txtInputUnter.Text;
            CheckBox cb = fh.Controls["chkHaupt"] as CheckBox;
            cb.Checked = chkUnterFormular.Checked;
            Close();

        }
    }
}
