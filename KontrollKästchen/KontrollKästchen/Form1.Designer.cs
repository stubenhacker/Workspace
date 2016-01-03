namespace KontrollKästchen
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.cmdSwitchCheck = new System.Windows.Forms.Button();
            this.lblAnzeigenPrüfung1 = new System.Windows.Forms.Label();
            this.lblAnzeigenPrüfung2 = new System.Windows.Forms.Label();
            this.chkSchalter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(281, 35);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(98, 23);
            this.cmdCheck.TabIndex = 0;
            this.cmdCheck.Text = "Schalter prüfen";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // cmdSwitchCheck
            // 
            this.cmdSwitchCheck.Location = new System.Drawing.Point(281, 149);
            this.cmdSwitchCheck.Name = "cmdSwitchCheck";
            this.cmdSwitchCheck.Size = new System.Drawing.Size(112, 23);
            this.cmdSwitchCheck.TabIndex = 1;
            this.cmdSwitchCheck.Text = "Schalter umschalten";
            this.cmdSwitchCheck.UseVisualStyleBackColor = true;
            this.cmdSwitchCheck.Click += new System.EventHandler(this.cmdSwitchCheck_Click);
            // 
            // lblAnzeigenPrüfung1
            // 
            this.lblAnzeigenPrüfung1.AutoSize = true;
            this.lblAnzeigenPrüfung1.Location = new System.Drawing.Point(154, 40);
            this.lblAnzeigenPrüfung1.Name = "lblAnzeigenPrüfung1";
            this.lblAnzeigenPrüfung1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigenPrüfung1.TabIndex = 2;
            // 
            // lblAnzeigenPrüfung2
            // 
            this.lblAnzeigenPrüfung2.AutoSize = true;
            this.lblAnzeigenPrüfung2.Location = new System.Drawing.Point(169, 149);
            this.lblAnzeigenPrüfung2.Name = "lblAnzeigenPrüfung2";
            this.lblAnzeigenPrüfung2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigenPrüfung2.TabIndex = 3;
            // 
            // chkSchalter
            // 
            this.chkSchalter.AutoSize = true;
            this.chkSchalter.Location = new System.Drawing.Point(281, 106);
            this.chkSchalter.Name = "chkSchalter";
            this.chkSchalter.Size = new System.Drawing.Size(65, 17);
            this.chkSchalter.TabIndex = 4;
            this.chkSchalter.Text = "Schalter";
            this.chkSchalter.UseVisualStyleBackColor = true;
            this.chkSchalter.CheckedChanged += new System.EventHandler(this.chkSchalter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 262);
            this.Controls.Add(this.chkSchalter);
            this.Controls.Add(this.lblAnzeigenPrüfung2);
            this.Controls.Add(this.lblAnzeigenPrüfung1);
            this.Controls.Add(this.cmdSwitchCheck);
            this.Controls.Add(this.cmdCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.Button cmdSwitchCheck;
        private System.Windows.Forms.Label lblAnzeigenPrüfung1;
        private System.Windows.Forms.Label lblAnzeigenPrüfung2;
        private System.Windows.Forms.CheckBox chkSchalter;
    }
}

