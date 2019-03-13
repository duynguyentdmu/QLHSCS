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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btQLHS_Click(object sender, EventArgs e)
        {
            frmQLHS frmQLHS = new frmQLHS();
            this.Hide();
            frmQLHS.ShowDialog();
        }
    }
}
