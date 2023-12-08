using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlySV
{
    public partial class Student_Manage : Form
    {
        private string Event = string.Empty;
        private string _id = string.Empty;
        private static List<CollMajorCombo> lstMajor = new List<CollMajorCombo>();

        public Student_Manage()
        {
            InitializeComponent();
            LoadCombobox();
            Hanldebutton("Load");
            LoadData();
        }
        private async void LoadCombobox()
        {
            var resDataComboMajor = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollMajorCombo");
            if (resDataComboMajor.Status)
            {
                if (resDataComboMajor.Data != null)
                {
                    lstMajor = Util.ConvertListToType<CollMajorCombo>(resDataComboMajor.Data);
                    cboMajor.DataSource = lstMajor;
                    cboMajor.ValueMember = "MajorID";
                    cboMajor.DisplayMember = "MajorName";

                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var userinfoReq = new UserInfoRequest();
            userinfoReq.UserId = txtUserId.Text;
            userinfoReq.FirstName = txtFirstName.Text;
            userinfoReq.LastName = txtLastName.Text;
            userinfoReq.Sex = rdMale.Checked;
            userinfoReq.UserType = "S";
            userinfoReq.Birthday = dtpBirth.Value.ToString("yyyy-MM-dd");
            userinfoReq.IdClass = txtClass.Text;
            userinfoReq.PhoneNumber = txtSdt.Text;
            userinfoReq.ParentsPhoneNumber = txtSDTPH.Text;
            userinfoReq.Address = txtAdress.Text;
            userinfoReq.MailAddress = txtMail.Text;
            userinfoReq.MajorID = cboMajor.SelectedValue.ToString();
            var res = await CallAPICenter.CallAPIPost(userinfoReq, "/api/MasterData/CreateOrUpdateUserInfo");
            
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
            }
            else
            {
                Hanldebutton("Load");
                LoadData();
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
            filltering1.ValueDefault = "S";
            lstfilltering.Add(filltering1);
            RequestPaging requestPaging = new RequestPaging();
            requestPaging.Page = 1;
            requestPaging.PerPage = 100;
            requestPaging.Filltering = lstfilltering;
            //var data = await CallAPICenter.CallAPIPost(requestPaging);
            var data = await CallAPICenter.CallAPIPost(requestPaging,  "/api/MasterData/GetCollectionUserInfo");
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

        private async void btnSearch_Click(object sender, EventArgs e)
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
                cboMajor.Enabled = false;
                dtpBirth.Enabled = false;
                txtAdress.Enabled = false;
                txtMail.Enabled = false;
                txtSDTPH.Enabled = false;
            }
            else if (even == "Add" || even == "Edit")
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtUserId.Enabled = true;
                txtClass.Enabled = true;
                txtSdt.Enabled = true;
                cboMajor.Enabled = true;
                txtAdress.Enabled = true;
                txtMail.Enabled = true;
                txtSDTPH.Enabled = true;
                dtpBirth.Enabled=true;
                if (even == "Add")
                {
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtUserId.Text = string.Empty;
                    txtClass.Text = string.Empty;
                    txtSdt.Text = string.Empty;
                    txtAdress.Text = string.Empty;
                    txtMail.Text = string.Empty;
                    txtSDTPH.Text = string.Empty;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                }
                else
                {
                    txtUserId.Enabled= false;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnAdd.Enabled = false;

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
                txtSDTPH.Text = string.Empty;
                cboMajor.Enabled = false;

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
                _id = data.Cells["_Id"].Value.ToString();
                txtFirstName.Text = data.Cells["FirstName"].Value.ToString();
                txtLastName.Text = data.Cells["LastName"].Value.ToString();
                txtUserId.Text = data.Cells["UserId"].Value.ToString();
                txtClass.Text = data.Cells["IdClass"].Value.ToString();
                txtSdt.Text = data.Cells["PhoneNumber"].Value.ToString();
                rdMale.Checked = bool.Parse(data.Cells["Sex"].Value.ToString());
                rdFemale.Checked = !(bool.Parse(data.Cells["Sex"].Value.ToString()));
                dtpBirth.Value = DateTime.Parse(data.Cells["Birthday"].Value.ToString());
                txtAdress.Text = data.Cells["Address"].Value.ToString();
                txtMail.Text = data.Cells["MailAddress"].Value.ToString();
                txtSDTPH.Text = data.Cells["ParentsPhoneNumber"].Value.ToString();
                bool aa = data.Cells["MajorID"].Value==null ?true : string.IsNullOrEmpty(data.Cells["MajorID"].Value.ToString())?true:false;
                cboMajor.SelectedIndex = aa ? 0: lstMajor.IndexOf(lstMajor.FirstOrDefault(x => x.MajorID == data.Cells["MajorID"].Value.ToString()));
                
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
}
}
