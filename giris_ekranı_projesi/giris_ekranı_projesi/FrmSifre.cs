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
    public partial class FrmSifre : Form
    {
        public FrmSifre()
        {
            InitializeComponent();
        }
        KullanıcıFormu k = new KullanıcıFormu();
        private void BtnYeniSifre_Click(object sender, EventArgs e)
        {
            k.sifre(TxtAdSoyad,TxtYeniKullanıcıAd,TxtYeniKullanıcıSifre,TxtSifretekrar,TxtSoru,TxtCevap,groupBox2);

        }
    }
}
