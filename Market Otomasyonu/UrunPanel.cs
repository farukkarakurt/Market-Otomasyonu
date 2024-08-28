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
    public partial class UrunPanel : Form
    {

        UserController controller = new UserController();

        public UrunPanel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            defaultAlanlarıDoldur();
            tumUrunleriGetir();
        }
        public void defaultAlanlarıDoldur()
        {
            combo_UrunIsım.Items.Add("Brokoli");
            combo_UrunIsım.Items.Add("Çilek");
            combo_UrunIsım.Items.Add("Elma");
            combo_UrunIsım.Items.Add("Lahana");
            combo_UrunIsım.Items.Add("Muz");
            combo_UrunIsım.Items.Add("Portakal");
            combo_UrunIsım.Items.Add("Üzüm");

        }
        public void tumUrunleriGetir()
        {
            Controller.UserController controller = new Controller.UserController();
            dataGridViewUrun.DataSource = controller.tumUrunleriGetir();
        }

        private void btn_geriGelme_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            Urun urun = new Urun();

            urun.id = txt_id.Text;
            urun.qrKod = txtBox_qrKod.Text;
            urun.barkod = txtBox_barkod.Text;
            urun.olusturulma_tarihi = dateTimePicker_Olusuturulma.Value;
            urun.guncellem_Tarih = dateTimePicker_Guncelleme.Value;
            urun.UrunIsim = combo_UrunIsım.Text;
            urun.kilo = int.Parse(txtBox_Kilo.Text);
            urun.fiyat = int.Parse(txtBox_Fiyat.Text);
            urun.ciro = int.Parse(txtBox_Ciro.Text);

            LoginStatus sonuc = controller.urunEkle(urun);

            if (sonuc == LoginStatus.Başarılı)
            {
                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewUrun.DataSource = controller.tumUrunleriGetir();
            }
            else if (sonuc == LoginStatus.Başarısız)
            {
                MessageBox.Show("Ürün Eklenemedi :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Eksik bir bilgi girişi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void dataGridViewUrun_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridViewUrun.CurrentRow.Cells[0].Value.ToString();
            txtBox_qrKod.Text = dataGridViewUrun.CurrentRow.Cells[1].Value.ToString();
            txtBox_barkod.Text = dataGridViewUrun.CurrentRow.Cells[2].Value.ToString();
            combo_UrunIsım.Text = dataGridViewUrun.CurrentRow.Cells[5].Value.ToString();
            txtBox_Ciro.Text = dataGridViewUrun.CurrentRow.Cells[8].Value.ToString();
            //if (!string.IsNullOrEmpty(dataGridViewUrun.CurrentRow.Cells[4].Value.ToString()))
            //{
            //    dateTimePicker_Guncelleme.Value = DateTime.Parse(dataGridViewUrun.CurrentRow.Cells[4].Value.ToString());

            //}
            dateTimePicker_Olusuturulma.Value = DateTime.Parse(dataGridViewUrun.CurrentRow.Cells[3].Value.ToString());
            txtBox_Kilo.Text = dataGridViewUrun.CurrentRow.Cells[6].Value.ToString();
            txtBox_Fiyat.Text = dataGridViewUrun.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();

            urun.id = txt_id.Text;
            urun.qrKod = txtBox_qrKod.Text;
            urun.barkod = txtBox_barkod.Text;
            urun.olusturulma_tarihi = dateTimePicker_Olusuturulma.Value;
            urun.guncellem_Tarih = dateTimePicker_Guncelleme.Value;
            urun.UrunIsim = combo_UrunIsım.Text;
            urun.fiyat = int.Parse(txtBox_Fiyat.Text);
            urun.kilo = int.Parse(txtBox_Kilo.Text);
            urun.ciro = int.Parse(txtBox_Ciro.Text);
            LoginStatus sonuc = controller.UrunGuncelle(urun);


            if (sonuc == LoginStatus.Başarılı)
            {
                MessageBox.Show("Ürün Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewUrun.DataSource = controller.tumUrunleriGetir();
            }
            else if (sonuc == LoginStatus.Başarısız)
            {
                MessageBox.Show("Ürün Güncellenemedi :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Eksik bir bilgi girişi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.UrunSilme(txt_id.Text);
                if (sonuc==LoginStatus.Başarılı)
                {
                    MessageBox.Show("İşlem Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewUrun.DataSource = controller.tumUrunleriGetir();
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz !", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
