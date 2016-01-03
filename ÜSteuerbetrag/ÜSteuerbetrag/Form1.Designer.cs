namespace ÜSteuerbetrag
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
            this.cmdCalc = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCalc
            // 
            this.cmdCalc.Location = new System.Drawing.Point(33, 125);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(75, 23);
            this.cmdCalc.TabIndex = 0;
            this.cmdCalc.Text = "berechnen";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(33, 55);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(148, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(187, 58);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 262);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmdCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCalc;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAnzeigen;
    }
}

