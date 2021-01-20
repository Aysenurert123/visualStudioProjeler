using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giris_ekranı_projesi
{
    public class Kullanici
    {
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public string Soru { get; set; }
        public string Cevap { get; set; }
        public int SifreHataSayisi { get; set; }
        public DateTime SifreDegisimSuresi { get; set; }
    }
}
