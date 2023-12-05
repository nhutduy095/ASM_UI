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
        private string Event = string.Empty;
        private string _id = string.Empty;
        public TeacherManage()
        {
            InitializeComponent();
            Hanldebutton("Load");
            LoadData();
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
            userinfoReq.IsActive=Event== "Delete"?false:true;
            var res = await CallAPICenter.CallAPIPost(userinfoReq, "/api/MasterData/CreateOrUpdateUserInfo");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
            }
            else
            {
                LoadData();
                Hanldebutton("Load");
            }
        }
        private async void LoadData()
        {
            List<Filltering> lstfilltering = new List<Filltering>();
            var filltering = new Filltering();
            filltering.CollName = "UserId";
            filltering.ValueDefault = txtUId.Text;
            lstfilltering.Add(filltering);
            var filltering1 = new Filltering();
            filltering1.CollName = "UserType";
            filltering1.ValueDefault = "T";
            lstfilltering.Add(filltering1);
            RequestPaging requestPaging = new RequestPaging();
            requestPaging.Page = 1;
            requestPaging.PerPage = 100;
            requestPaging.Filltering = lstfilltering;
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 ,Filltering= lstfilltering }, "/api/MasterData/GetCollectionUserInfo");
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
            LoadData();
        }
        private void Hanldebutton(string even)
        {
            Event = even;
            if (even == "Load")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = false;   
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtUserId.Enabled = false;
                txtClass.Enabled = false;
                txtSdt.Enabled = false;
                dtpBirth.Enabled = false;
                txtAdress.Enabled = false;
                txtMail.Enabled = false;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtUserId.Text = string.Empty;
                txtClass.Text = string.Empty;
                txtSdt.Text = string.Empty;
                txtAdress.Text = string.Empty;
                txtMail.Text = string.Empty;
                dtpBirth.Value=DateTime.Now;

            }
            else if (even == "Add" || even == "Edit")
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtUserId.Enabled = true;
                txtClass.Enabled = true;
                txtSdt.Enabled = true;
                txtAdress.Enabled = true;
                txtMail.Enabled = true;
                dtpBirth.Enabled = true;
                btnClear.Enabled=true;
                if (even == "Add")
                {
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtUserId.Text = string.Empty;
                    txtClass.Text = string.Empty;
                    txtSdt.Text = string.Empty;
                    txtAdress.Text = string.Empty;
                    txtMail.Text = string.Empty;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                }
                else
                {
                    txtUserId.Enabled= false;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                }
            }
            else if (even == "Clear")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = false;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtUserId.Text = string.Empty;
                txtClass.Text = string.Empty;
                txtSdt.Text = string.Empty;
                txtAdress.Text = string.Empty;
                txtMail.Text = string.Empty;
                dtpBirth.Enabled = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hanldebutton("Add");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hanldebutton("Edit");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Hanldebutton("Delete");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Hanldebutton("Clear");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLSV formQLSV = new FormQLSV();
            formQLSV.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex];
                _id = data.Cells["_id"].Value.ToString();
                txtFirstName.Text = data.Cells["FirstName"].Value.ToString();
                txtLastName.Text = data.Cells["LastName"].Value.ToString();
                txtUserId.Text = data.Cells["UserId"].Value.ToString();
                txtClass.Text = data.Cells["IdClass"].Value.ToString();
                txtSdt.Text = data.Cells["PhoneNumber"].Value.ToString();
                rdMale.Checked = bool.Parse(data.Cells["Sex"].Value.ToString());
                rdFemale.Checked = !(bool.Parse(data.Cells["Sex"].Value.ToString()));
                dtpBirth.Value =DateTime.Parse(data.Cells["Birthday"].Value.ToString());
                txtAdress.Text = data.Cells["Address"].Value.ToString();
                txtMail.Text = data.Cells["MailAddress"].Value.ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
