﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmÖgretmen : Form
    {
        public FrmÖgretmen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKulüpİslemler_Click(object sender, EventArgs e)
        {
            FrmKulüp fr = new FrmKulüp();
            fr.Show();
        }
    }
}
