using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Dapper;

namespace giris_ekranı_projesi
{
    
    class KullanıcıFormu
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BJ3G6VO\\SQLEXPRESS;Initial Catalog=Kullanici_Giris;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        FrmYeni yeni = new FrmYeni();
       
        public int kullanici(string KullanıcıAdı, string KullanıcıSifre)
        {
            Kullanici kullanici = new Kullanici();
            DynamicParameters parameters = new DynamicParameters();
            using (var con = new SqlConnection(Query.sqlCon))
            {
                con.Open();
                parameters.Add("@kullaniciAdi", KullanıcıAdı);
                kullanici = con.Query<Kullanici>(Query.loginSelectQuery, parameters).FirstOrDefault();
            }

            if(kullanici != null && kullanici.KullaniciSifre == KullanıcıSifre)
            {
                if(kullanici.SifreDegisimSuresi <= DateTime.Now)
                {
                    FrmSifre sifre = new FrmSifre();
                    sifre.ShowDialog();
                }

                MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            else
            {
                
                if (kullanici == null)
                {
                    MessageBox.Show("Böyle bir kullanıcı yoktur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                parameters = new DynamicParameters();
                using (var con = new SqlConnection(Query.sqlCon))
                {
                    parameters.Add("@KullaniciAdi", KullanıcıAdı);
                    //Yanlış şifre girildiğinde şifre hata sayısını 1 artırır.
                    con.Execute("[SifreHataSayisiGuncelle]", parameters, commandType: System.Data.CommandType.StoredProcedure);
                    if (kullanici.SifreHataSayisi + 1 >= 3)
                    {
                        MessageBox.Show("Hesabınız blokeli.Lütfen Şifrenizi Sıfırlayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }
                    
                }

                MessageBox.Show("Şifrenizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
         
        }
        public int yenikullanici(string KullanıcıAdSoyad, string KullanıcıAdı, string KullanıcıSifre, string SifreTekrar, string soru, string cevap)
        {
            if (KullanıcıSifre != SifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

                Kullanici kullanici = new Kullanici();
            DynamicParameters parameters = new DynamicParameters();
            using (var con = new SqlConnection(Query.sqlCon))
            {
                con.Open();
                parameters.Add("@kullaniciAdi", KullanıcıAdı);
                kullanici = con.Query<Kullanici>(Query.loginSelectQuery, parameters).FirstOrDefault();
            }

            if  (kullanici != null)
            {
                MessageBox.Show("Bu kullanıcı zaten var.!.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }         
            else
            {
                    parameters = new DynamicParameters();
                    using (var con = new SqlConnection(Query.sqlCon))
                    {
                        con.Open();
                        parameters.Add("@AdSoyad", KullanıcıAdSoyad);
                        parameters.Add("@KullaniciAdi", KullanıcıAdı);
                        parameters.Add("@KullaniciSifre", KullanıcıSifre);
                        parameters.Add("@Soru", soru);
                        parameters.Add("@Cevap", cevap);
                        return con.Execute("AddUser", parameters, commandType: System.Data.CommandType.StoredProcedure);
                    }  
                                     
            }
        }
        
        public void sifre(TextBox KullanıcıAdSoyad, TextBox KullanıcıAdı, TextBox KullanıcıSifre, TextBox KullanıcıSifreTekrar, TextBox Soru, TextBox Cevap, GroupBox Grup)
          
        {
            if (KullanıcıSifre.Text == KullanıcıSifreTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("Select * From Tbl_Kullanıcı where KullanıcıAdı ='" + KullanıcıAdı.Text + "'", baglanti);
                read = komut.ExecuteReader();
             
                if (read.Read() == true)
                {
                    if (Soru.Text == read["soru"].ToString() && Cevap.Text == read["cevap"].ToString())
                    {
                        baglanti.Close();
                        baglanti.Open(); 
                        komut = new SqlCommand("update Tbl_Kullanıcı set SifreDegisimSuresi = " +(DateTime.Now.Month + 3)  + " AdSoyad='" + KullanıcıAdSoyad.Text + "',KullanıcıSifre='" + KullanıcıSifre.Text + "'where KullanıcıAdı='" + KullanıcıAdı.Text + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (Control item in Grup.Controls) if (item is TextBox) item.Text = "";
                    }
                    else
                    {
                           MessageBox.Show("Kullanıcı adı hariç diğer bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                  baglanti.Close();
            }

            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}

 

