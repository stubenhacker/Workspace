namespace StringGrundlagen
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
            this.cmdLänge = new System.Windows.Forms.Button();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdZeichen = new System.Windows.Forms.Button();
            this.cmdTrim = new System.Windows.Forms.Button();
            this.cmdSplit = new System.Windows.Forms.Button();
            this.cmdSuche1 = new System.Windows.Forms.Button();
            this.txtInputSuche = new System.Windows.Forms.TextBox();
            this.cmdSucheAlle = new System.Windows.Forms.Button();
            this.lblSuche = new System.Windows.Forms.Label();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.txtInputInsert = new System.Windows.Forms.TextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.numInsertPosition = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoesche = new System.Windows.Forms.Label();
            this.numDeletePosition = new System.Windows.Forms.NumericUpDown();
            this.lblPositionLoeschen = new System.Windows.Forms.Label();
            this.numDeleteLength = new System.Windows.Forms.NumericUpDown();
            this.lblDeleteLength = new System.Windows.Forms.Label();
            this.cmdSubString = new System.Windows.Forms.Button();
            this.numSubStringPosition = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numSubStringLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSubString2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdReplace = new System.Windows.Forms.Button();
            this.txtInputReplace = new System.Windows.Forms.TextBox();
            this.txtInputReplaceBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdReverse = new System.Windows.Forms.Button();
            this.cmdReverse2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeletePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubStringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubStringLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLänge
            // 
            this.cmdLänge.Location = new System.Drawing.Point(292, 14);
            this.cmdLänge.Name = "cmdLänge";
            this.cmdLänge.Size = new System.Drawing.Size(75, 23);
            this.cmdLänge.TabIndex = 0;
            this.cmdLänge.Text = "Länge";
            this.cmdLänge.UseVisualStyleBackColor = true;
            this.cmdLänge.Click += new System.EventHandler(this.cmdLänge_Click);
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(12, 24);
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(264, 20);
            this.txtInputString.TabIndex = 1;
            this.txtInputString.TextChanged += new System.EventHandler(this.txtInputString_TextChanged);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 77);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 2;
            // 
            // cmdZeichen
            // 
            this.cmdZeichen.Location = new System.Drawing.Point(292, 43);
            this.cmdZeichen.Name = "cmdZeichen";
            this.cmdZeichen.Size = new System.Drawing.Size(75, 23);
            this.cmdZeichen.TabIndex = 3;
            this.cmdZeichen.Text = "Zeichen";
            this.cmdZeichen.UseVisualStyleBackColor = true;
            this.cmdZeichen.Click += new System.EventHandler(this.cmdZeichen_Click);
            // 
            // cmdTrim
            // 
            this.cmdTrim.Location = new System.Drawing.Point(292, 74);
            this.cmdTrim.Name = "cmdTrim";
            this.cmdTrim.Size = new System.Drawing.Size(75, 23);
            this.cmdTrim.TabIndex = 4;
            this.cmdTrim.Text = "Trim";
            this.cmdTrim.UseVisualStyleBackColor = true;
            this.cmdTrim.Click += new System.EventHandler(this.cmdTrim_Click);
            // 
            // cmdSplit
            // 
            this.cmdSplit.Location = new System.Drawing.Point(292, 103);
            this.cmdSplit.Name = "cmdSplit";
            this.cmdSplit.Size = new System.Drawing.Size(75, 23);
            this.cmdSplit.TabIndex = 5;
            this.cmdSplit.Text = "Split";
            this.cmdSplit.UseVisualStyleBackColor = true;
            this.cmdSplit.Click += new System.EventHandler(this.cmdSplit_Click);
            // 
            // cmdSuche1
            // 
            this.cmdSuche1.Location = new System.Drawing.Point(292, 147);
            this.cmdSuche1.Name = "cmdSuche1";
            this.cmdSuche1.Size = new System.Drawing.Size(75, 23);
            this.cmdSuche1.TabIndex = 6;
            this.cmdSuche1.Text = "Suche 1";
            this.cmdSuche1.UseVisualStyleBackColor = true;
            this.cmdSuche1.Click += new System.EventHandler(this.cmdSuche1_Click);
            // 
            // txtInputSuche
            // 
            this.txtInputSuche.Location = new System.Drawing.Point(151, 148);
            this.txtInputSuche.Name = "txtInputSuche";
            this.txtInputSuche.Size = new System.Drawing.Size(137, 20);
            this.txtInputSuche.TabIndex = 7;
            // 
            // cmdSucheAlle
            // 
            this.cmdSucheAlle.Location = new System.Drawing.Point(292, 173);
            this.cmdSucheAlle.Name = "cmdSucheAlle";
            this.cmdSucheAlle.Size = new System.Drawing.Size(75, 23);
            this.cmdSucheAlle.TabIndex = 8;
            this.cmdSucheAlle.Text = "Suche alle";
            this.cmdSucheAlle.UseVisualStyleBackColor = true;
            this.cmdSucheAlle.Click += new System.EventHandler(this.cmdSucheAlle_Click);
            // 
            // lblSuche
            // 
            this.lblSuche.AutoSize = true;
            this.lblSuche.Location = new System.Drawing.Point(151, 132);
            this.lblSuche.Name = "lblSuche";
            this.lblSuche.Size = new System.Drawing.Size(49, 13);
            this.lblSuche.TabIndex = 9;
            this.lblSuche.Text = "Suchtext";
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(292, 218);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(75, 23);
            this.cmdInsert.TabIndex = 10;
            this.cmdInsert.Text = "Einfügen";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // txtInputInsert
            // 
            this.txtInputInsert.Location = new System.Drawing.Point(151, 221);
            this.txtInputInsert.Name = "txtInputInsert";
            this.txtInputInsert.Size = new System.Drawing.Size(125, 20);
            this.txtInputInsert.TabIndex = 11;
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(150, 205);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(49, 13);
            this.lblInsert.TabIndex = 12;
            this.lblInsert.Text = "Einfügen";
            // 
            // numInsertPosition
            // 
            this.numInsertPosition.Location = new System.Drawing.Point(219, 247);
            this.numInsertPosition.Name = "numInsertPosition";
            this.numInsertPosition.Size = new System.Drawing.Size(52, 20);
            this.numInsertPosition.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "bei Position";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLoesche
            // 
            this.lblLoesche.AutoSize = true;
            this.lblLoesche.Location = new System.Drawing.Point(152, 290);
            this.lblLoesche.Name = "lblLoesche";
            this.lblLoesche.Size = new System.Drawing.Size(42, 13);
            this.lblLoesche.TabIndex = 17;
            this.lblLoesche.Text = "Lösche";
            // 
            // numDeletePosition
            // 
            this.numDeletePosition.Location = new System.Drawing.Point(219, 333);
            this.numDeletePosition.Name = "numDeletePosition";
            this.numDeletePosition.Size = new System.Drawing.Size(52, 20);
            this.numDeletePosition.TabIndex = 18;
            this.numDeletePosition.ValueChanged += new System.EventHandler(this.numDeletePosition_ValueChanged);
            // 
            // lblPositionLoeschen
            // 
            this.lblPositionLoeschen.AutoSize = true;
            this.lblPositionLoeschen.Location = new System.Drawing.Point(152, 335);
            this.lblPositionLoeschen.Name = "lblPositionLoeschen";
            this.lblPositionLoeschen.Size = new System.Drawing.Size(61, 13);
            this.lblPositionLoeschen.TabIndex = 19;
            this.lblPositionLoeschen.Text = "bei Position";
            // 
            // numDeleteLength
            // 
            this.numDeleteLength.Location = new System.Drawing.Point(155, 306);
            this.numDeleteLength.Name = "numDeleteLength";
            this.numDeleteLength.Size = new System.Drawing.Size(58, 20);
            this.numDeleteLength.TabIndex = 20;
            // 
            // lblDeleteLength
            // 
            this.lblDeleteLength.AutoSize = true;
            this.lblDeleteLength.Location = new System.Drawing.Point(219, 308);
            this.lblDeleteLength.Name = "lblDeleteLength";
            this.lblDeleteLength.Size = new System.Drawing.Size(46, 13);
            this.lblDeleteLength.TabIndex = 21;
            this.lblDeleteLength.Text = "Zeichen";
            // 
            // cmdSubString
            // 
            this.cmdSubString.Location = new System.Drawing.Point(653, 43);
            this.cmdSubString.Name = "cmdSubString";
            this.cmdSubString.Size = new System.Drawing.Size(141, 23);
            this.cmdSubString.TabIndex = 22;
            this.cmdSubString.Text = "SubString (index, length)";
            this.cmdSubString.UseVisualStyleBackColor = true;
            this.cmdSubString.Click += new System.EventHandler(this.cmdSubString_Click);
            // 
            // numSubStringPosition
            // 
            this.numSubStringPosition.Location = new System.Drawing.Point(543, 45);
            this.numSubStringPosition.Name = "numSubStringPosition";
            this.numSubStringPosition.Size = new System.Drawing.Size(104, 20);
            this.numSubStringPosition.TabIndex = 23;
            this.numSubStringPosition.ValueChanged += new System.EventHandler(this.numSubStringPosition_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Teilstring ab Position";
            // 
            // numSubStringLength
            // 
            this.numSubStringLength.Location = new System.Drawing.Point(543, 91);
            this.numSubStringLength.Name = "numSubStringLength";
            this.numSubStringLength.Size = new System.Drawing.Size(104, 20);
            this.numSubStringLength.TabIndex = 25;
      
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Länge";
            // 
            // cmdSubString2
            // 
            this.cmdSubString2.Location = new System.Drawing.Point(653, 122);
            this.cmdSubString2.Name = "cmdSubString2";
            this.cmdSubString2.Size = new System.Drawing.Size(141, 23);
            this.cmdSubString2.TabIndex = 27;
            this.cmdSubString2.Text = "SubString(index, length-1)";
            this.cmdSubString2.UseVisualStyleBackColor = true;
            this.cmdSubString2.Click += new System.EventHandler(this.cmdSubString2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Eingabe:";
            // 
            // cmdReplace
            // 
            this.cmdReplace.Location = new System.Drawing.Point(653, 195);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(75, 23);
            this.cmdReplace.TabIndex = 29;
            this.cmdReplace.Text = "Ersetzen";
            this.cmdReplace.UseVisualStyleBackColor = true;
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // txtInputReplace
            // 
            this.txtInputReplace.Location = new System.Drawing.Point(543, 195);
            this.txtInputReplace.Name = "txtInputReplace";
            this.txtInputReplace.Size = new System.Drawing.Size(100, 20);
            this.txtInputReplace.TabIndex = 30;
            // 
            // txtInputReplaceBy
            // 
            this.txtInputReplaceBy.Location = new System.Drawing.Point(543, 232);
            this.txtInputReplaceBy.Name = "txtInputReplaceBy";
            this.txtInputReplaceBy.Size = new System.Drawing.Size(100, 20);
            this.txtInputReplaceBy.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ersetze:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "durch:";
            // 
            // cmdReverse
            // 
            this.cmdReverse.Location = new System.Drawing.Point(653, 290);
            this.cmdReverse.Name = "cmdReverse";
            this.cmdReverse.Size = new System.Drawing.Size(75, 23);
            this.cmdReverse.TabIndex = 34;
            this.cmdReverse.Text = "Reverse";
            this.cmdReverse.UseVisualStyleBackColor = true;
            this.cmdReverse.Click += new System.EventHandler(this.cmdReverse_Click);
            // 
            // cmdReverse2
            // 
            this.cmdReverse2.Location = new System.Drawing.Point(653, 335);
            this.cmdReverse2.Name = "cmdReverse2";
            this.cmdReverse2.Size = new System.Drawing.Size(99, 23);
            this.cmdReverse2.TabIndex = 35;
            this.cmdReverse2.Text = "Reverse rec.";
            this.cmdReverse2.UseVisualStyleBackColor = true;
            this.cmdReverse2.Click += new System.EventHandler(this.cmdReverse2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 459);
            this.Controls.Add(this.cmdReverse2);
            this.Controls.Add(this.cmdReverse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInputReplaceBy);
            this.Controls.Add(this.txtInputReplace);
            this.Controls.Add(this.cmdReplace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSubString2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSubStringLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSubStringPosition);
            this.Controls.Add(this.cmdSubString);
            this.Controls.Add(this.lblDeleteLength);
            this.Controls.Add(this.numDeleteLength);
            this.Controls.Add(this.lblPositionLoeschen);
            this.Controls.Add(this.numDeletePosition);
            this.Controls.Add(this.lblLoesche);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numInsertPosition);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.txtInputInsert);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.lblSuche);
            this.Controls.Add(this.cmdSucheAlle);
            this.Controls.Add(this.txtInputSuche);
            this.Controls.Add(this.cmdSuche1);
            this.Controls.Add(this.cmdSplit);
            this.Controls.Add(this.cmdTrim);
            this.Controls.Add(this.cmdZeichen);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.txtInputString);
            this.Controls.Add(this.cmdLänge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInsertPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeletePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubStringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubStringLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLänge;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.Button cmdZeichen;
        private System.Windows.Forms.Button cmdTrim;
        private System.Windows.Forms.Button cmdSplit;
        private System.Windows.Forms.Button cmdSuche1;
        private System.Windows.Forms.TextBox txtInputSuche;
        private System.Windows.Forms.Button cmdSucheAlle;
        private System.Windows.Forms.Label lblSuche;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.TextBox txtInputInsert;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.NumericUpDown numInsertPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLoesche;
        private System.Windows.Forms.NumericUpDown numDeletePosition;
        private System.Windows.Forms.Label lblPositionLoeschen;
        private System.Windows.Forms.NumericUpDown numDeleteLength;
        private System.Windows.Forms.Label lblDeleteLength;
        private System.Windows.Forms.Button cmdSubString;
        private System.Windows.Forms.NumericUpDown numSubStringPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSubStringLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSubString2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdReplace;
        private System.Windows.Forms.TextBox txtInputReplace;
        private System.Windows.Forms.TextBox txtInputReplaceBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdReverse;
        private System.Windows.Forms.Button cmdReverse2;
    }
}

