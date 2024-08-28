namespace Market_Otomasyonu
{
    partial class kasiyerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_baklagil = new System.Windows.Forms.Button();
            this.btn_sebzeMeyve = new System.Windows.Forms.Button();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageKey = "Google-Noto-Emoji-Food-Drink-32380-cut-of-meat.ico";
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(54, 75);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(145, 148);
            this.btn_et.TabIndex = 0;
            this.btn_et.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Iconsmind-Outline-Cow.ico");
            this.ımageList1.Images.SetKeyName(1, "Iconshow-Agriculture-Fruits-Vegetables.ico");
            this.ımageList1.Images.SetKeyName(2, "Google-Noto-Emoji-Food-Drink-32380-cut-of-meat.ico");
            this.ımageList1.Images.SetKeyName(3, "Graphicloads-Food-Drink-Coffee-bean.ico");
            // 
            // btn_sut
            // 
            this.btn_sut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_sut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sut.ImageKey = "Iconsmind-Outline-Cow.ico";
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(227, 75);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(145, 148);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = false;
            // 
            // btn_baklagil
            // 
            this.btn_baklagil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_baklagil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baklagil.ImageIndex = 3;
            this.btn_baklagil.ImageList = this.ımageList1;
            this.btn_baklagil.Location = new System.Drawing.Point(227, 229);
            this.btn_baklagil.Name = "btn_baklagil";
            this.btn_baklagil.Size = new System.Drawing.Size(145, 148);
            this.btn_baklagil.TabIndex = 3;
            this.btn_baklagil.UseVisualStyleBackColor = false;
            // 
            // btn_sebzeMeyve
            // 
            this.btn_sebzeMeyve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_sebzeMeyve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sebzeMeyve.ImageIndex = 1;
            this.btn_sebzeMeyve.ImageList = this.ımageList1;
            this.btn_sebzeMeyve.Location = new System.Drawing.Point(54, 229);
            this.btn_sebzeMeyve.Name = "btn_sebzeMeyve";
            this.btn_sebzeMeyve.Size = new System.Drawing.Size(145, 148);
            this.btn_sebzeMeyve.TabIndex = 2;
            this.btn_sebzeMeyve.UseVisualStyleBackColor = false;
            this.btn_sebzeMeyve.Click += new System.EventHandler(this.btn_sebzeMeyve_Click);
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(54, 408);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(94, 31);
            this.btn_cıkıs.TabIndex = 4;
            this.btn_cıkıs.Text = "Çıkış Yap";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(427, 475);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.btn_sebzeMeyve);
            this.Controls.Add(this.btn_baklagil);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasiyer Panel";
            this.Load += new System.EventHandler(this.kasiyerPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_baklagil;
        private System.Windows.Forms.Button btn_sebzeMeyve;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.Timer timer1;
    }
}