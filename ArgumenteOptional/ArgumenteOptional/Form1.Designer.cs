namespace ArgumenteOptional
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
            this.cmdAnzeigen1 = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.cmdAnzeigen2 = new System.Windows.Forms.Button();
            this.cmdAnzeigen3 = new System.Windows.Forms.Button();
            this.cmdAnzeigen4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAnzeigen1
            // 
            this.cmdAnzeigen1.Location = new System.Drawing.Point(183, 12);
            this.cmdAnzeigen1.Name = "cmdAnzeigen1";
            this.cmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen1.TabIndex = 0;
            this.cmdAnzeigen1.Text = "Anzeigen 1";
            this.cmdAnzeigen1.UseVisualStyleBackColor = true;
            this.cmdAnzeigen1.Click += new System.EventHandler(this.cmdAnzeigen1_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 17);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 1;
            // 
            // cmdAnzeigen2
            // 
            this.cmdAnzeigen2.Location = new System.Drawing.Point(183, 59);
            this.cmdAnzeigen2.Name = "cmdAnzeigen2";
            this.cmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen2.TabIndex = 2;
            this.cmdAnzeigen2.Text = "Anzeigen 2";
            this.cmdAnzeigen2.UseVisualStyleBackColor = true;
            this.cmdAnzeigen2.Click += new System.EventHandler(this.cmdAnzeigen2_Click);
            // 
            // cmdAnzeigen3
            // 
            this.cmdAnzeigen3.Location = new System.Drawing.Point(183, 109);
            this.cmdAnzeigen3.Name = "cmdAnzeigen3";
            this.cmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen3.TabIndex = 3;
            this.cmdAnzeigen3.Text = "Anzeigen 3";
            this.cmdAnzeigen3.UseVisualStyleBackColor = true;
            this.cmdAnzeigen3.Click += new System.EventHandler(this.cmdAnzeigen3_Click);
            // 
            // cmdAnzeigen4
            // 
            this.cmdAnzeigen4.Location = new System.Drawing.Point(183, 156);
            this.cmdAnzeigen4.Name = "cmdAnzeigen4";
            this.cmdAnzeigen4.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen4.TabIndex = 4;
            this.cmdAnzeigen4.Text = "Anzeigen 4";
            this.cmdAnzeigen4.UseVisualStyleBackColor = true;
            this.cmdAnzeigen4.Click += new System.EventHandler(this.cmdAnzeigen4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdAnzeigen4);
            this.Controls.Add(this.cmdAnzeigen3);
            this.Controls.Add(this.cmdAnzeigen2);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdAnzeigen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAnzeigen1;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Button cmdAnzeigen2;
        private System.Windows.Forms.Button cmdAnzeigen3;
        private System.Windows.Forms.Button cmdAnzeigen4;
    }
}

