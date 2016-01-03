using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenfeldMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdInsertItem_Click(object sender, EventArgs e)
        {
            string newItem = txtInputNewItem.Text;
            if (newItem.Length == 0)
            {
                return;
            }
            // Einfügeort bestimmen
            // Anfang
            if (rbPositionListStart.Checked)
            {
                lstSpeisen.Items.Insert(0, newItem);
            } // Vor Auswahl einfügen
            else if (rbPostionBeforeSelectedItem.Checked)
            {
                if (lstSpeisen.SelectedIndex != 0)
                {
                    lstSpeisen.Items.Insert(lstSpeisen.SelectedIndex, newItem);
                }
            }
            else
            {
                lstSpeisen.Items.Add(newItem);
            }

            // Eingabefeld leeren
            txtInputNewItem.Text = "";

        }

        private void cmdDeleteItem_Click(object sender, EventArgs e)
        {
            int x = lstSpeisen.SelectedIndex;
            if (x != -1)
            {
                lstSpeisen.Items.RemoveAt(x);
            }
        }

        private void cmdReplaceWith_Click(object sender, EventArgs e)
        {
            string itemReplace = txtReplaceWith.Text;
            int x = lstSpeisen.SelectedIndex;
            if (itemReplace.Length > 0 && x != -1)
            {
                
                lstSpeisen.Items.RemoveAt(x);
                lstSpeisen.Items.Insert(x, itemReplace);
                txtReplaceWith.Text = "";
            }
        }

        private void cmdDeleteAllItems_Click(object sender, EventArgs e)
        {
            lstSpeisen.Items.Clear();
        }

    
    }
}
