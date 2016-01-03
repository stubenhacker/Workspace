namespace DateiVerzeichnisListe
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
            this.cmdDateiListe = new System.Windows.Forms.Button();
            this.cmdSystemeinträge = new System.Windows.Forms.Button();
            this.cmdInVerzeichnis = new System.Windows.Forms.Button();
            this.cmdNachOben = new System.Windows.Forms.Button();
            this.lstAnzeigen = new System.Windows.Forms.ListBox();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.lblAnzeigenInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDateiListe
            // 
            this.cmdDateiListe.Location = new System.Drawing.Point(82, 12);
            this.cmdDateiListe.Name = "cmdDateiListe";
            this.cmdDateiListe.Size = new System.Drawing.Size(75, 23);
            this.cmdDateiListe.TabIndex = 0;
            this.cmdDateiListe.Text = "Dateiliste";
            this.cmdDateiListe.UseVisualStyleBackColor = true;
            this.cmdDateiListe.Click += new System.EventHandler(this.cmdDateiListe_Click);
            // 
            // cmdSystemeinträge
            // 
            this.cmdSystemeinträge.Location = new System.Drawing.Point(250, 12);
            this.cmdSystemeinträge.Name = "cmdSystemeinträge";
            this.cmdSystemeinträge.Size = new System.Drawing.Size(90, 23);
            this.cmdSystemeinträge.TabIndex = 1;
            this.cmdSystemeinträge.Text = "Systemeinträge";
            this.cmdSystemeinträge.UseVisualStyleBackColor = true;
            this.cmdSystemeinträge.Click += new System.EventHandler(this.Systemeinträge_Click);
            // 
            // cmdInVerzeichnis
            // 
            this.cmdInVerzeichnis.Location = new System.Drawing.Point(414, 12);
            this.cmdInVerzeichnis.Name = "cmdInVerzeichnis";
            this.cmdInVerzeichnis.Size = new System.Drawing.Size(87, 23);
            this.cmdInVerzeichnis.TabIndex = 2;
            this.cmdInVerzeichnis.Text = "in Verzeichnis";
            this.cmdInVerzeichnis.UseVisualStyleBackColor = true;
            this.cmdInVerzeichnis.Click += new System.EventHandler(this.cmdInVerzeichnis_Click);
            // 
            // cmdNachOben
            // 
            this.cmdNachOben.Location = new System.Drawing.Point(583, 12);
            this.cmdNachOben.Name = "cmdNachOben";
            this.cmdNachOben.Size = new System.Drawing.Size(75, 23);
            this.cmdNachOben.TabIndex = 3;
            this.cmdNachOben.Text = "nach oben";
            this.cmdNachOben.UseVisualStyleBackColor = true;
            this.cmdNachOben.Click += new System.EventHandler(this.cmdNachOben_Click);
            // 
            // lstAnzeigen
            // 
            this.lstAnzeigen.FormattingEnabled = true;
            this.lstAnzeigen.Location = new System.Drawing.Point(12, 103);
            this.lstAnzeigen.Name = "lstAnzeigen";
            this.lstAnzeigen.Size = new System.Drawing.Size(727, 212);
            this.lstAnzeigen.TabIndex = 4;
            this.lstAnzeigen.SelectedIndexChanged += new System.EventHandler(this.lstAnzeigen_SelectedIndexChanged);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 59);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 5;
            // 
            // lblAnzeigenInfo
            // 
            this.lblAnzeigenInfo.AutoSize = true;
            this.lblAnzeigenInfo.Location = new System.Drawing.Point(22, 329);
            this.lblAnzeigenInfo.Name = "lblAnzeigenInfo";
            this.lblAnzeigenInfo.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigenInfo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 424);
            this.Controls.Add(this.lblAnzeigenInfo);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.lstAnzeigen);
            this.Controls.Add(this.cmdNachOben);
            this.Controls.Add(this.cmdInVerzeichnis);
            this.Controls.Add(this.cmdSystemeinträge);
            this.Controls.Add(this.cmdDateiListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDateiListe;
        private System.Windows.Forms.Button cmdSystemeinträge;
        private System.Windows.Forms.Button cmdInVerzeichnis;
        private System.Windows.Forms.Button cmdNachOben;
        private System.Windows.Forms.ListBox lstAnzeigen;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Label lblAnzeigenInfo;
    }
}

