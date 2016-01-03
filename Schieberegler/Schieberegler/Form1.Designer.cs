namespace Schieberegler
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
            this.pnlColorChange = new System.Windows.Forms.Panel();
            this.trkRed = new System.Windows.Forms.TrackBar();
            this.trkGreen = new System.Windows.Forms.TrackBar();
            this.trkBlue = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblAnzeigenRed = new System.Windows.Forms.Label();
            this.lblAnzeigenGreen = new System.Windows.Forms.Label();
            this.lblAnzeigenBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlColorChange
            // 
            this.pnlColorChange.Location = new System.Drawing.Point(423, 50);
            this.pnlColorChange.Name = "pnlColorChange";
            this.pnlColorChange.Size = new System.Drawing.Size(138, 141);
            this.pnlColorChange.TabIndex = 0;
            // 
            // trkRed
            // 
            this.trkRed.Location = new System.Drawing.Point(10, 36);
            this.trkRed.Maximum = 255;
            this.trkRed.Name = "trkRed";
            this.trkRed.Size = new System.Drawing.Size(341, 45);
            this.trkRed.TabIndex = 1;
            this.trkRed.ValueChanged += new System.EventHandler(this.FarbenGewechselt);
            // 
            // trkGreen
            // 
            this.trkGreen.Location = new System.Drawing.Point(10, 87);
            this.trkGreen.Maximum = 255;
            this.trkGreen.Name = "trkGreen";
            this.trkGreen.Size = new System.Drawing.Size(341, 45);
            this.trkGreen.TabIndex = 2;
            this.trkGreen.ValueChanged += new System.EventHandler(this.FarbenGewechselt);
            // 
            // trkBlue
            // 
            this.trkBlue.Location = new System.Drawing.Point(10, 146);
            this.trkBlue.Maximum = 255;
            this.trkBlue.Name = "trkBlue";
            this.trkBlue.Size = new System.Drawing.Size(341, 45);
            this.trkBlue.TabIndex = 3;
            this.trkBlue.ValueChanged += new System.EventHandler(this.FarbenGewechselt);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(357, 36);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(24, 13);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Rot";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(357, 87);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(30, 13);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Grün";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(357, 146);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blau";
            // 
            // lblAnzeigenRed
            // 
            this.lblAnzeigenRed.AutoSize = true;
            this.lblAnzeigenRed.Location = new System.Drawing.Point(357, 50);
            this.lblAnzeigenRed.Name = "lblAnzeigenRed";
            this.lblAnzeigenRed.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigenRed.TabIndex = 7;
            // 
            // lblAnzeigenGreen
            // 
            this.lblAnzeigenGreen.AutoSize = true;
            this.lblAnzeigenGreen.Location = new System.Drawing.Point(357, 100);
            this.lblAnzeigenGreen.Name = "lblAnzeigenGreen";
            this.lblAnzeigenGreen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigenGreen.TabIndex = 8;
            // 
            // lblAnzeigenBlue
            // 
            this.lblAnzeigenBlue.AutoSize = true;
            this.lblAnzeigenBlue.Location = new System.Drawing.Point(357, 159);
            this.lblAnzeigenBlue.Name = "lblAnzeigenBlue";
            this.lblAnzeigenBlue.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigenBlue.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 262);
            this.Controls.Add(this.lblAnzeigenBlue);
            this.Controls.Add(this.lblAnzeigenGreen);
            this.Controls.Add(this.lblAnzeigenRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trkBlue);
            this.Controls.Add(this.trkGreen);
            this.Controls.Add(this.trkRed);
            this.Controls.Add(this.pnlColorChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlColorChange;
        private System.Windows.Forms.TrackBar trkRed;
        private System.Windows.Forms.TrackBar trkGreen;
        private System.Windows.Forms.TrackBar trkBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblAnzeigenRed;
        private System.Windows.Forms.Label lblAnzeigenGreen;
        private System.Windows.Forms.Label lblAnzeigenBlue;
    }
}

