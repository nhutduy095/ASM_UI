﻿using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class Student_Manage : Form
    {
        public Student_Manage()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private async void LoadCombobox()
        {
            var resDataComboMajor = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollMajorCombo");
            if (resDataComboMajor.Status)
            {
                if (resDataComboMajor.Data != null)
                {
                    var dataCombo = Util.ConvertListToType<CollMajorCombo>(resDataComboMajor.Data);
                    cboMajor.DataSource = dataCombo;
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
