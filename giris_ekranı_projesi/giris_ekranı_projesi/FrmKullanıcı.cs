using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giris_ekranı_projesi
{
    public partial class FrmKullanıcı : Form
    {
        public FrmKullanıcı()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifre sifre = new FrmSifre();
            sifre.ShowDialog();

        }
        KullanıcıFormu k = new KullanıcıFormu();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (k.kullanici(TxtKullanıcıad.Text, TxtSifre.Text) != 0)
            {
                FrmYeni yeni = new FrmYeni();
                yeni.Show();
            }
            
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if(k.yenikullanici(TxtAdSoyad.Text, TxtYeniKullanıcıAd.Text, TxtYeniKullanıcıSifre.Text, TxtSifretekrar.Text, TxtSoru.Text, TxtCevap.Text) == 1)
            {
                MessageBox.Show("Üye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";  
                FrmYeni yeni = new FrmYeni();
                yeni.Show();
            }
            else
            {
                
            }

        }
    }
}

     
