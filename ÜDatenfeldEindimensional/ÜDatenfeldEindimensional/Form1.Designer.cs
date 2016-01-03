namespace ÜDatenfeldEindimensional
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
            this.cmdCalcMin = new System.Windows.Forms.Button();
            this.lstFeld = new System.Windows.Forms.ListBox();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCalcMin
            // 
            this.cmdCalcMin.Location = new System.Drawing.Point(157, 31);
            this.cmdCalcMin.Name = "cmdCalcMin";
            this.cmdCalcMin.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcMin.TabIndex = 0;
            this.cmdCalcMin.Text = "Minima";
            this.cmdCalcMin.UseVisualStyleBackColor = true;
            this.cmdCalcMin.Click += new System.EventHandler(this.cmdCalcMin_Click);
            // 
            // lstFeld
            // 
            this.lstFeld.FormattingEnabled = true;
            this.lstFeld.Location = new System.Drawing.Point(12, 31);
            this.lstFeld.Name = "lstFeld";
            this.lstFeld.Size = new System.Drawing.Size(120, 186);
            this.lstFeld.TabIndex = 1;
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(154, 86);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.lstFeld);
            this.Controls.Add(this.cmdCalcMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCalcMin;
        private System.Windows.Forms.ListBox lstFeld;
        private System.Windows.Forms.Label lblAnzeige;
    }
}

