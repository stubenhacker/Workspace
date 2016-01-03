namespace ÜListenfeld
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
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.cmdCopyLeftToRight = new System.Windows.Forms.Button();
            this.cmdCopyRightToLeft = new System.Windows.Forms.Button();
            this.lblAnzeige1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.Location = new System.Drawing.Point(40, 29);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLeft.Size = new System.Drawing.Size(181, 199);
            this.lstLeft.TabIndex = 0;
            this.lstLeft.SelectedIndexChanged += new System.EventHandler(this.lstLeft_SelectedIndexChanged);
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.Location = new System.Drawing.Point(351, 29);
            this.lstRight.Name = "lstRight";
            this.lstRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRight.Size = new System.Drawing.Size(180, 199);
            this.lstRight.TabIndex = 1;
            // 
            // cmdCopyLeftToRight
            // 
            this.cmdCopyLeftToRight.Location = new System.Drawing.Point(251, 77);
            this.cmdCopyLeftToRight.Name = "cmdCopyLeftToRight";
            this.cmdCopyLeftToRight.Size = new System.Drawing.Size(75, 23);
            this.cmdCopyLeftToRight.TabIndex = 2;
            this.cmdCopyLeftToRight.Text = ">>";
            this.cmdCopyLeftToRight.UseVisualStyleBackColor = true;
            this.cmdCopyLeftToRight.Click += new System.EventHandler(this.cmdCopyLeftToRight_Click);
            // 
            // cmdCopyRightToLeft
            // 
            this.cmdCopyRightToLeft.Location = new System.Drawing.Point(251, 146);
            this.cmdCopyRightToLeft.Name = "cmdCopyRightToLeft";
            this.cmdCopyRightToLeft.Size = new System.Drawing.Size(75, 23);
            this.cmdCopyRightToLeft.TabIndex = 3;
            this.cmdCopyRightToLeft.Text = "<<";
            this.cmdCopyRightToLeft.UseVisualStyleBackColor = true;
            this.cmdCopyRightToLeft.Click += new System.EventHandler(this.cmdCopyRightToLeft_Click);
            // 
            // lblAnzeige1
            // 
            this.lblAnzeige1.AutoSize = true;
            this.lblAnzeige1.Location = new System.Drawing.Point(37, 9);
            this.lblAnzeige1.Name = "lblAnzeige1";
            this.lblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 262);
            this.Controls.Add(this.lblAnzeige1);
            this.Controls.Add(this.cmdCopyRightToLeft);
            this.Controls.Add(this.cmdCopyLeftToRight);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button cmdCopyLeftToRight;
        private System.Windows.Forms.Button cmdCopyRightToLeft;
        private System.Windows.Forms.Label lblAnzeige1;
    }
}

