﻿namespace Textfelder
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
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.cmdAusgabe = new System.Windows.Forms.Button();
            this.cmdRechnen = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(12, 36);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(204, 20);
            this.txtEingabe.TabIndex = 0;
            // 
            // cmdAusgabe
            // 
            this.cmdAusgabe.Location = new System.Drawing.Point(317, 33);
            this.cmdAusgabe.Name = "cmdAusgabe";
            this.cmdAusgabe.Size = new System.Drawing.Size(75, 23);
            this.cmdAusgabe.TabIndex = 1;
            this.cmdAusgabe.Text = "Ausgabe";
            this.cmdAusgabe.UseVisualStyleBackColor = true;
            this.cmdAusgabe.Click += new System.EventHandler(this.cmdAusgabe_Click);
            // 
            // cmdRechnen
            // 
            this.cmdRechnen.Location = new System.Drawing.Point(317, 70);
            this.cmdRechnen.Name = "cmdRechnen";
            this.cmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.cmdRechnen.TabIndex = 2;
            this.cmdRechnen.Text = "Rechnen";
            this.cmdRechnen.UseVisualStyleBackColor = true;
            this.cmdRechnen.Click += new System.EventHandler(this.cmdRechnen_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(12, 196);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAusgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 262);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.cmdRechnen);
            this.Controls.Add(this.cmdAusgabe);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Button cmdAusgabe;
        private System.Windows.Forms.Button cmdRechnen;
        private System.Windows.Forms.Label lblAusgabe;
    }
}

