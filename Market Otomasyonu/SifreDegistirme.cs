using Market_Otomasyonu.Controller;
using Market_Otomasyonu.enumaration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu
{
    public partial class SifreDegistirme : Form
    {
        int code;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            List<LoginTable> loginTableList = userController.getLoginTable();

            grpBox_MailAlanlı.Enabled = false;
            grpBx_SifreDegistir.Enabled = false;

            foreach (LoginTable loginTable in loginTableList)
            {
                cmbBox_GuvenlikSorusu.Items.Add(loginTable.guvenlikSorusu);
            }
            cmbBox_GuvenlikSorusu.SelectedIndex = 0;
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            LoginStatus result = userController.doAuthentication(txtBox_KullaniciAdi.Text.Trim().ToLower(), cmbBox_GuvenlikSorusu.SelectedItem.ToString(), txtBox_guvenlikCevabi.Text.Trim().ToLower());

            if (result == LoginStatus.Başarılı)
            {
                grpBox_MailAlanlı.Enabled = true;

            }
            else if (result == LoginStatus.Başarısız)
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpBox_MailAlanlı.Enabled = false;

            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgileri eskik !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_kodGonder_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            string emailAdress = controller.checkEmailAdress(txtBox_KullaniciAdi.Text);

            if (emailAdress == txtBox_eMail.Text)
            {
                Random rdn = new Random();
                code = rdn.Next(111111, 999999);

                MailAddress mailAlan = new MailAddress(txtBox_eMail.Text, txtBox_KullaniciAdi.Text);
                MailAddress mailGonderen = new MailAddress("farukkarakurt.99@hotmail.com", "Enes");
                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme";
                mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz:" + code;

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("farukkarakurt.99@hotmail.com", "Sinop.0368"); // şifreyi igönderen kişinin e posta ve şifresini göderildiği
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                MessageBox.Show("Doğrulama Kodu Gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesabınıza bağlı mail adresi giriniz","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (txtBox_DogKodu.Text == code.ToString())
            {
                grpBx_SifreDegistir.Enabled = true;

            }
            else
            {
                grpBx_SifreDegistir.Enabled = false;

                MessageBox.Show("Girdiğiniz doğrulama kodu yanlıştır. Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            UserController userControl = new UserController();

            if (txtBox_yeniSifre.Text == txtBox_yeniSifreTekrar.Text)
            {
                LoginStatus result = userControl.changePassword(txtBox_KullaniciAdi.Text, txtBox_yeniSifre.Text);

                if (result == LoginStatus.Başarılı)
                {
                    MessageBox.Show("Şifreniz değiştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli yerleri doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("İki şifre birbiri ile aynı değil ! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
