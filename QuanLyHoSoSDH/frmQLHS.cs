﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoSDH
{
    public partial class frmQLHS : Form
    {
        public frmQLHS()
        {
            InitializeComponent();
        }

        private void btnTTHV_Click(object sender, EventArgs e)
        {
            frmTTHV frmTTHV = new frmTTHV();
            this.Hide();
            frmTTHV.ShowDialog();
        }
    }
}
