namespace Market_Otomasyonu
{
    partial class KullaniciPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_geriGelme = new System.Windows.Forms.Button();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.combo_bolge = new System.Windows.Forms.ComboBox();
            this.combo_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_sifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(891, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtBox_kullaniciAdi
            // 
            this.txtBox_kullaniciAdi.Location = new System.Drawing.Point(186, 85);
            this.txtBox_kullaniciAdi.Name = "txtBox_kullaniciAdi";
            this.txtBox_kullaniciAdi.Size = new System.Drawing.Size(148, 22);
            this.txtBox_kullaniciAdi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_geriGelme);
            this.groupBox1.Controls.Add(this.btn_kayitSil);
            this.groupBox1.Controls.Add(this.btn_kayitGuncelle);
            this.groupBox1.Controls.Add(this.btn_kayitEkle);
            this.groupBox1.Controls.Add(this.combo_bolge);
            this.groupBox1.Controls.Add(this.combo_guvenlikSorusu);
            this.groupBox1.Controls.Add(this.combo_yetki);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBox_guvenlikCevabi);
            this.groupBox1.Controls.Add(this.txtBox_email);
            this.groupBox1.Controls.Add(this.txtBox_sifre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBox_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Panel";
            // 
            // btn_geriGelme
            // 
            this.btn_geriGelme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geriGelme.Location = new System.Drawing.Point(62, 234);
            this.btn_geriGelme.Name = "btn_geriGelme";
            this.btn_geriGelme.Size = new System.Drawing.Size(95, 48);
            this.btn_geriGelme.TabIndex = 10;
            this.btn_geriGelme.Text = "Önceki Sayfa";
            this.btn_geriGelme.UseVisualStyleBackColor = true;
            this.btn_geriGelme.Click += new System.EventHandler(this.btn_geriGelme_Click);
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitSil.Location = new System.Drawing.Point(605, 234);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(215, 49);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(384, 234);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(215, 49);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkle.Location = new System.Drawing.Point(163, 234);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(215, 49);
            this.btn_kayitEkle.TabIndex = 7;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // combo_bolge
            // 
            this.combo_bolge.FormattingEnabled = true;
            this.combo_bolge.Location = new System.Drawing.Point(557, 174);
            this.combo_bolge.Name = "combo_bolge";
            this.combo_bolge.Size = new System.Drawing.Size(182, 24);
            this.combo_bolge.TabIndex = 3;
            // 
            // combo_guvenlikSorusu
            // 
            this.combo_guvenlikSorusu.FormattingEnabled = true;
            this.combo_guvenlikSorusu.Location = new System.Drawing.Point(557, 83);
            this.combo_guvenlikSorusu.Name = "combo_guvenlikSorusu";
            this.combo_guvenlikSorusu.Size = new System.Drawing.Size(263, 24);
            this.combo_guvenlikSorusu.TabIndex = 5;
            // 
            // combo_yetki
            // 
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Location = new System.Drawing.Point(152, 174);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(182, 24);
            this.combo_yetki.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(398, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bölge :";
            // 
            // txtBox_guvenlikCevabi
            // 
            this.txtBox_guvenlikCevabi.Location = new System.Drawing.Point(557, 120);
            this.txtBox_guvenlikCevabi.Name = "txtBox_guvenlikCevabi";
            this.txtBox_guvenlikCevabi.Size = new System.Drawing.Size(263, 22);
            this.txtBox_guvenlikCevabi.TabIndex = 6;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(524, 46);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(296, 22);
            this.txtBox_email.TabIndex = 4;
            // 
            // txtBox_sifre
            // 
            this.txtBox_sifre.Location = new System.Drawing.Point(152, 125);
            this.txtBox_sifre.Name = "txtBox_sifre";
            this.txtBox_sifre.Size = new System.Drawing.Size(182, 22);
            this.txtBox_sifre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(398, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Güvenlik Cevabı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(398, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Güvenlik Sorusu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(398, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yetki :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(186, 50);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(148, 22);
            this.txt_id.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(55, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID :";
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(915, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_kullaniciAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.ComboBox combo_bolge;
        private System.Windows.Forms.ComboBox combo_guvenlikSorusu;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_guvenlikCevabi;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_sifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_geriGelme;
    }
}