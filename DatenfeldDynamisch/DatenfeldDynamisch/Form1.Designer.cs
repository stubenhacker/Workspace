namespace DatenfeldDynamisch
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
            this.cmdFeldOriginal = new System.Windows.Forms.Button();
            this.cmdFeldNeu1 = new System.Windows.Forms.Button();
            this.lstFeld = new System.Windows.Forms.ListBox();
            this.numFeldGroesse = new System.Windows.Forms.NumericUpDown();
            this.cmdFeldNeu2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFeldGroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFeldOriginal
            // 
            this.cmdFeldOriginal.Location = new System.Drawing.Point(412, 12);
            this.cmdFeldOriginal.Name = "cmdFeldOriginal";
            this.cmdFeldOriginal.Size = new System.Drawing.Size(75, 23);
            this.cmdFeldOriginal.TabIndex = 0;
            this.cmdFeldOriginal.Text = "Feld original";
            this.cmdFeldOriginal.UseVisualStyleBackColor = true;
            this.cmdFeldOriginal.Click += new System.EventHandler(this.cmdFeldOriginal_Click);
            // 
            // cmdFeldNeu1
            // 
            this.cmdFeldNeu1.Location = new System.Drawing.Point(412, 43);
            this.cmdFeldNeu1.Name = "cmdFeldNeu1";
            this.cmdFeldNeu1.Size = new System.Drawing.Size(75, 23);
            this.cmdFeldNeu1.TabIndex = 1;
            this.cmdFeldNeu1.Text = "Feld neu 1";
            this.cmdFeldNeu1.UseVisualStyleBackColor = true;
            this.cmdFeldNeu1.Click += new System.EventHandler(this.cmdFeldNeu1_Click);
            // 
            // lstFeld
            // 
            this.lstFeld.FormattingEnabled = true;
            this.lstFeld.Location = new System.Drawing.Point(39, 12);
            this.lstFeld.Name = "lstFeld";
            this.lstFeld.Size = new System.Drawing.Size(120, 238);
            this.lstFeld.TabIndex = 2;
            // 
            // numFeldGroesse
            // 
            this.numFeldGroesse.Location = new System.Drawing.Point(412, 146);
            this.numFeldGroesse.Name = "numFeldGroesse";
            this.numFeldGroesse.Size = new System.Drawing.Size(75, 20);
            this.numFeldGroesse.TabIndex = 3;
            // 
            // cmdFeldNeu2
            // 
            this.cmdFeldNeu2.Location = new System.Drawing.Point(412, 186);
            this.cmdFeldNeu2.Name = "cmdFeldNeu2";
            this.cmdFeldNeu2.Size = new System.Drawing.Size(75, 23);
            this.cmdFeldNeu2.TabIndex = 4;
            this.cmdFeldNeu2.Text = "Feld neu 2";
            this.cmdFeldNeu2.UseVisualStyleBackColor = true;
            this.cmdFeldNeu2.Click += new System.EventHandler(this.cmdFeldNeu2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 262);
            this.Controls.Add(this.cmdFeldNeu2);
            this.Controls.Add(this.numFeldGroesse);
            this.Controls.Add(this.lstFeld);
            this.Controls.Add(this.cmdFeldNeu1);
            this.Controls.Add(this.cmdFeldOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFeldGroesse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFeldOriginal;
        private System.Windows.Forms.Button cmdFeldNeu1;
        private System.Windows.Forms.ListBox lstFeld;
        private System.Windows.Forms.NumericUpDown numFeldGroesse;
        private System.Windows.Forms.Button cmdFeldNeu2;
    }
}

