namespace GenerischeTypen
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
            this.cmdListString = new System.Windows.Forms.Button();
            this.lstAnzeige1 = new System.Windows.Forms.ListBox();
            this.cmdListLand = new System.Windows.Forms.Button();
            this.cmdDictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdListString
            // 
            this.cmdListString.Location = new System.Drawing.Point(12, 12);
            this.cmdListString.Name = "cmdListString";
            this.cmdListString.Size = new System.Drawing.Size(75, 23);
            this.cmdListString.TabIndex = 0;
            this.cmdListString.Text = "List String";
            this.cmdListString.UseVisualStyleBackColor = true;
            this.cmdListString.Click += new System.EventHandler(this.cmdListString_Click);
            // 
            // lstAnzeige1
            // 
            this.lstAnzeige1.FormattingEnabled = true;
            this.lstAnzeige1.Location = new System.Drawing.Point(12, 52);
            this.lstAnzeige1.Name = "lstAnzeige1";
            this.lstAnzeige1.Size = new System.Drawing.Size(833, 368);
            this.lstAnzeige1.TabIndex = 1;
            // 
            // cmdListLand
            // 
            this.cmdListLand.Location = new System.Drawing.Point(225, 12);
            this.cmdListLand.Name = "cmdListLand";
            this.cmdListLand.Size = new System.Drawing.Size(75, 23);
            this.cmdListLand.TabIndex = 2;
            this.cmdListLand.Text = "List Land";
            this.cmdListLand.UseVisualStyleBackColor = true;
            this.cmdListLand.Click += new System.EventHandler(this.cmdListLand_Click);
            // 
            // cmdDictionary
            // 
            this.cmdDictionary.Location = new System.Drawing.Point(612, 12);
            this.cmdDictionary.Name = "cmdDictionary";
            this.cmdDictionary.Size = new System.Drawing.Size(75, 23);
            this.cmdDictionary.TabIndex = 3;
            this.cmdDictionary.Text = "Dictionary";
            this.cmdDictionary.UseVisualStyleBackColor = true;
            this.cmdDictionary.Click += new System.EventHandler(this.cmdDictionary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 448);
            this.Controls.Add(this.cmdDictionary);
            this.Controls.Add(this.cmdListLand);
            this.Controls.Add(this.lstAnzeige1);
            this.Controls.Add(this.cmdListString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdListString;
        private System.Windows.Forms.ListBox lstAnzeige1;
        private System.Windows.Forms.Button cmdListLand;
        private System.Windows.Forms.Button cmdDictionary;
    }
}

