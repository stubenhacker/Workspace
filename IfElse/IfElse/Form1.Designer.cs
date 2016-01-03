namespace IfElse
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
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.cmdIf = new System.Windows.Forms.Button();
            this.cmdIfElse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdIfElseIf = new System.Windows.Forms.Button();
            this.cmdLogUnd = new System.Windows.Forms.Button();
            this.cmdLogOder = new System.Windows.Forms.Button();
            this.cmdLogExklOder = new System.Windows.Forms.Button();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            this.SuspendLayout();
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(233, 59);
            this.numX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 20);
            this.numX.TabIndex = 0;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(233, 96);
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 20);
            this.numY.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(192, 66);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "x:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(192, 98);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "y:";
            // 
            // cmdIf
            // 
            this.cmdIf.Location = new System.Drawing.Point(12, 59);
            this.cmdIf.Name = "cmdIf";
            this.cmdIf.Size = new System.Drawing.Size(121, 23);
            this.cmdIf.TabIndex = 4;
            this.cmdIf.Text = "if";
            this.cmdIf.UseVisualStyleBackColor = true;
            this.cmdIf.Click += new System.EventHandler(this.cmdIf_Click);
            // 
            // cmdIfElse
            // 
            this.cmdIfElse.Location = new System.Drawing.Point(12, 98);
            this.cmdIfElse.Name = "cmdIfElse";
            this.cmdIfElse.Size = new System.Drawing.Size(121, 23);
            this.cmdIfElse.TabIndex = 5;
            this.cmdIfElse.Text = "if else";
            this.cmdIfElse.UseVisualStyleBackColor = true;
            this.cmdIfElse.Click += new System.EventHandler(this.cmdIfElse_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ternärer Operator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdIfElseIf
            // 
            this.cmdIfElseIf.Location = new System.Drawing.Point(12, 179);
            this.cmdIfElseIf.Name = "cmdIfElseIf";
            this.cmdIfElseIf.Size = new System.Drawing.Size(121, 23);
            this.cmdIfElseIf.TabIndex = 7;
            this.cmdIfElseIf.Text = "if else if";
            this.cmdIfElseIf.UseVisualStyleBackColor = true;
            this.cmdIfElseIf.Click += new System.EventHandler(this.cmdIfElseIf_Click);
            // 
            // cmdLogUnd
            // 
            this.cmdLogUnd.Location = new System.Drawing.Point(12, 220);
            this.cmdLogUnd.Name = "cmdLogUnd";
            this.cmdLogUnd.Size = new System.Drawing.Size(121, 23);
            this.cmdLogUnd.TabIndex = 8;
            this.cmdLogUnd.Text = "log. Und";
            this.cmdLogUnd.UseVisualStyleBackColor = true;
            this.cmdLogUnd.Click += new System.EventHandler(this.cmdLogUnd_Click);
            // 
            // cmdLogOder
            // 
            this.cmdLogOder.Location = new System.Drawing.Point(12, 260);
            this.cmdLogOder.Name = "cmdLogOder";
            this.cmdLogOder.Size = new System.Drawing.Size(121, 23);
            this.cmdLogOder.TabIndex = 9;
            this.cmdLogOder.Text = "log. Oder";
            this.cmdLogOder.UseVisualStyleBackColor = true;
            this.cmdLogOder.Click += new System.EventHandler(this.cmdLogOder_Click);
            // 
            // cmdLogExklOder
            // 
            this.cmdLogExklOder.Location = new System.Drawing.Point(12, 303);
            this.cmdLogExklOder.Name = "cmdLogExklOder";
            this.cmdLogExklOder.Size = new System.Drawing.Size(121, 23);
            this.cmdLogExklOder.TabIndex = 10;
            this.cmdLogExklOder.Text = "log. exkl. Oder";
            this.cmdLogExklOder.UseVisualStyleBackColor = true;
            this.cmdLogExklOder.Click += new System.EventHandler(this.cmdLogExklOder_Click);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(12, 19);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 335);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.cmdLogExklOder);
            this.Controls.Add(this.cmdLogOder);
            this.Controls.Add(this.cmdLogUnd);
            this.Controls.Add(this.cmdIfElseIf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdIfElse);
            this.Controls.Add(this.cmdIf);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button cmdIf;
        private System.Windows.Forms.Button cmdIfElse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmdIfElseIf;
        private System.Windows.Forms.Button cmdLogUnd;
        private System.Windows.Forms.Button cmdLogOder;
        private System.Windows.Forms.Button cmdLogExklOder;
        private System.Windows.Forms.Label lblAnzeigen;
    }
}

