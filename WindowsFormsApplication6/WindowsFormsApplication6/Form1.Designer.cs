namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.cmdOben = new System.Windows.Forms.Button();
            this.cmdRechts = new System.Windows.Forms.Button();
            this.cmdUnten = new System.Windows.Forms.Button();
            this.cmdLinks = new System.Windows.Forms.Button();
            this.pnlQuadrat = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdOben
            // 
            this.cmdOben.Location = new System.Drawing.Point(253, 12);
            this.cmdOben.Name = "cmdOben";
            this.cmdOben.Size = new System.Drawing.Size(75, 23);
            this.cmdOben.TabIndex = 0;
            this.cmdOben.Text = "nach oben";
            this.cmdOben.UseVisualStyleBackColor = true;
            this.cmdOben.Click += new System.EventHandler(this.cmdOben_Click);
            // 
            // cmdRechts
            // 
            this.cmdRechts.Location = new System.Drawing.Point(500, 148);
            this.cmdRechts.Name = "cmdRechts";
            this.cmdRechts.Size = new System.Drawing.Size(75, 23);
            this.cmdRechts.TabIndex = 1;
            this.cmdRechts.Text = "nach rechts";
            this.cmdRechts.UseVisualStyleBackColor = true;
            this.cmdRechts.Click += new System.EventHandler(this.cmdRechts_Click);
            // 
            // cmdUnten
            // 
            this.cmdUnten.Location = new System.Drawing.Point(253, 321);
            this.cmdUnten.Name = "cmdUnten";
            this.cmdUnten.Size = new System.Drawing.Size(75, 23);
            this.cmdUnten.TabIndex = 2;
            this.cmdUnten.Text = "nach unten";
            this.cmdUnten.UseVisualStyleBackColor = true;
            this.cmdUnten.Click += new System.EventHandler(this.cmdUnten_Click);
            // 
            // cmdLinks
            // 
            this.cmdLinks.Location = new System.Drawing.Point(8, 148);
            this.cmdLinks.Name = "cmdLinks";
            this.cmdLinks.Size = new System.Drawing.Size(75, 23);
            this.cmdLinks.TabIndex = 3;
            this.cmdLinks.Text = "nach links";
            this.cmdLinks.UseVisualStyleBackColor = true;
            this.cmdLinks.Click += new System.EventHandler(this.cmdLinks_Click);
            // 
            // pnlQuadrat
            // 
            this.pnlQuadrat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlQuadrat.Location = new System.Drawing.Point(145, 80);
            this.pnlQuadrat.Name = "pnlQuadrat";
            this.pnlQuadrat.Size = new System.Drawing.Size(100, 100);
            this.pnlQuadrat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 356);
            this.Controls.Add(this.pnlQuadrat);
            this.Controls.Add(this.cmdLinks);
            this.Controls.Add(this.cmdUnten);
            this.Controls.Add(this.cmdRechts);
            this.Controls.Add(this.cmdOben);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOben;
        private System.Windows.Forms.Button cmdRechts;
        private System.Windows.Forms.Button cmdUnten;
        private System.Windows.Forms.Button cmdLinks;
        private System.Windows.Forms.Panel pnlQuadrat;
    }
}

