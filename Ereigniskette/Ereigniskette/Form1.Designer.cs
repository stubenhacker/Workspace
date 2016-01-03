namespace Ereigniskette
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
            this.cmdEvent1 = new System.Windows.Forms.Button();
            this.cmdEvent2 = new System.Windows.Forms.Button();
            this.cmdEvent3 = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblAnzeige1 = new System.Windows.Forms.Label();
            this.lblAnzeige2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdEvent1
            // 
            this.cmdEvent1.Location = new System.Drawing.Point(185, 32);
            this.cmdEvent1.Name = "cmdEvent1";
            this.cmdEvent1.Size = new System.Drawing.Size(75, 23);
            this.cmdEvent1.TabIndex = 0;
            this.cmdEvent1.Text = "Ereignis 1";
            this.cmdEvent1.UseVisualStyleBackColor = true;
            this.cmdEvent1.Click += new System.EventHandler(this.cmdEvent1_Click);
            // 
            // cmdEvent2
            // 
            this.cmdEvent2.Location = new System.Drawing.Point(185, 91);
            this.cmdEvent2.Name = "cmdEvent2";
            this.cmdEvent2.Size = new System.Drawing.Size(75, 23);
            this.cmdEvent2.TabIndex = 1;
            this.cmdEvent2.Text = "Ereignis 2";
            this.cmdEvent2.UseVisualStyleBackColor = true;
            this.cmdEvent2.Click += new System.EventHandler(this.cmdEvent2_Click);
            // 
            // cmdEvent3
            // 
            this.cmdEvent3.Location = new System.Drawing.Point(185, 156);
            this.cmdEvent3.Name = "cmdEvent3";
            this.cmdEvent3.Size = new System.Drawing.Size(75, 23);
            this.cmdEvent3.TabIndex = 2;
            this.cmdEvent3.Text = "Ereignis 1+2";
            this.cmdEvent3.UseVisualStyleBackColor = true;
            this.cmdEvent3.Click += new System.EventHandler(this.cmdEvent3_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(185, 215);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Löschen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lblAnzeige1
            // 
            this.lblAnzeige1.AutoSize = true;
            this.lblAnzeige1.Location = new System.Drawing.Point(50, 37);
            this.lblAnzeige1.Name = "lblAnzeige1";
            this.lblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige1.TabIndex = 4;
            // 
            // lblAnzeige2
            // 
            this.lblAnzeige2.AutoSize = true;
            this.lblAnzeige2.Location = new System.Drawing.Point(50, 96);
            this.lblAnzeige2.Name = "lblAnzeige2";
            this.lblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblAnzeige2);
            this.Controls.Add(this.lblAnzeige1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdEvent3);
            this.Controls.Add(this.cmdEvent2);
            this.Controls.Add(this.cmdEvent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEvent1;
        private System.Windows.Forms.Button cmdEvent2;
        private System.Windows.Forms.Button cmdEvent3;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblAnzeige1;
        private System.Windows.Forms.Label lblAnzeige2;
    }
}

