namespace DatenfeldMehrdimensional
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
            this.lstOrt1 = new System.Windows.Forms.ListBox();
            this.lstOrt2 = new System.Windows.Forms.ListBox();
            this.lstOrt3 = new System.Windows.Forms.ListBox();
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.cmdInit = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.lblAnzeigen2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOrt1
            // 
            this.lstOrt1.FormattingEnabled = true;
            this.lstOrt1.Location = new System.Drawing.Point(25, 25);
            this.lstOrt1.Name = "lstOrt1";
            this.lstOrt1.Size = new System.Drawing.Size(63, 199);
            this.lstOrt1.TabIndex = 0;
            this.lstOrt1.Click += new System.EventHandler(this.lstOrtListe_Click);
            // 
            // lstOrt2
            // 
            this.lstOrt2.FormattingEnabled = true;
            this.lstOrt2.Location = new System.Drawing.Point(121, 25);
            this.lstOrt2.Name = "lstOrt2";
            this.lstOrt2.Size = new System.Drawing.Size(63, 199);
            this.lstOrt2.TabIndex = 1;
            this.lstOrt2.Click += new System.EventHandler(this.lstOrtListe_Click);
            // 
            // lstOrt3
            // 
            this.lstOrt3.FormattingEnabled = true;
            this.lstOrt3.Location = new System.Drawing.Point(220, 25);
            this.lstOrt3.Name = "lstOrt3";
            this.lstOrt3.Size = new System.Drawing.Size(63, 199);
            this.lstOrt3.TabIndex = 2;
            this.lstOrt3.Click += new System.EventHandler(this.lstOrtListe_Click);
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(408, 25);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeige.TabIndex = 3;
            this.cmdAnzeige.Text = "Anzeige";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(408, 72);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(75, 23);
            this.cmdInit.TabIndex = 4;
            this.cmdInit.Text = "Initialisieren";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(325, 211);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 5;
            // 
            // lblAnzeigen2
            // 
            this.lblAnzeigen2.AutoSize = true;
            this.lblAnzeigen2.Location = new System.Drawing.Point(595, 25);
            this.lblAnzeigen2.Name = "lblAnzeigen2";
            this.lblAnzeigen2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 262);
            this.Controls.Add(this.lblAnzeigen2);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.lstOrt3);
            this.Controls.Add(this.lstOrt2);
            this.Controls.Add(this.lstOrt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrt1;
        private System.Windows.Forms.ListBox lstOrt2;
        private System.Windows.Forms.ListBox lstOrt3;
        private System.Windows.Forms.Button cmdAnzeige;
        private System.Windows.Forms.Button cmdInit;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Label lblAnzeigen2;
    }
}

