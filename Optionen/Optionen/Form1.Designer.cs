namespace Optionen
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
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.cmdRedRb = new System.Windows.Forms.Button();
            this.lblAnzeigen1 = new System.Windows.Forms.Label();
            this.lblAnzeigen2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(186, 12);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(75, 23);
            this.cmdCheck.TabIndex = 0;
            this.cmdCheck.Text = "Prüfen";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(191, 83);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(42, 17);
            this.rbRed.TabIndex = 1;
            this.rbRed.Text = "Rot";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbColorChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(191, 115);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(48, 17);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.Text = "Grün";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbColorChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Location = new System.Drawing.Point(191, 147);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blau";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbColorChanged);
            // 
            // cmdRedRb
            // 
            this.cmdRedRb.Location = new System.Drawing.Point(186, 196);
            this.cmdRedRb.Name = "cmdRedRb";
            this.cmdRedRb.Size = new System.Drawing.Size(75, 23);
            this.cmdRedRb.TabIndex = 4;
            this.cmdRedRb.Text = "Rot schalten";
            this.cmdRedRb.UseVisualStyleBackColor = true;
            this.cmdRedRb.Click += new System.EventHandler(this.cmdRedRb_Click);
            // 
            // lblAnzeigen1
            // 
            this.lblAnzeigen1.AutoSize = true;
            this.lblAnzeigen1.Location = new System.Drawing.Point(28, 22);
            this.lblAnzeigen1.Name = "lblAnzeigen1";
            this.lblAnzeigen1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen1.TabIndex = 5;
            // 
            // lblAnzeigen2
            // 
            this.lblAnzeigen2.AutoSize = true;
            this.lblAnzeigen2.Location = new System.Drawing.Point(28, 201);
            this.lblAnzeigen2.Name = "lblAnzeigen2";
            this.lblAnzeigen2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblAnzeigen2);
            this.Controls.Add(this.lblAnzeigen1);
            this.Controls.Add(this.cmdRedRb);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.cmdCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.Button cmdRedRb;
        private System.Windows.Forms.Label lblAnzeigen1;
        private System.Windows.Forms.Label lblAnzeigen2;
    }
}

