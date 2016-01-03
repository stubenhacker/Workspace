namespace MehrereFormulare
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
            this.cmdStartUnter = new System.Windows.Forms.Button();
            this.txtInputHaupt = new System.Windows.Forms.TextBox();
            this.chkHaupt = new System.Windows.Forms.CheckBox();
            this.cmdEndeHaupt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStartUnter
            // 
            this.cmdStartUnter.Location = new System.Drawing.Point(12, 12);
            this.cmdStartUnter.Name = "cmdStartUnter";
            this.cmdStartUnter.Size = new System.Drawing.Size(120, 23);
            this.cmdStartUnter.TabIndex = 0;
            this.cmdStartUnter.Text = "Start Unterformular";
            this.cmdStartUnter.UseVisualStyleBackColor = true;
            this.cmdStartUnter.Click += new System.EventHandler(this.cmdStartUnter_Click);
            // 
            // txtInputHaupt
            // 
            this.txtInputHaupt.Location = new System.Drawing.Point(12, 57);
            this.txtInputHaupt.Name = "txtInputHaupt";
            this.txtInputHaupt.Size = new System.Drawing.Size(193, 20);
            this.txtInputHaupt.TabIndex = 1;
            // 
            // chkHaupt
            // 
            this.chkHaupt.AutoSize = true;
            this.chkHaupt.Location = new System.Drawing.Point(12, 98);
            this.chkHaupt.Name = "chkHaupt";
            this.chkHaupt.Size = new System.Drawing.Size(144, 17);
            this.chkHaupt.TabIndex = 2;
            this.chkHaupt.Text = "CheckBox Hauptformular";
            this.chkHaupt.UseVisualStyleBackColor = true;
            // 
            // cmdEndeHaupt
            // 
            this.cmdEndeHaupt.Location = new System.Drawing.Point(12, 142);
            this.cmdEndeHaupt.Name = "cmdEndeHaupt";
            this.cmdEndeHaupt.Size = new System.Drawing.Size(144, 23);
            this.cmdEndeHaupt.TabIndex = 3;
            this.cmdEndeHaupt.Text = "Ende Hauptformular";
            this.cmdEndeHaupt.UseVisualStyleBackColor = true;
            this.cmdEndeHaupt.Click += new System.EventHandler(this.cmdEndeHaupt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdEndeHaupt);
            this.Controls.Add(this.chkHaupt);
            this.Controls.Add(this.txtInputHaupt);
            this.Controls.Add(this.cmdStartUnter);
            this.Name = "Form1";
            this.Text = "Hauptformular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStartUnter;
        private System.Windows.Forms.TextBox txtInputHaupt;
        private System.Windows.Forms.CheckBox chkHaupt;
        private System.Windows.Forms.Button cmdEndeHaupt;
    }
}

