﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler { X, Adana,Adıyaman,Afyon,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın}
        private void Button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToUInt16(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
        }
    }
}
