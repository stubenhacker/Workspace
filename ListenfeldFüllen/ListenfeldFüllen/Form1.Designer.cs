namespace ListenfeldFüllen
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
            this.lstSpeisen = new System.Windows.Forms.ListBox();
            this.cmdAnzeigen = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.lblAnzeigen2 = new System.Windows.Forms.Label();
            this.lblAnzeigen3 = new System.Windows.Forms.Label();
            this.lblAnzeigen4 = new System.Windows.Forms.Label();
            this.lblAnzeigen5 = new System.Windows.Forms.Label();
            this.cmdSelectedChanged = new System.Windows.Forms.Button();
            this.lblAnzeigen6 = new System.Windows.Forms.Label();
            this.lblAnzeigen7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSpeisen
            // 
            this.lstSpeisen.FormattingEnabled = true;
            this.lstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.lstSpeisen.Name = "lstSpeisen";
            this.lstSpeisen.Size = new System.Drawing.Size(120, 43);
            this.lstSpeisen.TabIndex = 0;
            this.lstSpeisen.SelectedIndexChanged += new System.EventHandler(this.lstSpeisen_SelectedIndexChanged);
            // 
            // cmdAnzeigen
            // 
            this.cmdAnzeigen.Location = new System.Drawing.Point(197, 12);
            this.cmdAnzeigen.Name = "cmdAnzeigen";
            this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.cmdAnzeigen.TabIndex = 1;
            this.cmdAnzeigen.Text = "Anzeigen";
            this.cmdAnzeigen.UseVisualStyleBackColor = true;
            this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 127);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 2;
            // 
            // lblAnzeigen2
            // 
            this.lblAnzeigen2.AutoSize = true;
            this.lblAnzeigen2.Location = new System.Drawing.Point(12, 167);
            this.lblAnzeigen2.Name = "lblAnzeigen2";
            this.lblAnzeigen2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen2.TabIndex = 3;
            // 
            // lblAnzeigen3
            // 
            this.lblAnzeigen3.AutoSize = true;
            this.lblAnzeigen3.Location = new System.Drawing.Point(12, 203);
            this.lblAnzeigen3.Name = "lblAnzeigen3";
            this.lblAnzeigen3.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen3.TabIndex = 4;
            // 
            // lblAnzeigen4
            // 
            this.lblAnzeigen4.AutoSize = true;
            this.lblAnzeigen4.Location = new System.Drawing.Point(12, 243);
            this.lblAnzeigen4.Name = "lblAnzeigen4";
            this.lblAnzeigen4.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen4.TabIndex = 5;
            // 
            // lblAnzeigen5
            // 
            this.lblAnzeigen5.AutoSize = true;
            this.lblAnzeigen5.Location = new System.Drawing.Point(181, 270);
            this.lblAnzeigen5.Name = "lblAnzeigen5";
            this.lblAnzeigen5.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen5.TabIndex = 6;
            // 
            // cmdSelectedChanged
            // 
            this.cmdSelectedChanged.Location = new System.Drawing.Point(310, 12);
            this.cmdSelectedChanged.Name = "cmdSelectedChanged";
            this.cmdSelectedChanged.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectedChanged.TabIndex = 7;
            this.cmdSelectedChanged.Text = "Ereignis";
            this.cmdSelectedChanged.UseVisualStyleBackColor = true;
            this.cmdSelectedChanged.Click += new System.EventHandler(this.cmdSelectedChanged_Click);
            // 
            // lblAnzeigen6
            // 
            this.lblAnzeigen6.AutoSize = true;
            this.lblAnzeigen6.Location = new System.Drawing.Point(307, 58);
            this.lblAnzeigen6.Name = "lblAnzeigen6";
            this.lblAnzeigen6.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen6.TabIndex = 8;
            // 
            // lblAnzeigen7
            // 
            this.lblAnzeigen7.AutoSize = true;
            this.lblAnzeigen7.Location = new System.Drawing.Point(307, 108);
            this.lblAnzeigen7.Name = "lblAnzeigen7";
            this.lblAnzeigen7.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen7.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 380);
            this.Controls.Add(this.lblAnzeigen7);
            this.Controls.Add(this.lblAnzeigen6);
            this.Controls.Add(this.cmdSelectedChanged);
            this.Controls.Add(this.lblAnzeigen5);
            this.Controls.Add(this.lblAnzeigen4);
            this.Controls.Add(this.lblAnzeigen3);
            this.Controls.Add(this.lblAnzeigen2);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdAnzeigen);
            this.Controls.Add(this.lstSpeisen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSpeisen;
        private System.Windows.Forms.Button cmdAnzeigen;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Label lblAnzeigen2;
        private System.Windows.Forms.Label lblAnzeigen3;
        private System.Windows.Forms.Label lblAnzeigen4;
        private System.Windows.Forms.Label lblAnzeigen5;
        private System.Windows.Forms.Button cmdSelectedChanged;
        private System.Windows.Forms.Label lblAnzeigen6;
        private System.Windows.Forms.Label lblAnzeigen7;
    }
}

