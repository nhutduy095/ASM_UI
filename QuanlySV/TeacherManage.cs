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
    public partial class TeacherManage : Form
    {
        public TeacherManage()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var userinfoReq = new UserInfoRequest();
            userinfoReq.UserId = txtUserId.Text;
            userinfoReq.FirstName = txtFirstName.Text;
            userinfoReq.LastName = txtLastName.Text;
            userinfoReq.Sex = rdMale.Checked;
            userinfoReq.UserType = "T";
            userinfoReq.Birthday = dtpBirth.Value.ToString("yyyy-MM-dd");
            userinfoReq.IdClass = txtClass.Text;
            userinfoReq.PhoneNumber = txtSdt.Text;
            userinfoReq.ParentsPhoneNumber = null;
            userinfoReq.Address = txtAdress.Text;
            userinfoReq.MailAddress = txtMail.Text;

            var res = await CallAPICenter.CallAPIPost(userinfoReq, "/api/MasterData/CreateOrUpdateUserInfo");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
            }
            else
            {
                LoadData();
            }
        }
        private async void LoadData()
        {
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/GetCollectionUserInfo");
            if (data.Status)
            {
                if (data.Data != null)
                {
                    List<UserInfoRequest> lstDtl = Util.ConvertListToType<UserInfoRequest>(data.Data);
                    var list = new BindingList<UserInfoRequest>(lstDtl);
                    dataGridView1.DataSource = list;

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var userinfoReq = new UserInfoRequest();
            userinfoReq.UserId = txtUId.Text;
            LoadData();
        }
    }
}
