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
    public partial class frmCNFB : Form
    {

        // doan nay mo ta lien ket den co do du lieu(luu y vi tri dat doan nay)
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "8nRfThVBUj182flmg4hA88mxFOHd9MgQY6YxsMGH",
            BasePath = "https://sdhtdmu.firebaseio.com/"
        };
        IFirebaseClient client;
        private object data;

        // ket thuc mo ta


        public frmCNFB()
        {
            InitializeComponent();
        }

        private void frmCNFB_Load(object sender, EventArgs e)
        {
            //kiem tra ket noi den csdl fire base co thanh cong hay khong
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //MessageBox.Show("ket noi thanh cong!");
            }
            if (client == null)
            { MessageBox.Show("khong the ket noi csdl"); }
            //==============
        }
        private async void btThem_Click(object sender, EventArgs e)
        {
            // private async void btLogin_ClickAsync(object sender, EventArgs e)

            var data = new Data
            {
                MaSv = tbMasv.Text,
                Ten = tbTen.Text,
                Tuoi = tbTuoi.Text
            };

            SetResponse setResponse = await client.SetTaskAsync("Information/" + tbMasv.Text, data);
            SetResponse response = setResponse;
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã Thêm " + result.MaSv);


        }

        // xoa du lieu theo ma sinh vien
        private async void btx_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + tbMasv.Text);
            MessageBox.Show("Đã xóa " + tbMasv.Text);
        }

        //chuc nang sua
        private async void bts_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                MaSv = tbMasv.Text,
                Ten = tbTen.Text,
                Tuoi = tbTuoi.Text
            };
            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + tbMasv.Text,data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("update id " + result.MaSv);

        }

        //chuc nang load du lieu theo ma sinh vien
        private async void btget_ClickAsync(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Information/" + tbMasv.Text);
            Data obj = response.ResultAs<Data>();

            tbMasv.Text = obj.MaSv;
            tbTen.Text = obj.Ten;
            tbTuoi.Text = obj.Tuoi;
            MessageBox.Show("lay du lieu thanh cong!");
        }

        //xoa toan bo 
        private async void btxtt_ClickAsync(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information");
            MessageBox.Show("xoa toan bo goc");
        }

        private async void btTtm_Click(object sender, EventArgs e)
        {
            //FirebaseResponse response = await client.DeleteTaskAsync("ads");
            // private async void btLogin_ClickAsync(object sender, EventArgs e)

            var data = new Data
            {
                //cau truc
                // ten truong khai bao trong file data = ten textbox
                MaSv = tbMasv.Text,
                Ten = tbTen.Text,
                Tuoi = tbTuoi.Text
            };

            SetResponse response = await client.SetTaskAsync("sad/",tbMasv.Text);          
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Đã Thêm " + result.MaSv);


        }
    }
}
