namespace ListenfeldMethoden
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
            this.lstSpeisen = new System.Windows.Forms.ListBox();
            this.txtInputNewItem = new System.Windows.Forms.TextBox();
            this.lblNewElement = new System.Windows.Forms.Label();
            this.lblPositionInput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPostionBeforeSelectedItem = new System.Windows.Forms.RadioButton();
            this.rbPositionListStart = new System.Windows.Forms.RadioButton();
            this.rbPositionListEnd = new System.Windows.Forms.RadioButton();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.cmdDeleteItem = new System.Windows.Forms.Button();
            this.cmdReplaceWith = new System.Windows.Forms.Button();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.cmdInsertItem = new System.Windows.Forms.Button();
            this.cmdDeleteAllItems = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSpeisen
            // 
            this.lstSpeisen.FormattingEnabled = true;
            this.lstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.lstSpeisen.Name = "lstSpeisen";
            this.lstSpeisen.Size = new System.Drawing.Size(187, 95);
            this.lstSpeisen.TabIndex = 0;
            // 
            // txtInputNewItem
            // 
            this.txtInputNewItem.Location = new System.Drawing.Point(255, 43);
            this.txtInputNewItem.Name = "txtInputNewItem";
            this.txtInputNewItem.Size = new System.Drawing.Size(218, 20);
            this.txtInputNewItem.TabIndex = 1;
            // 
            // lblNewElement
            // 
            this.lblNewElement.AutoSize = true;
            this.lblNewElement.Location = new System.Drawing.Point(252, 12);
            this.lblNewElement.Name = "lblNewElement";
            this.lblNewElement.Size = new System.Drawing.Size(79, 13);
            this.lblNewElement.TabIndex = 2;
            this.lblNewElement.Text = "Neues Element";
            // 
            // lblPositionInput
            // 
            this.lblPositionInput.AutoSize = true;
            this.lblPositionInput.Location = new System.Drawing.Point(252, 124);
            this.lblPositionInput.Name = "lblPositionInput";
            this.lblPositionInput.Size = new System.Drawing.Size(58, 13);
            this.lblPositionInput.TabIndex = 3;
            this.lblPositionInput.Text = "Einfügeort:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPostionBeforeSelectedItem);
            this.groupBox1.Controls.Add(this.rbPositionListStart);
            this.groupBox1.Controls.Add(this.rbPositionListEnd);
            this.groupBox1.Location = new System.Drawing.Point(255, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbPostionBeforeSelectedItem
            // 
            this.rbPostionBeforeSelectedItem.AutoSize = true;
            this.rbPostionBeforeSelectedItem.Location = new System.Drawing.Point(11, 77);
            this.rbPostionBeforeSelectedItem.Name = "rbPostionBeforeSelectedItem";
            this.rbPostionBeforeSelectedItem.Size = new System.Drawing.Size(153, 17);
            this.rbPostionBeforeSelectedItem.TabIndex = 2;
            this.rbPostionBeforeSelectedItem.Text = "Vor ausgewähltem Element";
            this.rbPostionBeforeSelectedItem.UseVisualStyleBackColor = true;
            // 
            // rbPositionListStart
            // 
            this.rbPositionListStart.AutoSize = true;
            this.rbPositionListStart.Location = new System.Drawing.Point(11, 48);
            this.rbPositionListStart.Name = "rbPositionListStart";
            this.rbPositionListStart.Size = new System.Drawing.Size(120, 17);
            this.rbPositionListStart.TabIndex = 1;
            this.rbPositionListStart.Text = "Am Anfang der Liste";
            this.rbPositionListStart.UseVisualStyleBackColor = true;
            // 
            // rbPositionListEnd
            // 
            this.rbPositionListEnd.AutoSize = true;
            this.rbPositionListEnd.Checked = true;
            this.rbPositionListEnd.Location = new System.Drawing.Point(11, 19);
            this.rbPositionListEnd.Name = "rbPositionListEnd";
            this.rbPositionListEnd.Size = new System.Drawing.Size(111, 17);
            this.rbPositionListEnd.TabIndex = 0;
            this.rbPositionListEnd.TabStop = true;
            this.rbPositionListEnd.Text = "Am Ende der Liste";
            this.rbPositionListEnd.UseVisualStyleBackColor = true;
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(15, 189);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(117, 13);
            this.lblSelectedItem.TabIndex = 5;
            this.lblSelectedItem.Text = "Ausgewähltes Element:";
            // 
            // cmdDeleteItem
            // 
            this.cmdDeleteItem.Location = new System.Drawing.Point(15, 205);
            this.cmdDeleteItem.Name = "cmdDeleteItem";
            this.cmdDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteItem.TabIndex = 6;
            this.cmdDeleteItem.Text = "Löschen";
            this.cmdDeleteItem.UseVisualStyleBackColor = true;
            this.cmdDeleteItem.Click += new System.EventHandler(this.cmdDeleteItem_Click);
            // 
            // cmdReplaceWith
            // 
            this.cmdReplaceWith.Location = new System.Drawing.Point(15, 234);
            this.cmdReplaceWith.Name = "cmdReplaceWith";
            this.cmdReplaceWith.Size = new System.Drawing.Size(100, 23);
            this.cmdReplaceWith.TabIndex = 7;
            this.cmdReplaceWith.Text = "Ersetzen durch:";
            this.cmdReplaceWith.UseVisualStyleBackColor = true;
            this.cmdReplaceWith.Click += new System.EventHandler(this.cmdReplaceWith_Click);
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(15, 263);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(184, 20);
            this.txtReplaceWith.TabIndex = 8;
            // 
            // cmdInsertItem
            // 
            this.cmdInsertItem.Location = new System.Drawing.Point(256, 69);
            this.cmdInsertItem.Name = "cmdInsertItem";
            this.cmdInsertItem.Size = new System.Drawing.Size(75, 23);
            this.cmdInsertItem.TabIndex = 9;
            this.cmdInsertItem.Text = "Einfügen";
            this.cmdInsertItem.UseVisualStyleBackColor = true;
            this.cmdInsertItem.Click += new System.EventHandler(this.cmdInsertItem_Click);
            // 
            // cmdDeleteAllItems
            // 
            this.cmdDeleteAllItems.Location = new System.Drawing.Point(255, 295);
            this.cmdDeleteAllItems.Name = "cmdDeleteAllItems";
            this.cmdDeleteAllItems.Size = new System.Drawing.Size(105, 23);
            this.cmdDeleteAllItems.TabIndex = 10;
            this.cmdDeleteAllItems.Text = "Alles löschen";
            this.cmdDeleteAllItems.UseVisualStyleBackColor = true;
            this.cmdDeleteAllItems.Click += new System.EventHandler(this.cmdDeleteAllItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 352);
            this.Controls.Add(this.cmdDeleteAllItems);
            this.Controls.Add(this.cmdInsertItem);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.cmdReplaceWith);
            this.Controls.Add(this.cmdDeleteItem);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPositionInput);
            this.Controls.Add(this.lblNewElement);
            this.Controls.Add(this.txtInputNewItem);
            this.Controls.Add(this.lstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Methoden";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSpeisen;
        private System.Windows.Forms.TextBox txtInputNewItem;
        private System.Windows.Forms.Label lblNewElement;
        private System.Windows.Forms.Label lblPositionInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPostionBeforeSelectedItem;
        private System.Windows.Forms.RadioButton rbPositionListStart;
        private System.Windows.Forms.RadioButton rbPositionListEnd;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Button cmdDeleteItem;
        private System.Windows.Forms.Button cmdReplaceWith;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Button cmdInsertItem;
        private System.Windows.Forms.Button cmdDeleteAllItems;
    }
}

