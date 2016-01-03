using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void cmdCenter_Click(object sender, EventArgs e)
        {
            pnlOne.Location = new Point((myForm.ActiveForm.Width / 2) - 10, (myForm.ActiveForm.Height / 2) - 10);
            pnlTwo.Location = new Point((myForm.ActiveForm.Width / 2) + 10, (myForm.ActiveForm.Height / 2) - 10);
            pnlThree.Location = new Point((myForm.ActiveForm.Width / 2) + 10, (myForm.ActiveForm.Height / 2) + 10);
            pnlFour.Location = new Point((myForm.ActiveForm.Width / 2) - 10, (myForm.ActiveForm.Height / 2) + 10);
            //pnlOne.Location = new Point((myForm.ActiveForm.Width / 2), (myForm.ActiveForm.Height / 2));
            //pnlTwo.Location = new Point((myForm.ActiveForm.Width / 2), (myForm.ActiveForm.Height / 2));
            //pnlThree.Location = new Point((myForm.ActiveForm.Width / 2), (myForm.ActiveForm.Height / 2));
            //pnlFour.Location = new Point((myForm.ActiveForm.Width / 2), (myForm.ActiveForm.Height / 2));
        }

        private void cmdStartStop_Click(object sender, EventArgs e)
        {
            timAnzeige.Enabled = !timAnzeige.Enabled;
        }

        private void timAnzeige_Tick(object sender, EventArgs e)
        {
            pnlOne.Location = new Point(pnlOne.Location.X-5, pnlOne.Location.Y-5);
            pnlTwo.Location = new Point(pnlTwo.Location.X+5, pnlTwo.Location.Y-5);
            pnlThree.Location = new Point(pnlThree.Location.X+5, pnlThree.Location.Y+5);
            pnlFour.Location = new Point(pnlFour.Location.X-5, pnlFour.Location.Y+5);
        }
    }
}
