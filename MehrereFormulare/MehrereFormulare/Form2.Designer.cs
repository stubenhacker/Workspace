namespace MehrereFormulare
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtInputUnter = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdEndeUnter = new System.Windows.Forms.Button();
            this.chkUnterFormular = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInputUnter
            // 
            this.txtInputUnter.Location = new System.Drawing.Point(12, 56);
            this.txtInputUnter.Name = "txtInputUnter";
            this.txtInputUnter.Size = new System.Drawing.Size(186, 20);
            this.txtInputUnter.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cmdEndeUnter
            // 
            this.cmdEndeUnter.Location = new System.Drawing.Point(12, 140);
            this.cmdEndeUnter.Name = "cmdEndeUnter";
            this.cmdEndeUnter.Size = new System.Drawing.Size(116, 23);
            this.cmdEndeUnter.TabIndex = 2;
            this.cmdEndeUnter.Text = "Ende Unterformular";
            this.cmdEndeUnter.UseVisualStyleBackColor = true;
            this.cmdEndeUnter.Click += new System.EventHandler(this.cmdEndeUnter_Click);
            // 
            // chkUnterFormular
            // 
            this.chkUnterFormular.AutoSize = true;
            this.chkUnterFormular.Location = new System.Drawing.Point(12, 99);
            this.chkUnterFormular.Name = "chkUnterFormular";
            this.chkUnterFormular.Size = new System.Drawing.Size(141, 17);
            this.chkUnterFormular.TabIndex = 3;
            this.chkUnterFormular.Text = "CheckBox Unterformular";
            this.chkUnterFormular.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chkUnterFormular);
            this.Controls.Add(this.cmdEndeUnter);
            this.Controls.Add(this.txtInputUnter);
            this.Name = "Form2";
            this.Text = "Unterformular";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputUnter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button cmdEndeUnter;
        private System.Windows.Forms.CheckBox chkUnterFormular;
    }
}