namespace KlasseObjekt
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
            this.cmdAnzeigen = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdReferenzZuweisen = new System.Windows.Forms.Button();
            this.cmdReferenzVergleichen = new System.Windows.Forms.Button();
            this.cmdObjektVergleich = new System.Windows.Forms.Button();
            this.cmdKlasseErmitteln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAnzeigen
            // 
            this.cmdAnzeigen.Location = new System.Drawing.Point(177, 30);
            this.cmdAnzeigen.Name = "cmdAnzeigen";
            this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen.TabIndex = 0;
            this.cmdAnzeigen.Text = "Anzeigen";
            this.cmdAnzeigen.UseVisualStyleBackColor = true;
            this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 53);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 1;
            // 
            // cmdReferenzZuweisen
            // 
            this.cmdReferenzZuweisen.Location = new System.Drawing.Point(177, 83);
            this.cmdReferenzZuweisen.Name = "cmdReferenzZuweisen";
            this.cmdReferenzZuweisen.Size = new System.Drawing.Size(95, 23);
            this.cmdReferenzZuweisen.TabIndex = 2;
            this.cmdReferenzZuweisen.Text = "Ref. zuweisen";
            this.cmdReferenzZuweisen.UseVisualStyleBackColor = true;
            this.cmdReferenzZuweisen.Click += new System.EventHandler(this.cmdReferenzZuweisen_Click);
            // 
            // cmdReferenzVergleichen
            // 
            this.cmdReferenzVergleichen.Location = new System.Drawing.Point(177, 112);
            this.cmdReferenzVergleichen.Name = "cmdReferenzVergleichen";
            this.cmdReferenzVergleichen.Size = new System.Drawing.Size(95, 23);
            this.cmdReferenzVergleichen.TabIndex = 3;
            this.cmdReferenzVergleichen.Text = "Ref. vergleichen";
            this.cmdReferenzVergleichen.UseVisualStyleBackColor = true;
            this.cmdReferenzVergleichen.Click += new System.EventHandler(this.cmdReferenzVergleichen_Click);
            // 
            // cmdObjektVergleich
            // 
            this.cmdObjektVergleich.Location = new System.Drawing.Point(177, 141);
            this.cmdObjektVergleich.Name = "cmdObjektVergleich";
            this.cmdObjektVergleich.Size = new System.Drawing.Size(95, 23);
            this.cmdObjektVergleich.TabIndex = 4;
            this.cmdObjektVergleich.Text = "Obj. Vergleich";
            this.cmdObjektVergleich.UseVisualStyleBackColor = true;
            this.cmdObjektVergleich.Click += new System.EventHandler(this.cmdObjektVergleich_Click);
            // 
            // cmdKlasseErmitteln
            // 
            this.cmdKlasseErmitteln.Location = new System.Drawing.Point(177, 179);
            this.cmdKlasseErmitteln.Name = "cmdKlasseErmitteln";
            this.cmdKlasseErmitteln.Size = new System.Drawing.Size(95, 23);
            this.cmdKlasseErmitteln.TabIndex = 5;
            this.cmdKlasseErmitteln.Text = "Klasse ermitteln";
            this.cmdKlasseErmitteln.UseVisualStyleBackColor = true;
            this.cmdKlasseErmitteln.Click += new System.EventHandler(this.cmdKlasseErmitteln_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdKlasseErmitteln);
            this.Controls.Add(this.cmdObjektVergleich);
            this.Controls.Add(this.cmdReferenzVergleichen);
            this.Controls.Add(this.cmdReferenzZuweisen);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Klasse, Objekt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAnzeigen;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.Button cmdReferenzZuweisen;
        private System.Windows.Forms.Button cmdReferenzVergleichen;
        private System.Windows.Forms.Button cmdObjektVergleich;
        private System.Windows.Forms.Button cmdKlasseErmitteln;
    }
}

