namespace Zahlenraten
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
            this.cmdCreateRandom = new System.Windows.Forms.Button();
            this.cmdCheckNumber = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCreateRandom
            // 
            this.cmdCreateRandom.Location = new System.Drawing.Point(255, 66);
            this.cmdCreateRandom.Name = "cmdCreateRandom";
            this.cmdCreateRandom.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateRandom.TabIndex = 0;
            this.cmdCreateRandom.Text = "Erzeugen";
            this.cmdCreateRandom.UseVisualStyleBackColor = true;
            this.cmdCreateRandom.Click += new System.EventHandler(this.cmdCreateRandom_Click);
            // 
            // cmdCheckNumber
            // 
            this.cmdCheckNumber.Location = new System.Drawing.Point(255, 112);
            this.cmdCheckNumber.Name = "cmdCheckNumber";
            this.cmdCheckNumber.Size = new System.Drawing.Size(75, 23);
            this.cmdCheckNumber.TabIndex = 1;
            this.cmdCheckNumber.Text = "Prüfen";
            this.cmdCheckNumber.UseVisualStyleBackColor = true;
            this.cmdCheckNumber.Click += new System.EventHandler(this.cmdCheckNumber_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(38, 122);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(49, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Eingabe:";
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(38, 169);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(93, 115);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(90, 71);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(50, 13);
            this.lblRandom.TabIndex = 5;
            this.lblRandom.Text = "Random:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 205);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.cmdCheckNumber);
            this.Controls.Add(this.cmdCreateRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateRandom;
        private System.Windows.Forms.Button cmdCheckNumber;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblRandom;
    }
}

