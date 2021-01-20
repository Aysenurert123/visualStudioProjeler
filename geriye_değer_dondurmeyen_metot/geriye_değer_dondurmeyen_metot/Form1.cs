using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geriye_değer_dondurmeyen_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();


        }
        void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.SaddleBrown;
            textBox3.BackColor = Color.Firebrick;
            textBox4.BackColor = Color.Tan;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            renklendir();

        }
    }
}
