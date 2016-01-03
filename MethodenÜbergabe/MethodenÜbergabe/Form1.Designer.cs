namespace MethodenÜbergabe
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
            this.cmdCopy = new System.Windows.Forms.Button();
            this.cmdReference = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.cmdEinDimFeld = new System.Windows.Forms.Button();
            this.cmdDreiDimFeld = new System.Windows.Forms.Button();
            this.cmdOut = new System.Windows.Forms.Button();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(278, 12);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(75, 23);
            this.cmdCopy.TabIndex = 0;
            this.cmdCopy.Text = "Kopie";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdReference
            // 
            this.cmdReference.Location = new System.Drawing.Point(278, 73);
            this.cmdReference.Name = "cmdReference";
            this.cmdReference.Size = new System.Drawing.Size(75, 23);
            this.cmdReference.TabIndex = 1;
            this.cmdReference.Text = "Referenz";
            this.cmdReference.UseVisualStyleBackColor = true;
            this.cmdReference.Click += new System.EventHandler(this.cmdReference_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(23, 22);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 2;
            // 
            // cmdEinDimFeld
            // 
            this.cmdEinDimFeld.Location = new System.Drawing.Point(278, 134);
            this.cmdEinDimFeld.Name = "cmdEinDimFeld";
            this.cmdEinDimFeld.Size = new System.Drawing.Size(75, 23);
            this.cmdEinDimFeld.TabIndex = 3;
            this.cmdEinDimFeld.Text = "eindim. Feld";
            this.cmdEinDimFeld.UseVisualStyleBackColor = true;
            this.cmdEinDimFeld.Click += new System.EventHandler(this.cmdEinDimFeld_Click);
            // 
            // cmdDreiDimFeld
            // 
            this.cmdDreiDimFeld.Location = new System.Drawing.Point(278, 185);
            this.cmdDreiDimFeld.Name = "cmdDreiDimFeld";
            this.cmdDreiDimFeld.Size = new System.Drawing.Size(75, 23);
            this.cmdDreiDimFeld.TabIndex = 4;
            this.cmdDreiDimFeld.Text = "3-dim. Feld";
            this.cmdDreiDimFeld.UseVisualStyleBackColor = true;
            this.cmdDreiDimFeld.Click += new System.EventHandler(this.cmdDreiDimFeld_Click);
            // 
            // cmdOut
            // 
            this.cmdOut.Location = new System.Drawing.Point(278, 227);
            this.cmdOut.Name = "cmdOut";
            this.cmdOut.Size = new System.Drawing.Size(75, 23);
            this.cmdOut.TabIndex = 5;
            this.cmdOut.Text = "Out";
            this.cmdOut.UseVisualStyleBackColor = true;
            this.cmdOut.Click += new System.EventHandler(this.cmdOut_Click);
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(278, 262);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(75, 23);
            this.cmdReturn.TabIndex = 6;
            this.cmdReturn.Text = "Return";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 297);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.cmdOut);
            this.Controls.Add(this.cmdDreiDimFeld);
            this.Controls.Add(this.cmdEinDimFeld);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdReference);
            this.Controls.Add(this.cmdCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Button cmdReference;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Button cmdEinDimFeld;
        private System.Windows.Forms.Button cmdDreiDimFeld;
        private System.Windows.Forms.Button cmdOut;
        private System.Windows.Forms.Button cmdReturn;
    }
}

