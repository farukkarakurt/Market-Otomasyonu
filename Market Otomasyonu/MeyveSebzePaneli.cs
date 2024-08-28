using AForge.Video.DirectShow;
using Market_Otomasyonu.Controller;
using Market_Otomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Market_Otomasyonu
{
    public partial class MeyveSebzePaneli : Form
    {

        int sayi1;
        int sayi2;
        int islemTip;

        public MeyveSebzePaneli()
        {
            InitializeComponent();
            txtBox_İslemEkranı.Text = "0";

        }
        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTip == 1)
            {
                sayi2 = int.Parse(txtBox_İslemEkranı.Text);
                txtBox_İslemEkranı.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2)
            {
                sayi2 = int.Parse(txtBox_İslemEkranı.Text);
                txtBox_İslemEkranı.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTip == 3)
            {
                sayi2 = int.Parse(txtBox_İslemEkranı.Text);
                txtBox_İslemEkranı.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTip == 4)
            {
                sayi2 = int.Parse(txtBox_İslemEkranı.Text);
                txtBox_İslemEkranı.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (txtBox_İslemEkranı.Text == "0")
            {
                txtBox_İslemEkranı.Text = "";
            }
            txtBox_İslemEkranı.Text += ((Button)sender).Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtBox_İslemEkranı.Text = "0";
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            islemTip = 1;// toplamyı temsil etsin
            sayi1 = int.Parse(txtBox_İslemEkranı.Text);
            txtBox_İslemEkranı.Text = "0";
        }

        private void btn_cıkartma_Click(object sender, EventArgs e)
        {
            islemTip = 2;// çıkartmayı temsil etsin
            sayi1 = int.Parse(txtBox_İslemEkranı.Text);
            txtBox_İslemEkranı.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemTip = 3;// çarpmayı temsil etsin
            sayi1 = int.Parse(txtBox_İslemEkranı.Text);
            txtBox_İslemEkranı.Text = "0";
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            islemTip = 4;// bölme temsil etsin
            sayi1 = int.Parse(txtBox_İslemEkranı.Text);
            txtBox_İslemEkranı.Text = "0";
        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            if (txtBox_İslemEkranı.Text.Length != 0)
            {
                txtBox_İslemEkranı.Text = txtBox_İslemEkranı.Text.Substring(0, txtBox_İslemEkranı.Text.Length - 1);
            }
            else
            {
                txtBox_İslemEkranı.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pxtBox_Kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pxtBox_Kamera.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    timer1.Stop();
                }
            }
        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void MeyveSebzePaneli_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                combo_kameraAç.Items.Add(camera.Name);
            }
        }

        private void btn_kameraAç_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[combo_kameraAç.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pxtBox_Kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void btn_kameraKapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pxtBox_Kamera.Image = Image.FromFile("C:\\Users\\faruk\\OneDrive\\Masaüstü\\Marekt işi\\market\\resimler\\camera.ico");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            Urun t_urun= userController.urunuGetir(textBox1.Text);
            lbl_urunIsim.Text=t_urun.ToString();
            if (t_urun != null)
            {
                txtBox_İslemEkranı.Text = t_urun.fiyat.ToString();
            }
            else
            {
                txtBox_İslemEkranı.Text = "Ürün bulunamadı";
            }
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = "Barkod.wav";
            sound.Play();
        }

        private void lbl_saat_Click(object sender, EventArgs e)
        {
                
        }

        private void MeyveSebzePaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vcd != null && vcd.IsRunning)
            {
                vcd.SignalToStop();
                vcd.WaitForStop();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            kasiyerPanel kasiyerPanel = new kasiyerPanel();
            kasiyerPanel.Show();
            this.Hide();
        }
    }
}
