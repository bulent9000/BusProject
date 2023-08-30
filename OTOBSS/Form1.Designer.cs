namespace OTOBSS
{
    partial class Form1
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
            this.cmb_kalkisNoktasi = new System.Windows.Forms.ComboBox();
            this.cmb_varisNoktasi = new System.Windows.Forms.ComboBox();
            this.dtp_yolculukTarih = new System.Windows.Forms.DateTimePicker();
            this.lbl_kalkisNoktasi = new System.Windows.Forms.Label();
            this.lbl_varisNoktasi = new System.Windows.Forms.Label();
            this.lbl_yolculukTarihi = new System.Windows.Forms.Label();
            this.btn_biletBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_kalkisNoktasi
            // 
            this.cmb_kalkisNoktasi.FormattingEnabled = true;
            this.cmb_kalkisNoktasi.Location = new System.Drawing.Point(36, 51);
            this.cmb_kalkisNoktasi.Name = "cmb_kalkisNoktasi";
            this.cmb_kalkisNoktasi.Size = new System.Drawing.Size(209, 21);
            this.cmb_kalkisNoktasi.TabIndex = 0;
            // 
            // cmb_varisNoktasi
            // 
            this.cmb_varisNoktasi.FormattingEnabled = true;
            this.cmb_varisNoktasi.Location = new System.Drawing.Point(36, 109);
            this.cmb_varisNoktasi.Name = "cmb_varisNoktasi";
            this.cmb_varisNoktasi.Size = new System.Drawing.Size(209, 21);
            this.cmb_varisNoktasi.TabIndex = 1;
            // 
            // dtp_yolculukTarih
            // 
            this.dtp_yolculukTarih.Location = new System.Drawing.Point(36, 172);
            this.dtp_yolculukTarih.Name = "dtp_yolculukTarih";
            this.dtp_yolculukTarih.Size = new System.Drawing.Size(206, 20);
            this.dtp_yolculukTarih.TabIndex = 2;
            // 
            // lbl_kalkisNoktasi
            // 
            this.lbl_kalkisNoktasi.AutoSize = true;
            this.lbl_kalkisNoktasi.Location = new System.Drawing.Point(36, 26);
            this.lbl_kalkisNoktasi.Name = "lbl_kalkisNoktasi";
            this.lbl_kalkisNoktasi.Size = new System.Drawing.Size(74, 13);
            this.lbl_kalkisNoktasi.TabIndex = 3;
            this.lbl_kalkisNoktasi.Text = "Kalkış Noktası";
            // 
            // lbl_varisNoktasi
            // 
            this.lbl_varisNoktasi.AutoSize = true;
            this.lbl_varisNoktasi.Location = new System.Drawing.Point(36, 93);
            this.lbl_varisNoktasi.Name = "lbl_varisNoktasi";
            this.lbl_varisNoktasi.Size = new System.Drawing.Size(69, 13);
            this.lbl_varisNoktasi.TabIndex = 4;
            this.lbl_varisNoktasi.Text = "Varış Noktası";
            // 
            // lbl_yolculukTarihi
            // 
            this.lbl_yolculukTarihi.AutoSize = true;
            this.lbl_yolculukTarihi.Location = new System.Drawing.Point(36, 153);
            this.lbl_yolculukTarihi.Name = "lbl_yolculukTarihi";
            this.lbl_yolculukTarihi.Size = new System.Drawing.Size(77, 13);
            this.lbl_yolculukTarihi.TabIndex = 5;
            this.lbl_yolculukTarihi.Text = "Yolculuk Tarihi";
            // 
            // btn_biletBul
            // 
            this.btn_biletBul.BackColor = System.Drawing.Color.Lime;
            this.btn_biletBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_biletBul.ForeColor = System.Drawing.Color.White;
            this.btn_biletBul.Location = new System.Drawing.Point(36, 230);
            this.btn_biletBul.Name = "btn_biletBul";
            this.btn_biletBul.Size = new System.Drawing.Size(206, 49);
            this.btn_biletBul.TabIndex = 6;
            this.btn_biletBul.Text = "Otobüs Bileti Bul";
            this.btn_biletBul.UseVisualStyleBackColor = false;
            this.btn_biletBul.Click += new System.EventHandler(this.btn_biletBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 291);
            this.Controls.Add(this.btn_biletBul);
            this.Controls.Add(this.lbl_yolculukTarihi);
            this.Controls.Add(this.lbl_varisNoktasi);
            this.Controls.Add(this.lbl_kalkisNoktasi);
            this.Controls.Add(this.dtp_yolculukTarih);
            this.Controls.Add(this.cmb_varisNoktasi);
            this.Controls.Add(this.cmb_kalkisNoktasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_kalkisNoktasi;
        private System.Windows.Forms.ComboBox cmb_varisNoktasi;
        private System.Windows.Forms.DateTimePicker dtp_yolculukTarih;
        private System.Windows.Forms.Label lbl_kalkisNoktasi;
        private System.Windows.Forms.Label lbl_varisNoktasi;
        private System.Windows.Forms.Label lbl_yolculukTarihi;
        private System.Windows.Forms.Button btn_biletBul;
    }
}

