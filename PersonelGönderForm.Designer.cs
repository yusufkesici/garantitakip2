﻿
namespace garantiTakip
{
    partial class PersonelGönderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPersonelGönder = new System.Windows.Forms.Button();
            this.PersonelCıkıs = new System.Windows.Forms.DateTimePicker();
            this.PersonelDonus = new System.Windows.Forms.DateTimePicker();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Seç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Çıkış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel Dönüş:";
            // 
            // btnPersonelGönder
            // 
            this.btnPersonelGönder.Location = new System.Drawing.Point(298, 220);
            this.btnPersonelGönder.Name = "btnPersonelGönder";
            this.btnPersonelGönder.Size = new System.Drawing.Size(175, 38);
            this.btnPersonelGönder.TabIndex = 4;
            this.btnPersonelGönder.Text = "Gönder";
            this.btnPersonelGönder.UseVisualStyleBackColor = true;
            this.btnPersonelGönder.Click += new System.EventHandler(this.btnPersonelGönder_Click);
            // 
            // PersonelCıkıs
            // 
            this.PersonelCıkıs.Location = new System.Drawing.Point(298, 118);
            this.PersonelCıkıs.Name = "PersonelCıkıs";
            this.PersonelCıkıs.Size = new System.Drawing.Size(277, 32);
            this.PersonelCıkıs.TabIndex = 5;
            // 
            // PersonelDonus
            // 
            this.PersonelDonus.Location = new System.Drawing.Point(298, 157);
            this.PersonelDonus.Name = "PersonelDonus";
            this.PersonelDonus.Size = new System.Drawing.Size(277, 32);
            this.PersonelDonus.TabIndex = 6;
            // 
            // txtFirma
            // 
            this.txtFirma.Enabled = false;
            this.txtFirma.Location = new System.Drawing.Point(298, 44);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(277, 32);
            this.txtFirma.TabIndex = 7;
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Location = new System.Drawing.Point(298, 83);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(277, 32);
            this.comboPersoneller.TabIndex = 8;
            // 
            // PersonelGönderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 301);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.PersonelDonus);
            this.Controls.Add(this.PersonelCıkıs);
            this.Controls.Add(this.btnPersonelGönder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonelGönderForm";
            this.Text = "PersonelGönderForm";
            this.Load += new System.EventHandler(this.PersonelGönderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersonelGönder;
        private System.Windows.Forms.DateTimePicker PersonelCıkıs;
        private System.Windows.Forms.DateTimePicker PersonelDonus;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.ComboBox comboPersoneller;
    }
}