using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int YPos = 44;
        private int Nr = 1;

        private void cmdErzeugen_Click(object sender, EventArgs e)
        {
            Button neuerButton = new Button();
            neuerButton.Location = new Point(12, YPos);
            neuerButton.Size = new Size(75, 26);
            neuerButton.Text = Nr + "";

            neuerButton.Click += new EventHandler(neuerButton_Click);
            Controls.Add(neuerButton);

            YPos = YPos + 32;
            Nr = Nr + 1;
        }

        private void neuerButton_Click(object sender, EventArgs e)
        {
            Button senderButton;
            senderButton = sender as Button;
            Controls.Remove(senderButton);

            MessageBox.Show("Button " + senderButton.Text + " wurde gelöscht.");
        }
    }
}
