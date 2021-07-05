
namespace garantiTakip
{
    partial class FrmAra
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
            this.txtFirmaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYetkiliAdSoyad = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirmaNo
            // 
            this.txtFirmaNo.ForeColor = System.Drawing.Color.Black;
            this.txtFirmaNo.Location = new System.Drawing.Point(160, 60);
            this.txtFirmaNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirmaNo.Name = "txtFirmaNo";
            this.txtFirmaNo.Size = new System.Drawing.Size(244, 28);
            this.txtFirmaNo.TabIndex = 0;
            
            this.txtFirmaNo.Enter += new System.EventHandler(this.txtFirmaNo_Enter);
            this.txtFirmaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma Adı:";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(162, 124);
            this.txtFirmaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(242, 28);
            this.txtFirmaAdi.TabIndex = 1;
            this.txtFirmaAdi.Enter += new System.EventHandler(this.txtFirmaAdi_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yetkili Ad-Soyad:";
            // 
            // txtYetkiliAdSoyad
            // 
            this.txtYetkiliAdSoyad.Location = new System.Drawing.Point(162, 181);
            this.txtYetkiliAdSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYetkiliAdSoyad.Name = "txtYetkiliAdSoyad";
            this.txtYetkiliAdSoyad.Size = new System.Drawing.Size(242, 28);
            this.txtYetkiliAdSoyad.TabIndex = 2;
            this.txtYetkiliAdSoyad.Enter += new System.EventHandler(this.txtYetkiliAdSoyad_Enter);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(477, 60);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(166, 30);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 294);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYetkiliAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirmaNo);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAra";
            this.Text = "FrmAra";
            this.Load += new System.EventHandler(this.FrmAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirmaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYetkiliAdSoyad;
        private System.Windows.Forms.Button btnAra;
    }
}