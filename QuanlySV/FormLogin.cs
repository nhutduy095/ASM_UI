using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuanlySV.Configuration;
using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void btnSignin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập username!");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập password!");
                return;
            }
            var request = new LoginRequest()
            {
                username = txtUserName.Text,
                password = txtPassword.Text
            };
            ResponseModel res = await CallAPICenter.CallAPIPost(request, "/api/Auth/Login");
            if (!res.Status)
            {
                MessageBox.Show("[" + res.ErrMessageCode + "] " + res.ErrMessage);
                return;
            }
            LoginRespone data = Util.ConvertToType<LoginRespone>(res.Data);
            UserInfo userInfo = Util.ConvertToType<UserInfo>(data.UserInfo);
            Config.Token = data.Token;
            Config.userInfo = userInfo;
            Config.userType = userInfo.UserType;
            Config.userId = userInfo.UserId;
            if (userInfo.UserType == "S")
            {
                FormSV frm = new FormSV();
                frm.Show();
                this.Hide();

            }
            else if (userInfo.UserType == "T")
            {
                FormGV frm = new FormGV();
                frm.Show();
                this.Hide();
            }
            else if (userInfo.UserType == "A")
            {
                FormQLSV frm = new FormQLSV();
                frm.Show();
                this.Hide();
            }
            //res = await CallAPICenter.CallAPIGet("/api/Auth/Test");
            //var req = new RequestPaging()
            //{
            //    Page = 1,
            //    PerPage = 100,
            //};
            ////var a = await CallAPICenter.CallAPIPost(req, "/api/Auth/Test");
            //var a = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollectionClassByID?classId=SD18322");
        }

       
    }
}
