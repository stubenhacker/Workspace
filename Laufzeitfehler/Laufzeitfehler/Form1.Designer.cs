namespace Laufzeitfehler
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
            this.cmdRechnen = new System.Windows.Forms.Button();
            this.txtInputZahl1 = new System.Windows.Forms.TextBox();
            this.txtInputZahl2 = new System.Windows.Forms.TextBox();
            this.lblZahl1 = new System.Windows.Forms.Label();
            this.lblZahl2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdRechnen
            // 
            this.cmdRechnen.Location = new System.Drawing.Point(197, 112);
            this.cmdRechnen.Name = "cmdRechnen";
            this.cmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen.TabIndex = 0;
            this.cmdRechnen.Text = "Rechnen";
            this.cmdRechnen.UseVisualStyleBackColor = true;
            this.cmdRechnen.Click += new System.EventHandler(this.cmdRechnen_Click);
            // 
            // txtInputZahl1
            // 
            this.txtInputZahl1.Location = new System.Drawing.Point(77, 77);
            this.txtInputZahl1.Name = "txtInputZahl1";
            this.txtInputZahl1.Size = new System.Drawing.Size(100, 20);
            this.txtInputZahl1.TabIndex = 1;
            // 
            // txtInputZahl2
            // 
            this.txtInputZahl2.Location = new System.Drawing.Point(77, 114);
            this.txtInputZahl2.Name = "txtInputZahl2";
            this.txtInputZahl2.Size = new System.Drawing.Size(100, 20);
            this.txtInputZahl2.TabIndex = 2;
            // 
            // lblZahl1
            // 
            this.lblZahl1.AutoSize = true;
            this.lblZahl1.Location = new System.Drawing.Point(25, 80);
            this.lblZahl1.Name = "lblZahl1";
            this.lblZahl1.Size = new System.Drawing.Size(37, 13);
            this.lblZahl1.TabIndex = 3;
            this.lblZahl1.Text = "Zahl 1";
            // 
            // lblZahl2
            // 
            this.lblZahl2.AutoSize = true;
            this.lblZahl2.Location = new System.Drawing.Point(25, 117);
            this.lblZahl2.Name = "lblZahl2";
            this.lblZahl2.Size = new System.Drawing.Size(37, 13);
            this.lblZahl2.TabIndex = 4;
            this.lblZahl2.Text = "Zahl 2";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(14, 171);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(51, 13);
            this.lblErgebnis.TabIndex = 5;
            this.lblErgebnis.Text = "Ergebnis:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 262);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.lblZahl2);
            this.Controls.Add(this.lblZahl1);
            this.Controls.Add(this.txtInputZahl2);
            this.Controls.Add(this.txtInputZahl1);
            this.Controls.Add(this.cmdRechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRechnen;
        private System.Windows.Forms.TextBox txtInputZahl1;
        private System.Windows.Forms.TextBox txtInputZahl2;
        private System.Windows.Forms.Label lblZahl1;
        private System.Windows.Forms.Label lblZahl2;
        private System.Windows.Forms.Label lblErgebnis;
    }
}

