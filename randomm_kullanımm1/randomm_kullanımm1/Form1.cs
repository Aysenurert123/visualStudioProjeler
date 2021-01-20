using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomm_kullanımm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int sayi;
            //sayi = rnd.Next(1, 10);
            //label1.Text = sayi.ToString();

            Random rd = new Random();
            int s1, s2, s3;
            s1 = rd.Next(1, 5);
            s2 = rd.Next(1, 5);
            s3 = rd.Next(1, 5);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
        }
    }
}
