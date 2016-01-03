namespace ÜForSchleifen
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
            this.cmdSchleife1 = new System.Windows.Forms.Button();
            this.lblAnzeigeSchleife = new System.Windows.Forms.Label();
            this.cmdSchleife2 = new System.Windows.Forms.Button();
            this.cmdSchleifen3 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdSchleife1
            // 
            this.cmdSchleife1.Location = new System.Drawing.Point(288, 12);
            this.cmdSchleife1.Name = "cmdSchleife1";
            this.cmdSchleife1.Size = new System.Drawing.Size(75, 23);
            this.cmdSchleife1.TabIndex = 0;
            this.cmdSchleife1.Text = "Schleife 1";
            this.cmdSchleife1.UseVisualStyleBackColor = true;
            this.cmdSchleife1.Click += new System.EventHandler(this.cmdSchleife1_Click);
            // 
            // lblAnzeigeSchleife
            // 
            this.lblAnzeigeSchleife.AutoSize = true;
            this.lblAnzeigeSchleife.Location = new System.Drawing.Point(25, 17);
            this.lblAnzeigeSchleife.Name = "lblAnzeigeSchleife";
            this.lblAnzeigeSchleife.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigeSchleife.TabIndex = 1;
            // 
            // cmdSchleife2
            // 
            this.cmdSchleife2.Location = new System.Drawing.Point(288, 41);
            this.cmdSchleife2.Name = "cmdSchleife2";
            this.cmdSchleife2.Size = new System.Drawing.Size(75, 23);
            this.cmdSchleife2.TabIndex = 2;
            this.cmdSchleife2.Text = "Schleife 2";
            this.cmdSchleife2.UseVisualStyleBackColor = true;
            this.cmdSchleife2.Click += new System.EventHandler(this.cmdSchleife2_Click);
            // 
            // cmdSchleifen3
            // 
            this.cmdSchleifen3.Location = new System.Drawing.Point(288, 70);
            this.cmdSchleifen3.Name = "cmdSchleifen3";
            this.cmdSchleifen3.Size = new System.Drawing.Size(75, 23);
            this.cmdSchleifen3.TabIndex = 3;
            this.cmdSchleifen3.Text = "Schleifen 3";
            this.cmdSchleifen3.UseVisualStyleBackColor = true;
            this.cmdSchleifen3.Click += new System.EventHandler(this.cmdSchleifen3_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(182, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 330);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmdSchleifen3);
            this.Controls.Add(this.cmdSchleife2);
            this.Controls.Add(this.lblAnzeigeSchleife);
            this.Controls.Add(this.cmdSchleife1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSchleife1;
        private System.Windows.Forms.Label lblAnzeigeSchleife;
        private System.Windows.Forms.Button cmdSchleife2;
        private System.Windows.Forms.Button cmdSchleifen3;
        private System.Windows.Forms.TextBox txtInput;
    }
}

