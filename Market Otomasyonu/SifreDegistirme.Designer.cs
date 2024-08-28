namespace Market_Otomasyonu
{
    partial class SifreDegistirme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.cmbBox_GuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.txtBox_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txtBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBx_SifreDegistir = new System.Windows.Forms.GroupBox();
            this.btn_SifreDegistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtBox_yeniSifre = new System.Windows.Forms.TextBox();
            this.grpBox_MailAlanlı = new System.Windows.Forms.GroupBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.btn_kodGonder = new System.Windows.Forms.Button();
            this.txtBox_DogKodu = new System.Windows.Forms.TextBox();
            this.txtBox_eMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBx_SifreDegistir.SuspendLayout();
            this.grpBox_MailAlanlı.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_geri);
            this.groupBox1.Controls.Add(this.btn_Sorgula);
            this.groupBox1.Controls.Add(this.cmbBox_GuvenlikSorusu);
            this.groupBox1.Controls.Add(this.txtBox_guvenlikCevabi);
            this.groupBox1.Controls.Add(this.txtBox_KullaniciAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik Sorusu Yönetimi";
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Location = new System.Drawing.Point(20, 187);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(299, 28);
            this.btn_Sorgula.TabIndex = 3;
            this.btn_Sorgula.Text = "SORGULA";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // cmbBox_GuvenlikSorusu
            // 
            this.cmbBox_GuvenlikSorusu.FormattingEnabled = true;
            this.cmbBox_GuvenlikSorusu.Location = new System.Drawing.Point(133, 94);
            this.cmbBox_GuvenlikSorusu.Name = "cmbBox_GuvenlikSorusu";
            this.cmbBox_GuvenlikSorusu.Size = new System.Drawing.Size(186, 24);
            this.cmbBox_GuvenlikSorusu.TabIndex = 1;
            // 
            // txtBox_guvenlikCevabi
            // 
            this.txtBox_guvenlikCevabi.Location = new System.Drawing.Point(133, 140);
            this.txtBox_guvenlikCevabi.Name = "txtBox_guvenlikCevabi";
            this.txtBox_guvenlikCevabi.Size = new System.Drawing.Size(186, 22);
            this.txtBox_guvenlikCevabi.TabIndex = 2;
            // 
            // txtBox_KullaniciAdi
            // 
            this.txtBox_KullaniciAdi.Location = new System.Drawing.Point(133, 51);
            this.txtBox_KullaniciAdi.Name = "txtBox_KullaniciAdi";
            this.txtBox_KullaniciAdi.Size = new System.Drawing.Size(186, 22);
            this.txtBox_KullaniciAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // grpBx_SifreDegistir
            // 
            this.grpBx_SifreDegistir.Controls.Add(this.btn_SifreDegistir);
            this.grpBx_SifreDegistir.Controls.Add(this.label5);
            this.grpBx_SifreDegistir.Controls.Add(this.label4);
            this.grpBx_SifreDegistir.Controls.Add(this.txtBox_yeniSifreTekrar);
            this.grpBx_SifreDegistir.Controls.Add(this.txtBox_yeniSifre);
            this.grpBx_SifreDegistir.Location = new System.Drawing.Point(393, 233);
            this.grpBx_SifreDegistir.Name = "grpBx_SifreDegistir";
            this.grpBx_SifreDegistir.Size = new System.Drawing.Size(415, 212);
            this.grpBx_SifreDegistir.TabIndex = 3;
            this.grpBx_SifreDegistir.TabStop = false;
            this.grpBx_SifreDegistir.Text = "Şifre Değiştir";
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.Location = new System.Drawing.Point(228, 145);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(171, 26);
            this.btn_SifreDegistir.TabIndex = 2;
            this.btn_SifreDegistir.Text = "DEĞİŞTİR";
            this.btn_SifreDegistir.UseVisualStyleBackColor = true;
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yeni Şifre \r\nTekrar Giriniz :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni Şifre :";
            // 
            // txtBox_yeniSifreTekrar
            // 
            this.txtBox_yeniSifreTekrar.Location = new System.Drawing.Point(109, 105);
            this.txtBox_yeniSifreTekrar.Name = "txtBox_yeniSifreTekrar";
            this.txtBox_yeniSifreTekrar.Size = new System.Drawing.Size(290, 22);
            this.txtBox_yeniSifreTekrar.TabIndex = 1;
            // 
            // txtBox_yeniSifre
            // 
            this.txtBox_yeniSifre.Location = new System.Drawing.Point(109, 55);
            this.txtBox_yeniSifre.Name = "txtBox_yeniSifre";
            this.txtBox_yeniSifre.Size = new System.Drawing.Size(290, 22);
            this.txtBox_yeniSifre.TabIndex = 0;
            // 
            // grpBox_MailAlanlı
            // 
            this.grpBox_MailAlanlı.Controls.Add(this.btn_onayla);
            this.grpBox_MailAlanlı.Controls.Add(this.btn_kodGonder);
            this.grpBox_MailAlanlı.Controls.Add(this.txtBox_DogKodu);
            this.grpBox_MailAlanlı.Controls.Add(this.txtBox_eMail);
            this.grpBox_MailAlanlı.Controls.Add(this.label7);
            this.grpBox_MailAlanlı.Controls.Add(this.label6);
            this.grpBox_MailAlanlı.Location = new System.Drawing.Point(393, 25);
            this.grpBox_MailAlanlı.Name = "grpBox_MailAlanlı";
            this.grpBox_MailAlanlı.Size = new System.Drawing.Size(415, 202);
            this.grpBox_MailAlanlı.TabIndex = 1;
            this.grpBox_MailAlanlı.TabStop = false;
            this.grpBox_MailAlanlı.Text = "Mail Alanı";
            // 
            // btn_onayla
            // 
            this.btn_onayla.Location = new System.Drawing.Point(324, 123);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(75, 23);
            this.btn_onayla.TabIndex = 3;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // btn_kodGonder
            // 
            this.btn_kodGonder.Location = new System.Drawing.Point(228, 72);
            this.btn_kodGonder.Name = "btn_kodGonder";
            this.btn_kodGonder.Size = new System.Drawing.Size(171, 33);
            this.btn_kodGonder.TabIndex = 1;
            this.btn_kodGonder.Text = "Doğrulama Kodu Gönder";
            this.btn_kodGonder.UseVisualStyleBackColor = true;
            this.btn_kodGonder.Click += new System.EventHandler(this.btn_kodGonder_Click);
            // 
            // txtBox_DogKodu
            // 
            this.txtBox_DogKodu.Location = new System.Drawing.Point(131, 124);
            this.txtBox_DogKodu.Name = "txtBox_DogKodu";
            this.txtBox_DogKodu.Size = new System.Drawing.Size(187, 22);
            this.txtBox_DogKodu.TabIndex = 2;
            // 
            // txtBox_eMail
            // 
            this.txtBox_eMail.Location = new System.Drawing.Point(131, 38);
            this.txtBox_eMail.Name = "txtBox_eMail";
            this.txtBox_eMail.Size = new System.Drawing.Size(268, 22);
            this.txtBox_eMail.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doğrulama Kodu : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "E mail Adresi :";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(20, 358);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(107, 34);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.Text = "<< GERİ";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(824, 451);
            this.Controls.Add(this.grpBox_MailAlanlı);
            this.Controls.Add(this.grpBx_SifreDegistir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre Degistirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBx_SifreDegistir.ResumeLayout(false);
            this.grpBx_SifreDegistir.PerformLayout();
            this.grpBox_MailAlanlı.ResumeLayout(false);
            this.grpBox_MailAlanlı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Sorgula;
        private System.Windows.Forms.GroupBox grpBx_SifreDegistir;
        private System.Windows.Forms.Button btn_SifreDegistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_yeniSifreTekrar;
        private System.Windows.Forms.TextBox txtBox_yeniSifre;
        private System.Windows.Forms.ComboBox cmbBox_GuvenlikSorusu;
        private System.Windows.Forms.TextBox txtBox_guvenlikCevabi;
        private System.Windows.Forms.TextBox txtBox_KullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_MailAlanlı;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Button btn_kodGonder;
        private System.Windows.Forms.TextBox txtBox_DogKodu;
        private System.Windows.Forms.TextBox txtBox_eMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_geri;
    }
}