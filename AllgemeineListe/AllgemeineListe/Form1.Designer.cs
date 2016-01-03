namespace AllgemeineListe
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
            this.cmdListeAnlegen = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.cmdAction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLoescheAmEnde = new System.Windows.Forms.RadioButton();
            this.rbLoescheAmAnfang = new System.Windows.Forms.RadioButton();
            this.rbFuegeEinAmEnde = new System.Windows.Forms.RadioButton();
            this.rbFuegeEinAmAnfang = new System.Windows.Forms.RadioButton();
            this.lstAusgabe = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdListeAnlegen
            // 
            this.cmdListeAnlegen.Location = new System.Drawing.Point(619, 12);
            this.cmdListeAnlegen.Name = "cmdListeAnlegen";
            this.cmdListeAnlegen.Size = new System.Drawing.Size(130, 23);
            this.cmdListeAnlegen.TabIndex = 0;
            this.cmdListeAnlegen.Text = "Liste anlegen";
            this.cmdListeAnlegen.UseVisualStyleBackColor = true;
            this.cmdListeAnlegen.Click += new System.EventHandler(this.cmdListeAnlegen_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(584, 58);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(165, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(532, 61);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(46, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Eingabe";
            // 
            // cmdAction
            // 
            this.cmdAction.Location = new System.Drawing.Point(550, 285);
            this.cmdAction.Name = "cmdAction";
            this.cmdAction.Size = new System.Drawing.Size(75, 23);
            this.cmdAction.TabIndex = 3;
            this.cmdAction.Text = "Ausführen";
            this.cmdAction.UseVisualStyleBackColor = true;
            this.cmdAction.Click += new System.EventHandler(this.cmdAction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLoescheAmEnde);
            this.groupBox1.Controls.Add(this.rbLoescheAmAnfang);
            this.groupBox1.Controls.Add(this.rbFuegeEinAmEnde);
            this.groupBox1.Controls.Add(this.rbFuegeEinAmAnfang);
            this.groupBox1.Location = new System.Drawing.Point(550, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktionen";
            // 
            // rbLoescheAmEnde
            // 
            this.rbLoescheAmEnde.AutoSize = true;
            this.rbLoescheAmEnde.Location = new System.Drawing.Point(11, 127);
            this.rbLoescheAmEnde.Name = "rbLoescheAmEnde";
            this.rbLoescheAmEnde.Size = new System.Drawing.Size(105, 17);
            this.rbLoescheAmEnde.TabIndex = 3;
            this.rbLoescheAmEnde.Text = "Lösche am Ende";
            this.rbLoescheAmEnde.UseVisualStyleBackColor = true;
            // 
            // rbLoescheAmAnfang
            // 
            this.rbLoescheAmAnfang.AutoSize = true;
            this.rbLoescheAmAnfang.Location = new System.Drawing.Point(11, 91);
            this.rbLoescheAmAnfang.Name = "rbLoescheAmAnfang";
            this.rbLoescheAmAnfang.Size = new System.Drawing.Size(114, 17);
            this.rbLoescheAmAnfang.TabIndex = 2;
            this.rbLoescheAmAnfang.Text = "Lösche am Anfang";
            this.rbLoescheAmAnfang.UseVisualStyleBackColor = true;
            // 
            // rbFuegeEinAmEnde
            // 
            this.rbFuegeEinAmEnde.AutoSize = true;
            this.rbFuegeEinAmEnde.Location = new System.Drawing.Point(11, 53);
            this.rbFuegeEinAmEnde.Name = "rbFuegeEinAmEnde";
            this.rbFuegeEinAmEnde.Size = new System.Drawing.Size(111, 17);
            this.rbFuegeEinAmEnde.TabIndex = 1;
            this.rbFuegeEinAmEnde.Text = "Füge ein am Ende";
            this.rbFuegeEinAmEnde.UseVisualStyleBackColor = true;
            // 
            // rbFuegeEinAmAnfang
            // 
            this.rbFuegeEinAmAnfang.AutoSize = true;
            this.rbFuegeEinAmAnfang.Checked = true;
            this.rbFuegeEinAmAnfang.Location = new System.Drawing.Point(11, 19);
            this.rbFuegeEinAmAnfang.Name = "rbFuegeEinAmAnfang";
            this.rbFuegeEinAmAnfang.Size = new System.Drawing.Size(120, 17);
            this.rbFuegeEinAmAnfang.TabIndex = 0;
            this.rbFuegeEinAmAnfang.TabStop = true;
            this.rbFuegeEinAmAnfang.Text = "Füge ein am Anfang";
            this.rbFuegeEinAmAnfang.UseVisualStyleBackColor = true;
            // 
            // lstAusgabe
            // 
            this.lstAusgabe.FormattingEnabled = true;
            this.lstAusgabe.Location = new System.Drawing.Point(1, 1);
            this.lstAusgabe.Name = "lstAusgabe";
            this.lstAusgabe.ScrollAlwaysVisible = true;
            this.lstAusgabe.Size = new System.Drawing.Size(525, 316);
            this.lstAusgabe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 320);
            this.Controls.Add(this.lstAusgabe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAction);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmdListeAnlegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListeAnlegen;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button cmdAction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLoescheAmEnde;
        private System.Windows.Forms.RadioButton rbLoescheAmAnfang;
        private System.Windows.Forms.RadioButton rbFuegeEinAmEnde;
        private System.Windows.Forms.RadioButton rbFuegeEinAmAnfang;
        private System.Windows.Forms.ListBox lstAusgabe;
    }
}

