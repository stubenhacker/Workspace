namespace TageAddieren
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
            this.numInputDays = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDatum = new System.Windows.Forms.DateTimePicker();
            this.cmdWorkingDays = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInputDays)).BeginInit();
            this.SuspendLayout();
            // 
            // numInputDays
            // 
            this.numInputDays.Location = new System.Drawing.Point(229, 12);
            this.numInputDays.Name = "numInputDays";
            this.numInputDays.Size = new System.Drawing.Size(120, 20);
            this.numInputDays.TabIndex = 0;
            // 
            // dtpStartDatum
            // 
            this.dtpStartDatum.Location = new System.Drawing.Point(12, 12);
            this.dtpStartDatum.Name = "dtpStartDatum";
            this.dtpStartDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDatum.TabIndex = 1;
            // 
            // cmdWorkingDays
            // 
            this.cmdWorkingDays.Location = new System.Drawing.Point(375, 12);
            this.cmdWorkingDays.Name = "cmdWorkingDays";
            this.cmdWorkingDays.Size = new System.Drawing.Size(165, 23);
            this.cmdWorkingDays.TabIndex = 2;
            this.cmdWorkingDays.Text = "berechne Werktage";
            this.cmdWorkingDays.UseVisualStyleBackColor = true;
            this.cmdWorkingDays.Click += new System.EventHandler(this.cmdWorkingDays_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 82);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 262);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdWorkingDays);
            this.Controls.Add(this.dtpStartDatum);
            this.Controls.Add(this.numInputDays);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInputDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numInputDays;
        private System.Windows.Forms.DateTimePicker dtpStartDatum;
        private System.Windows.Forms.Button cmdWorkingDays;
        private System.Windows.Forms.Label lblAnzeigen;
    }
}

