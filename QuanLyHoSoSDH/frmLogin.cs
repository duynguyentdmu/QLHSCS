using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == "1") {
                frmMain frmMain = new frmMain();
                this.Hide();
                
                frmMain.ShowDialog();
            }
        }
    }
}
