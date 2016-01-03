using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstOrte.Items.Add("Liechtenstein");
            lstOrte.Items.Add("Malta");
            lstOrte.Items.Add("Andorra");
            lstOrte.Items.Add("San Marino");
            lstOrte.Items.Add("Monaco");
            lstOrte.Items.Add("Schweiz");
        }

    

        private void cmdDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {                
                lstOrte.Items.RemoveAt(lstOrte.SelectedIndex);
            }
            catch (Exception ex)
            {


                
            }

        }

        private void lstOrte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstOrte.SelectedItems.Count > 0)
            {
                cmdDeleteItem.Enabled = true;
            }
            else
            {
                cmdDeleteItem.Enabled = false;
            }
        }

   
    }
}
