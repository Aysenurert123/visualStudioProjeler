using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giris_ekranı_projesi
{
    public class Query
    {
        public const string loginSelectQuery = @"SELECT [AdSoyad]
      ,[KullaniciAdi]
      ,[KullaniciSifre]
      ,[Soru]
      ,[Cevap]
      ,[SifreHataSayisi]
      ,[SifreDegisimSuresi]
  FROM [Tbl_Kullanici] where KullaniciAdi=@kullaniciAdi";
        public const string sqlCon = @"Data Source=DESKTOP-BJ3G6VO\SQLEXPRESS;Initial Catalog=Kullanici_Giris;Integrated Security=True";
    }
}
