namespace RekursiverAufruf
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
            this.cmdSchleife = new System.Windows.Forms.Button();
            this.cmdRekursion = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.cmdRekursion2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSchleife
            // 
            this.cmdSchleife.Location = new System.Drawing.Point(197, 12);
            this.cmdSchleife.Name = "cmdSchleife";
            this.cmdSchleife.Size = new System.Drawing.Size(75, 23);
            this.cmdSchleife.TabIndex = 0;
            this.cmdSchleife.Text = "Schleife";
            this.cmdSchleife.UseVisualStyleBackColor = true;
            this.cmdSchleife.Click += new System.EventHandler(this.cmdSchleife_Click);
            // 
            // cmdRekursion
            // 
            this.cmdRekursion.Location = new System.Drawing.Point(197, 41);
            this.cmdRekursion.Name = "cmdRekursion";
            this.cmdRekursion.Size = new System.Drawing.Size(75, 23);
            this.cmdRekursion.TabIndex = 1;
            this.cmdRekursion.Text = "Rekursion";
            this.cmdRekursion.UseVisualStyleBackColor = true;
            this.cmdRekursion.Click += new System.EventHandler(this.cmdRekursion_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 22);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 2;
            // 
            // cmdRekursion2
            // 
            this.cmdRekursion2.Location = new System.Drawing.Point(197, 70);
            this.cmdRekursion2.Name = "cmdRekursion2";
            this.cmdRekursion2.Size = new System.Drawing.Size(75, 23);
            this.cmdRekursion2.TabIndex = 3;
            this.cmdRekursion2.Text = "Rekursion 2";
            this.cmdRekursion2.UseVisualStyleBackColor = true;
            this.cmdRekursion2.Click += new System.EventHandler(this.cmdRekursion2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdRekursion2);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdRekursion);
            this.Controls.Add(this.cmdSchleife);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSchleife;
        private System.Windows.Forms.Button cmdRekursion;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Button cmdRekursion2;
    }
}

