namespace Quersumme
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
            this.cmdSumme1 = new System.Windows.Forms.Button();
            this.txtInputZahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdRemoveDuplicates = new System.Windows.Forms.Button();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdSumme1
            // 
            this.cmdSumme1.Location = new System.Drawing.Point(555, 30);
            this.cmdSumme1.Name = "cmdSumme1";
            this.cmdSumme1.Size = new System.Drawing.Size(88, 23);
            this.cmdSumme1.TabIndex = 0;
            this.cmdSumme1.Text = "Quersumme 1";
            this.cmdSumme1.UseVisualStyleBackColor = true;
            this.cmdSumme1.Click += new System.EventHandler(this.cmdSumme1_Click);
            // 
            // txtInputZahl
            // 
            this.txtInputZahl.Location = new System.Drawing.Point(103, 33);
            this.txtInputZahl.Name = "txtInputZahl";
            this.txtInputZahl.Size = new System.Drawing.Size(314, 20);
            this.txtInputZahl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zahl";
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(26, 96);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 3;
            // 
            // cmdRemoveDuplicates
            // 
            this.cmdRemoveDuplicates.Location = new System.Drawing.Point(555, 183);
            this.cmdRemoveDuplicates.Name = "cmdRemoveDuplicates";
            this.cmdRemoveDuplicates.Size = new System.Drawing.Size(124, 23);
            this.cmdRemoveDuplicates.TabIndex = 4;
            this.cmdRemoveDuplicates.Text = "button1";
            this.cmdRemoveDuplicates.UseVisualStyleBackColor = true;
            this.cmdRemoveDuplicates.Click += new System.EventHandler(this.cmdRemoveDuplicates_Click);
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(103, 185);
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(314, 20);
            this.txtInputString.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtInputString);
            this.Controls.Add(this.cmdRemoveDuplicates);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputZahl);
            this.Controls.Add(this.cmdSumme1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSumme1;
        private System.Windows.Forms.TextBox txtInputZahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.Button cmdRemoveDuplicates;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.TextBox textBox1;
    }
}

