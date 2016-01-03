namespace ÜEnabled
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
            this.lstOrte = new System.Windows.Forms.ListBox();
            this.cmdDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrte
            // 
            this.lstOrte.FormattingEnabled = true;
            this.lstOrte.Location = new System.Drawing.Point(24, 32);
            this.lstOrte.Name = "lstOrte";
            this.lstOrte.Size = new System.Drawing.Size(120, 147);
            this.lstOrte.TabIndex = 0;
            this.lstOrte.SelectedIndexChanged += new System.EventHandler(this.lstOrte_SelectedIndexChanged);
        
            // 
            // cmdDeleteItem
            // 
            this.cmdDeleteItem.Enabled = false;
            this.cmdDeleteItem.Location = new System.Drawing.Point(166, 32);
            this.cmdDeleteItem.Name = "cmdDeleteItem";
            this.cmdDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteItem.TabIndex = 1;
            this.cmdDeleteItem.Text = "Löschen";
            this.cmdDeleteItem.UseVisualStyleBackColor = true;
            this.cmdDeleteItem.Click += new System.EventHandler(this.cmdDeleteItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdDeleteItem);
            this.Controls.Add(this.lstOrte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrte;
        private System.Windows.Forms.Button cmdDeleteItem;
    }
}

