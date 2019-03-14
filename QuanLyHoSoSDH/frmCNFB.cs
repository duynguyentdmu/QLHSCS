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
            MessageBox.Show("Đã Thêm " + result.Id);


        }

        private void btx_Click(object sender, EventArgs e)
        {

        }

        private void bts_Click(object sender, EventArgs e)
        {

        }

        private void btget_Click(object sender, EventArgs e)
        {
            // FirebaseResponse response = await  client.GetTaskAsync()
            //FirebaseResponse getResponse = await client.GetTaskAsync("Information/" + tbMasv.Text);

            SetResponse getResponse = await client.SetTaskAsync("Information/" + tbMasv.Text, data);
            SetResponse response = getResponse;

            Data obj = getResponse.ResultAs<Data>();

            tbMasv.Text = obj.Id;
            tbTen.Text = obj.Ten;
            tbTuoi.Text = obj.Tuoi;
            MessageBox.Show("lay du lieu thanh cong!");
        }
    }
}
