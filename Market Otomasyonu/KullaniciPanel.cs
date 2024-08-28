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
    public partial class KullaniciPanel : Form
    {
        UserController controller = new UserController();
        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            DefaultHazırBilgiler();

            tumKullanicilariDoldur();
        }
        private void DefaultHazırBilgiler()
        {
            combo_bolge.Items.Add("Adalar");
            combo_bolge.Items.Add("Arnavutköy");
            combo_bolge.Items.Add("Bağcılar");
            combo_bolge.Items.Add("Bakırköy");
            combo_bolge.Items.Add("Bağcılar");
            combo_bolge.Items.Add("Esenyurt");
            combo_bolge.Items.Add("Kasımpaşa");
            combo_bolge.Items.Add("Kadıköy");
            combo_bolge.Items.Add("Küçükçekmece");
            combo_bolge.SelectedIndex = 0;
            //-----------------------------------------------

            combo_yetki.Items.Add("Admin");
            combo_yetki.Items.Add("Kasiyer");
            combo_yetki.SelectedIndex = 0;
            //-----------------------------------------------

            combo_guvenlikSorusu.Items.Add("En Sevdiğin Renk Nedir ?");
            combo_guvenlikSorusu.Items.Add("En sevdiğin araba nedir ?");
            combo_guvenlikSorusu.Items.Add("Birinci sınıf öğretmen adınız nedir?");
            combo_guvenlikSorusu.Items.Add("En sevdiğiniz hayvanın adı nedir ?");
            combo_guvenlikSorusu.Items.Add("Annenizin kızlık soyadı nedir ?");
            combo_guvenlikSorusu.Items.Add("Hangi şehirde doğdunuz ?");
            combo_guvenlikSorusu.Items.Add("Babanızın isminin ortanca harfi nedir ?");
            combo_guvenlikSorusu.Items.Add("Çocukluk lakabınız nedir ?");
            combo_guvenlikSorusu.Items.Add("İlk telefonunun markası nedir ?");
            combo_guvenlikSorusu.SelectedIndex = 0;


        }
        private void tumKullanicilariDoldur()
        {

            List<User> kullaniciGetirme = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = kullaniciGetirme;

        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.kulaniciAdi = txtBox_kullaniciAdi.Text;
            user.sifre = txtBox_sifre.Text;
            user.yetki = combo_yetki.Text;
            user.bolge = combo_bolge.Text;
            user.email = txtBox_email.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.Text;
            user.guvenlikCevabi = txtBox_guvenlikCevabi.Text;

            LoginStatus sonuc = controller.KullaniciEkle(user);
            if (sonuc == LoginStatus.Başarılı)
            {
                MessageBox.Show("Kayıt Başarılı :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBox_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combo_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combo_bolge.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBox_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combo_guvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBox_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txt_id.Text);
            user.kulaniciAdi = txtBox_kullaniciAdi.Text;
            user.sifre = txtBox_sifre.Text;
            user.yetki = combo_yetki.Text;
            user.bolge = combo_bolge.Text;
            user.email = txtBox_email.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.Text;
            user.guvenlikCevabi = txtBox_guvenlikCevabi.Text;

            LoginStatus sonuc = controller.KayitGuncelleme(user);

            if (sonuc == LoginStatus.Başarılı)
            {
                MessageBox.Show("Güncelleme Başarılı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.KayitlariSil(int.Parse(txt_id.Text));

                if (sonuc == LoginStatus.Başarılı)
                {
                    MessageBox.Show("Kayıt Silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource=controller.tumKullanicilariGetir();
                }
                else
                {
                    MessageBox.Show("Kayıt silme işleminde bir hata oldu. Lütfen Tekrar Deneyin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kayıt silme işleminde bir hata oldu. Lütfen Tekrar Deneyin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btn_geriGelme_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
