namespace EnabledVisible
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.cmdRechnen1 = new System.Windows.Forms.Button();
            this.cmdRechnen2 = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 27);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 20);
            this.txtInput1.TabIndex = 0;
            this.txtInput1.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(138, 27);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // cmdRechnen1
            // 
            this.cmdRechnen1.Enabled = false;
            this.cmdRechnen1.Location = new System.Drawing.Point(12, 94);
            this.cmdRechnen1.Name = "cmdRechnen1";
            this.cmdRechnen1.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen1.TabIndex = 2;
            this.cmdRechnen1.Text = "Rechnen 1";
            this.cmdRechnen1.UseVisualStyleBackColor = true;
            this.cmdRechnen1.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // cmdRechnen2
            // 
            this.cmdRechnen2.Location = new System.Drawing.Point(12, 123);
            this.cmdRechnen2.Name = "cmdRechnen2";
            this.cmdRechnen2.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen2.TabIndex = 3;
            this.cmdRechnen2.Text = "Rechnen 2";
            this.cmdRechnen2.UseVisualStyleBackColor = true;
            this.cmdRechnen2.Visible = false;
            this.cmdRechnen2.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(262, 27);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 186);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdRechnen2);
            this.Controls.Add(this.cmdRechnen1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button cmdRechnen1;
        private System.Windows.Forms.Button cmdRechnen2;
        private System.Windows.Forms.Label lblAnzeigen;
    }
}

