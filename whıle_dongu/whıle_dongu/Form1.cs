using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whıle_dongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while(i<=5)
            {
                listBox1.Items.Add("Merhaba Ankara");
                listBox2.Items.Add(i);
                i++;
            }
        }
    }
}
