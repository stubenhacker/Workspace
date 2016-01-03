namespace XMLDatei
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
            this.cmdXMLSchreiben = new System.Windows.Forms.Button();
            this.cmdXMLLesen = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.cmdObjektIn = new System.Windows.Forms.Button();
            this.cmdObjekteLesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdXMLSchreiben
            // 
            this.cmdXMLSchreiben.Location = new System.Drawing.Point(354, 12);
            this.cmdXMLSchreiben.Name = "cmdXMLSchreiben";
            this.cmdXMLSchreiben.Size = new System.Drawing.Size(120, 23);
            this.cmdXMLSchreiben.TabIndex = 0;
            this.cmdXMLSchreiben.Text = "XML-Datei schreiben";
            this.cmdXMLSchreiben.UseVisualStyleBackColor = true;
            this.cmdXMLSchreiben.Click += new System.EventHandler(this.cmdXMLSchreiben_Click);
            // 
            // cmdXMLLesen
            // 
            this.cmdXMLLesen.Location = new System.Drawing.Point(354, 51);
            this.cmdXMLLesen.Name = "cmdXMLLesen";
            this.cmdXMLLesen.Size = new System.Drawing.Size(120, 23);
            this.cmdXMLLesen.TabIndex = 1;
            this.cmdXMLLesen.Text = "XML-Datei lesen";
            this.cmdXMLLesen.UseVisualStyleBackColor = true;
            this.cmdXMLLesen.Click += new System.EventHandler(this.cmdXMLLesen_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 12);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 2;
            // 
            // cmdObjektIn
            // 
            this.cmdObjektIn.Location = new System.Drawing.Point(354, 97);
            this.cmdObjektIn.Name = "cmdObjektIn";
            this.cmdObjektIn.Size = new System.Drawing.Size(120, 23);
            this.cmdObjektIn.TabIndex = 3;
            this.cmdObjektIn.Text = "Objekte in XML";
            this.cmdObjektIn.UseVisualStyleBackColor = true;
            this.cmdObjektIn.Click += new System.EventHandler(this.cmdObjektIn_Click);
            // 
            // cmdObjekteLesen
            // 
            this.cmdObjekteLesen.Location = new System.Drawing.Point(341, 141);
            this.cmdObjekteLesen.Name = "cmdObjekteLesen";
            this.cmdObjekteLesen.Size = new System.Drawing.Size(133, 23);
            this.cmdObjekteLesen.TabIndex = 4;
            this.cmdObjekteLesen.Text = "Objekte aus XML lesen";
            this.cmdObjekteLesen.UseVisualStyleBackColor = true;
            this.cmdObjekteLesen.Click += new System.EventHandler(this.cmdObjekteLesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.cmdObjekteLesen);
            this.Controls.Add(this.cmdObjektIn);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdXMLLesen);
            this.Controls.Add(this.cmdXMLSchreiben);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdXMLSchreiben;
        private System.Windows.Forms.Button cmdXMLLesen;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Button cmdObjektIn;
        private System.Windows.Forms.Button cmdObjekteLesen;
    }
}

