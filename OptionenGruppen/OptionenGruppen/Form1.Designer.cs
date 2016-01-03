namespace OptionenGruppen
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
            this.gbUrlaubsort = new System.Windows.Forms.GroupBox();
            this.rbRom = new System.Windows.Forms.RadioButton();
            this.rbParis = new System.Windows.Forms.RadioButton();
            this.rbBerlin = new System.Windows.Forms.RadioButton();
            this.gbUnterkunft = new System.Windows.Forms.GroupBox();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.rbPension = new System.Windows.Forms.RadioButton();
            this.rbAppartment = new System.Windows.Forms.RadioButton();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.gbUrlaubsort.SuspendLayout();
            this.gbUnterkunft.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUrlaubsort
            // 
            this.gbUrlaubsort.Controls.Add(this.rbRom);
            this.gbUrlaubsort.Controls.Add(this.rbParis);
            this.gbUrlaubsort.Controls.Add(this.rbBerlin);
            this.gbUrlaubsort.Location = new System.Drawing.Point(12, 108);
            this.gbUrlaubsort.Name = "gbUrlaubsort";
            this.gbUrlaubsort.Size = new System.Drawing.Size(119, 97);
            this.gbUrlaubsort.TabIndex = 0;
            this.gbUrlaubsort.TabStop = false;
            this.gbUrlaubsort.Text = "Urlaubsort";
            // 
            // rbRom
            // 
            this.rbRom.AutoSize = true;
            this.rbRom.Location = new System.Drawing.Point(11, 74);
            this.rbRom.Name = "rbRom";
            this.rbRom.Size = new System.Drawing.Size(47, 17);
            this.rbRom.TabIndex = 2;
            this.rbRom.Text = "Rom";
            this.rbRom.UseVisualStyleBackColor = true;
            this.rbRom.CheckedChanged += new System.EventHandler(this.grpUrlaubsort_CheckedChanged);
            // 
            // rbParis
            // 
            this.rbParis.AutoSize = true;
            this.rbParis.Location = new System.Drawing.Point(11, 51);
            this.rbParis.Name = "rbParis";
            this.rbParis.Size = new System.Drawing.Size(48, 17);
            this.rbParis.TabIndex = 1;
            this.rbParis.Text = "Paris";
            this.rbParis.UseVisualStyleBackColor = true;
            this.rbParis.CheckedChanged += new System.EventHandler(this.grpUrlaubsort_CheckedChanged);
            // 
            // rbBerlin
            // 
            this.rbBerlin.AutoSize = true;
            this.rbBerlin.Checked = true;
            this.rbBerlin.Location = new System.Drawing.Point(11, 28);
            this.rbBerlin.Name = "rbBerlin";
            this.rbBerlin.Size = new System.Drawing.Size(51, 17);
            this.rbBerlin.TabIndex = 0;
            this.rbBerlin.TabStop = true;
            this.rbBerlin.Text = "Berlin";
            this.rbBerlin.UseVisualStyleBackColor = true;
            this.rbBerlin.CheckedChanged += new System.EventHandler(this.grpUrlaubsort_CheckedChanged);
            // 
            // gbUnterkunft
            // 
            this.gbUnterkunft.Controls.Add(this.rbHotel);
            this.gbUnterkunft.Controls.Add(this.rbPension);
            this.gbUnterkunft.Controls.Add(this.rbAppartment);
            this.gbUnterkunft.Location = new System.Drawing.Point(213, 108);
            this.gbUnterkunft.Name = "gbUnterkunft";
            this.gbUnterkunft.Size = new System.Drawing.Size(131, 100);
            this.gbUnterkunft.TabIndex = 1;
            this.gbUnterkunft.TabStop = false;
            this.gbUnterkunft.Text = "Unterkunft";
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(12, 77);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(50, 17);
            this.rbHotel.TabIndex = 2;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            this.rbHotel.CheckedChanged += new System.EventHandler(this.grpUnterkunft_CheckedChanged);
            // 
            // rbPension
            // 
            this.rbPension.AutoSize = true;
            this.rbPension.Checked = true;
            this.rbPension.Location = new System.Drawing.Point(12, 54);
            this.rbPension.Name = "rbPension";
            this.rbPension.Size = new System.Drawing.Size(63, 17);
            this.rbPension.TabIndex = 1;
            this.rbPension.TabStop = true;
            this.rbPension.Text = "Pension";
            this.rbPension.UseVisualStyleBackColor = true;
            this.rbPension.CheckedChanged += new System.EventHandler(this.grpUnterkunft_CheckedChanged);
            // 
            // rbAppartment
            // 
            this.rbAppartment.AutoSize = true;
            this.rbAppartment.Location = new System.Drawing.Point(12, 31);
            this.rbAppartment.Name = "rbAppartment";
            this.rbAppartment.Size = new System.Drawing.Size(79, 17);
            this.rbAppartment.TabIndex = 0;
            this.rbAppartment.Text = "Appartment";
            this.rbAppartment.UseVisualStyleBackColor = true;
            this.rbAppartment.CheckedChanged += new System.EventHandler(this.grpUnterkunft_CheckedChanged);
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(20, 42);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeigen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.gbUnterkunft);
            this.Controls.Add(this.gbUrlaubsort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbUrlaubsort.ResumeLayout(false);
            this.gbUrlaubsort.PerformLayout();
            this.gbUnterkunft.ResumeLayout(false);
            this.gbUnterkunft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUrlaubsort;
        private System.Windows.Forms.RadioButton rbRom;
        private System.Windows.Forms.RadioButton rbParis;
        private System.Windows.Forms.RadioButton rbBerlin;
        private System.Windows.Forms.GroupBox gbUnterkunft;
        private System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.RadioButton rbPension;
        private System.Windows.Forms.RadioButton rbAppartment;
        private System.Windows.Forms.Label lblAnzeigen;
    }
}

