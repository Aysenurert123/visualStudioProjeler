using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swiıtch_case2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch(mevsim)
            {
                case "Yaz": label2.Text = "Haziran Temmuz Ağustos";
                    break;
                case "Sonbahar": label2.Text = "Eylül Ekim Kasım"; break;
                case "Kış": label2.Text = "Aralık Ocak Şubat"; break;
                case "İlkbahar":label2.Text = "Mart Nisan Mayıs";break;
                default:label2.Text = "Hatalı mevsim"; break;
                       
            }
        }
    }
}
