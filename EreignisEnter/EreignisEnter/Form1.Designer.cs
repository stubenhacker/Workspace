namespace EreignisEnter
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkKunde = new System.Windows.Forms.CheckBox();
            this.lstVersand = new System.Windows.Forms.ListBox();
            this.lblHilfe = new System.Windows.Forms.Label();
            this.optZahlungsmethode = new System.Windows.Forms.GroupBox();
            this.rbUeberweisung = new System.Windows.Forms.RadioButton();
            this.rbLastschrift = new System.Windows.Forms.RadioButton();
            this.rbKreditkarte = new System.Windows.Forms.RadioButton();
            this.optZahlungsmethode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // chkKunde
            // 
            this.chkKunde.AutoSize = true;
            this.chkKunde.Location = new System.Drawing.Point(12, 56);
            this.chkKunde.Name = "chkKunde";
            this.chkKunde.Size = new System.Drawing.Size(97, 17);
            this.chkKunde.TabIndex = 1;
            this.chkKunde.Text = "bereits Kunde?";
            this.chkKunde.UseVisualStyleBackColor = true;
            this.chkKunde.Enter += new System.EventHandler(this.chkKunde_Enter);
            // 
            // lstVersand
            // 
            this.lstVersand.FormattingEnabled = true;
            this.lstVersand.Location = new System.Drawing.Point(12, 207);
            this.lstVersand.Name = "lstVersand";
            this.lstVersand.Size = new System.Drawing.Size(120, 95);
            this.lstVersand.TabIndex = 5;
            this.lstVersand.Enter += new System.EventHandler(this.lstVersand_Enter);
            // 
            // lblHilfe
            // 
            this.lblHilfe.AutoSize = true;
            this.lblHilfe.Location = new System.Drawing.Point(12, 305);
            this.lblHilfe.Name = "lblHilfe";
            this.lblHilfe.Size = new System.Drawing.Size(0, 13);
            this.lblHilfe.TabIndex = 6;
            // 
            // optZahlungsmethode
            // 
            this.optZahlungsmethode.Controls.Add(this.rbUeberweisung);
            this.optZahlungsmethode.Controls.Add(this.rbLastschrift);
            this.optZahlungsmethode.Controls.Add(this.rbKreditkarte);
            this.optZahlungsmethode.Location = new System.Drawing.Point(12, 89);
            this.optZahlungsmethode.Name = "optZahlungsmethode";
            this.optZahlungsmethode.Size = new System.Drawing.Size(178, 93);
            this.optZahlungsmethode.TabIndex = 7;
            this.optZahlungsmethode.TabStop = false;
            // 
            // rbUeberweisung
            // 
            this.rbUeberweisung.AutoSize = true;
            this.rbUeberweisung.Location = new System.Drawing.Point(11, 72);
            this.rbUeberweisung.Name = "rbUeberweisung";
            this.rbUeberweisung.Size = new System.Drawing.Size(87, 17);
            this.rbUeberweisung.TabIndex = 7;
            this.rbUeberweisung.TabStop = true;
            this.rbUeberweisung.Text = "Überweisung";
            this.rbUeberweisung.UseVisualStyleBackColor = true;
            this.rbUeberweisung.CheckedChanged += new System.EventHandler(this.grpZahlungsmethode_CheckedChanged);
            // 
            // rbLastschrift
            // 
            this.rbLastschrift.AutoSize = true;
            this.rbLastschrift.Location = new System.Drawing.Point(11, 41);
            this.rbLastschrift.Name = "rbLastschrift";
            this.rbLastschrift.Size = new System.Drawing.Size(73, 17);
            this.rbLastschrift.TabIndex = 6;
            this.rbLastschrift.TabStop = true;
            this.rbLastschrift.Text = "Lastschrift";
            this.rbLastschrift.UseVisualStyleBackColor = true;
            this.rbLastschrift.CheckedChanged += new System.EventHandler(this.grpZahlungsmethode_CheckedChanged);
            // 
            // rbKreditkarte
            // 
            this.rbKreditkarte.AutoSize = true;
            this.rbKreditkarte.Location = new System.Drawing.Point(11, 12);
            this.rbKreditkarte.Name = "rbKreditkarte";
            this.rbKreditkarte.Size = new System.Drawing.Size(76, 17);
            this.rbKreditkarte.TabIndex = 5;
            this.rbKreditkarte.TabStop = true;
            this.rbKreditkarte.Text = "Kreditkarte";
            this.rbKreditkarte.UseVisualStyleBackColor = true;
            this.rbKreditkarte.CheckedChanged += new System.EventHandler(this.grpZahlungsmethode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 336);
            this.Controls.Add(this.optZahlungsmethode);
            this.Controls.Add(this.lblHilfe);
            this.Controls.Add(this.lstVersand);
            this.Controls.Add(this.chkKunde);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Ereignis Enter";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.optZahlungsmethode.ResumeLayout(false);
            this.optZahlungsmethode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox chkKunde;
        private System.Windows.Forms.ListBox lstVersand;
        private System.Windows.Forms.Label lblHilfe;
        private System.Windows.Forms.GroupBox optZahlungsmethode;
        private System.Windows.Forms.RadioButton rbKreditkarte;
        private System.Windows.Forms.RadioButton rbLastschrift;
        private System.Windows.Forms.RadioButton rbUeberweisung;
    }
}

