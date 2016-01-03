namespace DatenfelderEindimensional
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
            this.lstFeld = new System.Windows.Forms.ListBox();
            this.cmdAnzeigen1 = new System.Windows.Forms.Button();
            this.cmdAnzeigen2 = new System.Windows.Forms.Button();
            this.cmdAnzeigen3 = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFeld
            // 
            this.lstFeld.FormattingEnabled = true;
            this.lstFeld.Location = new System.Drawing.Point(12, 12);
            this.lstFeld.Name = "lstFeld";
            this.lstFeld.Size = new System.Drawing.Size(120, 199);
            this.lstFeld.TabIndex = 0;
            // 
            // cmdAnzeigen1
            // 
            this.cmdAnzeigen1.Location = new System.Drawing.Point(188, 12);
            this.cmdAnzeigen1.Name = "cmdAnzeigen1";
            this.cmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen1.TabIndex = 1;
            this.cmdAnzeigen1.Text = "Anzeigen 1";
            this.cmdAnzeigen1.UseVisualStyleBackColor = true;
            this.cmdAnzeigen1.Click += new System.EventHandler(this.cmdAnzeigen1_Click);
            // 
            // cmdAnzeigen2
            // 
            this.cmdAnzeigen2.Location = new System.Drawing.Point(188, 53);
            this.cmdAnzeigen2.Name = "cmdAnzeigen2";
            this.cmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen2.TabIndex = 2;
            this.cmdAnzeigen2.Text = "Anzeigen 2";
            this.cmdAnzeigen2.UseVisualStyleBackColor = true;
            this.cmdAnzeigen2.Click += new System.EventHandler(this.cmdAnzeigen2_Click);
            // 
            // cmdAnzeigen3
            // 
            this.cmdAnzeigen3.Location = new System.Drawing.Point(188, 100);
            this.cmdAnzeigen3.Name = "cmdAnzeigen3";
            this.cmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen3.TabIndex = 3;
            this.cmdAnzeigen3.Text = "Anzeigen 3";
            this.cmdAnzeigen3.UseVisualStyleBackColor = true;
            this.cmdAnzeigen3.Click += new System.EventHandler(this.cmdAnzeigen3_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 224);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdAnzeigen3);
            this.Controls.Add(this.cmdAnzeigen2);
            this.Controls.Add(this.cmdAnzeigen1);
            this.Controls.Add(this.lstFeld);
            this.Name = "Form1";
            this.Text = "Datenfelder, eindimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFeld;
        private System.Windows.Forms.Button cmdAnzeigen1;
        private System.Windows.Forms.Button cmdAnzeigen2;
        private System.Windows.Forms.Button cmdAnzeigen3;
        private System.Windows.Forms.Label lblAnzeigen;
    }
}

