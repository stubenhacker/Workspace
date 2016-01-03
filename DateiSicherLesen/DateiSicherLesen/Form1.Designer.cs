namespace DateiSicherLesen
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
            this.cmdExistenz = new System.Windows.Forms.Button();
            this.cmdAusnahme = new System.Windows.Forms.Button();
            this.cmdPfad = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdExistenz
            // 
            this.cmdExistenz.Location = new System.Drawing.Point(277, 12);
            this.cmdExistenz.Name = "cmdExistenz";
            this.cmdExistenz.Size = new System.Drawing.Size(75, 23);
            this.cmdExistenz.TabIndex = 0;
            this.cmdExistenz.Text = "Existenz";
            this.cmdExistenz.UseVisualStyleBackColor = true;
            this.cmdExistenz.Click += new System.EventHandler(this.cmdExistenz_Click);
            // 
            // cmdAusnahme
            // 
            this.cmdAusnahme.Location = new System.Drawing.Point(277, 41);
            this.cmdAusnahme.Name = "cmdAusnahme";
            this.cmdAusnahme.Size = new System.Drawing.Size(75, 23);
            this.cmdAusnahme.TabIndex = 1;
            this.cmdAusnahme.Text = "Ausnahme";
            this.cmdAusnahme.UseVisualStyleBackColor = true;
            this.cmdAusnahme.Click += new System.EventHandler(this.cmdAusnahme_Click);
            // 
            // cmdPfad
            // 
            this.cmdPfad.Location = new System.Drawing.Point(277, 70);
            this.cmdPfad.Name = "cmdPfad";
            this.cmdPfad.Size = new System.Drawing.Size(75, 23);
            this.cmdPfad.TabIndex = 2;
            this.cmdPfad.Text = "Pfad";
            this.cmdPfad.UseVisualStyleBackColor = true;
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 22);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 262);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdPfad);
            this.Controls.Add(this.cmdAusnahme);
            this.Controls.Add(this.cmdExistenz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExistenz;
        private System.Windows.Forms.Button cmdAusnahme;
        private System.Windows.Forms.Button cmdPfad;
        private System.Windows.Forms.Label lblAnzeige;
    }
}

