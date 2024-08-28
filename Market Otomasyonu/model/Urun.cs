using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.model
{
    public class Urun
    {
        public string id { get; set; }
        public string qrKod { get; set; }
        public string barkod { get; set; }
        public DateTime olusturulma_tarihi { get; set; }
        public DateTime guncellem_Tarih { get; set; }
        public string UrunIsim { get; set; }
        public int kilo { get; set; }
        public int fiyat { get; set; }
        public int ciro { get; set; }
    }
}
