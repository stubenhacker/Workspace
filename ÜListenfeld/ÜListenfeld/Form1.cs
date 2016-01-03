using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜListenfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLeft.Items.Add("Malta");
            lstLeft.Items.Add("Zypern");
            lstLeft.Items.Add("Slowenien");
            lstLeft.Items.Add("Estland");
            lstLeft.Items.Add("Rumänien");

            lstRight.Items.Add("Belgien");
            lstRight.Items.Add("Spanien");
            lstRight.Items.Add("Italien");
            lstRight.Items.Add("Portugal");
            lstRight.Items.Add("Dänemark");


        }

        private void cmdCopyLeftToRight_Click(object sender, EventArgs e)
        {
            int xleftIndex = lstLeft.SelectedIndex;
            if (xleftIndex != -1)
            {
                // move all selected items from left to right
                foreach (string s in lstLeft.SelectedItems)
                {
                    lstRight.Items.Add(s);
                }

                // remove all selected items from left listbox
                for (int i = lstLeft.SelectedItems.Count-1; i >= 0; i--)
                {
                    lstLeft.Items.RemoveAt(lstLeft.SelectedIndices[i]);
                }


            }
        }

        private void lstLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnzeige1.Text = "" + lstLeft.SelectedIndices.Count;
            foreach (string s in lstLeft.SelectedItems)
            {
                lblAnzeige1.Text += s + " " + lstLeft.SelectedIndex;
            }
        }

        private void cmdCopyRightToLeft_Click(object sender, EventArgs e)
        {
            // move selected items from right to left
            foreach (string s in lstRight.SelectedItems)
            {
                lstLeft.Items.Add(s);
            }

            // remove all selected items from right listbos
            for (int i = lstRight.SelectedItems.Count-1; i >= 0; i--)
            {
                lstRight.Items.RemoveAt(lstRight.SelectedIndices[i]);
            }
        }
    }
}
