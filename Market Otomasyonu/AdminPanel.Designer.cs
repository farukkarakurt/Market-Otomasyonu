namespace Market_Otomasyonu
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kullanici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_kullanici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kullanici.ImageIndex = 0;
            this.btn_kullanici.ImageList = this.ımageList1;
            this.btn_kullanici.Location = new System.Drawing.Point(12, 87);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(104, 95);
            this.btn_kullanici.TabIndex = 0;
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-User-Group.ico");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_Shipping8_62597.ico");
            this.ımageList1.Images.SetKeyName(2, "cikis.ico");
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(139, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 95);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(83, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 95);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(168, 34);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(21, 16);
            this.lbl_saat.TabIndex = 1;
            this.lbl_saat.Text = "00";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(195, 34);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(21, 16);
            this.lbl_dakika.TabIndex = 1;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(222, 34);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(21, 16);
            this.lbl_saniye.TabIndex = 1;
            this.lbl_saniye.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
    }
}