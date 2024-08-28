using Market_Otomasyonu.Controller;
using Market_Otomasyonu.enumaration;
using Market_Otomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            User result = controller.login(txt_kullaniciAdi.Text, txt_sifre.Text);

            if (result != null && result.status == LoginStatus.Başarılı && result.yetki == "Admin")
            {
                //admin sayfasına gönder
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();

            }
            else if (result != null && result.status == LoginStatus.Başarılı && result.yetki == "Kasiyer")
            {
                //kasiyer sayfasına göndersin
                kasiyerPanel kasiyerPanel = new kasiyerPanel();
                kasiyerPanel.Show();
                this.Hide();
            }
            else if (result!=null && result.status == LoginStatus.Başarısız)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre hatası","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.Show();
            this.Hide();
        }
    }
}
