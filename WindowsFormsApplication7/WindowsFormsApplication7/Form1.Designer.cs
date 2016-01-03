namespace WindowsFormsApplication7
{
    partial class myForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdStartStop = new System.Windows.Forms.Button();
            this.pnlOne = new System.Windows.Forms.Panel();
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.pnlThree = new System.Windows.Forms.Panel();
            this.pnlFour = new System.Windows.Forms.Panel();
            this.timAnzeige = new System.Windows.Forms.Timer(this.components);
            this.cmdCenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStartStop
            // 
            this.cmdStartStop.Location = new System.Drawing.Point(198, 3);
            this.cmdStartStop.Name = "cmdStartStop";
            this.cmdStartStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStartStop.TabIndex = 0;
            this.cmdStartStop.Text = "Start/Stop";
            this.cmdStartStop.UseVisualStyleBackColor = true;
            this.cmdStartStop.Click += new System.EventHandler(this.cmdStartStop_Click);
            // 
            // pnlOne
            // 
            this.pnlOne.BackColor = System.Drawing.SystemColors.InfoText;
            this.pnlOne.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlOne.Location = new System.Drawing.Point(198, 177);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(20, 20);
            this.pnlOne.TabIndex = 1;
            // 
            // pnlTwo
            // 
            this.pnlTwo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTwo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTwo.Location = new System.Drawing.Point(299, 177);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(20, 20);
            this.pnlTwo.TabIndex = 0;
            // 
            // pnlThree
            // 
            this.pnlThree.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlThree.Location = new System.Drawing.Point(172, 247);
            this.pnlThree.Name = "pnlThree";
            this.pnlThree.Size = new System.Drawing.Size(20, 20);
            this.pnlThree.TabIndex = 0;
            // 
            // pnlFour
            // 
            this.pnlFour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlFour.Location = new System.Drawing.Point(299, 247);
            this.pnlFour.Name = "pnlFour";
            this.pnlFour.Size = new System.Drawing.Size(20, 20);
            this.pnlFour.TabIndex = 0;
            // 
            // timAnzeige
            // 
            this.timAnzeige.Interval = 1000;
            this.timAnzeige.Tick += new System.EventHandler(this.timAnzeige_Tick);
            // 
            // cmdCenter
            // 
            this.cmdCenter.Location = new System.Drawing.Point(0, 0);
            this.cmdCenter.Name = "cmdCenter";
            this.cmdCenter.Size = new System.Drawing.Size(75, 23);
            this.cmdCenter.TabIndex = 2;
            this.cmdCenter.Text = "zentrieren";
            this.cmdCenter.UseVisualStyleBackColor = true;
            this.cmdCenter.Click += new System.EventHandler(this.cmdCenter_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.cmdCenter);
            this.Controls.Add(this.pnlTwo);
            this.Controls.Add(this.pnlThree);
            this.Controls.Add(this.pnlFour);
            this.Controls.Add(this.pnlOne);
            this.Controls.Add(this.cmdStartStop);
            this.Name = "myForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStartStop;
        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.Panel pnlThree;
        private System.Windows.Forms.Panel pnlFour;
        private System.Windows.Forms.Timer timAnzeige;
        private System.Windows.Forms.Button cmdCenter;
    }
}

