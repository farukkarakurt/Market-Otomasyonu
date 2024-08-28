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
    public partial class kasiyerPanel : Form
    {
        public kasiyerPanel()
        {
            InitializeComponent();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbl_saat.Text = DateTime.Now.Hour.ToString();
            //lbl_dakika.Text = DateTime.Now.Minute.ToString() ;
            //lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void kasiyerPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbl_dakika_Click(object sender, EventArgs e)
        {
            ///////
        }

        private void btn_sebzeMeyve_Click(object sender, EventArgs e)
        {
            MeyveSebzePaneli meyveSebzePaneli = new MeyveSebzePaneli();
            meyveSebzePaneli.Show();
            this.Hide();
        }
    }
}
