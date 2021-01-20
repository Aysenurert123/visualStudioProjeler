using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardısık_sayı_toplamları2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i =2; i <= 10; i+=2) 
            {
                toplam = toplam + i;
            }
            label2.Text = toplam.ToString();
        }
    }
}
//2,4,6,8,10