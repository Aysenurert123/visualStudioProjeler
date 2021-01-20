using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayac;
            sayac = 0;
            sayac = sayac + 1;
            if (sayac < 7)
            {
                MessageBox.Show("Tekrar Deneyiniz", "Hata4", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesabınız Blokelidir", "Hata5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
