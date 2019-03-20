using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//them thu vien cua fire base
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;



namespace QuanLyHoSoSDH
{
    public partial class frmLogin : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };


        IFirebaseClient client;



        public frmLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            // thoat chuong trinh
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (a == DialogResult.OK) { Application.Exit(); }
           if (a == DialogResult.Cancel) { tbId.Focus(); }
            //Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == "1") {
                frmMain frmMain = new frmMain();
                this.Hide(); 
                frmMain.ShowDialog();
            }

            //var data = new Data
            //{
            //    Id = tbId.Text,
            //    Password = tbPass.Text
            //};


            //SetResponse setResponse = await client.SetTaskAsync("Information/" + tbId.Text, data);
            //SetResponse response = setResponse;
            //Data result = response.ResultAs<Data>();

            //MessageBox.Show("Data Inserted " + result.Id);
             
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbId.Focus();

         

            //client = new FireSharp.FirebaseClient(config);
            //if(client!=null)
            //{
            //    MessageBox.Show("ket noi thanh cong!");
            //}
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
