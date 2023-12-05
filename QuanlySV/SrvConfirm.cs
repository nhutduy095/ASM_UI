using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class SrvConfirm : Form
    {
        private string _id = string.Empty;
        public SrvConfirm()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private async void LoadCombobox()
        {
            var resDataCombo = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollServiceForComb");
            if (resDataCombo.Status)
            {
                if (resDataCombo.Data != null)
                {
                    var dataCombo = Util.ConvertListToType<CollServiceForCombo>(resDataCombo.Data);
                    cboService.DataSource = dataCombo;
                    cboService.ValueMember = "ServiceId";
                    cboService.DisplayMember = "ServiceName";
                }
            }

            var resDataComboSubject = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollSubjectForCombo");
            if (resDataComboSubject.Status)
            {
                if (resDataComboSubject.Data != null)
                {
                    var dataCombo = Util.ConvertListToType<CollSubjectCombo>(resDataComboSubject.Data);
                    cboSubject.DataSource = dataCombo;
                    cboSubject.ValueMember = "SubjectId";
                    cboSubject.DisplayMember = "SubjectName";
                }
            }

            var resDataComboMajor = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollMajorCombo");
            if (resDataComboMajor.Status)
            {
                if (resDataComboMajor.Data != null)
                {
                    var dataCombo = Util.ConvertListToType<CollMajorCombo>(resDataComboMajor.Data);
                    cboMajorT.DataSource = dataCombo;
                    cboMajorT.ValueMember = "MajorID";
                    cboMajorT.DisplayMember = "MajorName";
                    cboMajorF.DataSource = dataCombo;
                    cboMajorF.ValueMember = "MajorID";
                    cboMajorF.DisplayMember = "MajorName";
                }
            }
            cboConfirm.Items.Clear();
            cboConfirm.Items.Add(new { Key = "A", Value = "Approve" });
            cboConfirm.Items.Add(new { Key = "R", Value = "Reject" });
            cboConfirm.ValueMember = "Key";
            cboConfirm.DisplayMember = "Value";

        }
        private async void LoadData()
        {
            List<Filltering> lstfilltering = new List<Filltering>();
            var filltering = new Filltering();
            filltering.CollName = "ServiceName";
            filltering.ValueDefault = cboService.DisplayMember;
            lstfilltering.Add(filltering);
            RequestPaging requestPaging = new RequestPaging();
            requestPaging.Page = 1;
            requestPaging.PerPage = 100;
            requestPaging.Filltering = lstfilltering;
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/GetCollectionServiceReg");
            if (data.Status)
            {
                if (data.Data != null)
                {
                    List<CollectionServiceReg> lstDtl = Util.ConvertListToType<CollectionServiceReg>(data.Data);
                    var list = new BindingList<CollectionServiceReg>(lstDtl);
                    dataGridView1.DataSource = list;

                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var serviceReq = new CollectionServiceReg();
            serviceReq.ServiceName = cboService.DisplayMember;
            serviceReq.MajorFromName = cboMajorF.DisplayMember;
            serviceReq.MajorToName = cboMajorT.DisplayMember;
            var userInfo = new UserInfo();
            userInfo.LastName = txtLastName.Text;
            serviceReq.Remark = txtNote.Text;
            serviceReq.RequestDate = dtpRegDay.Value.ToString("yyyy-MM-dd");
            serviceReq.SubjectName = cboSubject.DisplayMember;
            serviceReq.Status = cboConfirm.DisplayMember;
            serviceReq.ConfirmDate = dtpCofirmDay.Value.ToString("yyyy-MM-dd");
            serviceReq.FinishConfirmDate = dtpFinishDay.Value.ToString("yyyy-MM-dd");

            var res = await CallAPICenter.CallAPIPost(serviceReq, "/api/MasterData/CreateOrUpdateServiceReg");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
            }
            else
            {
                LoadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex];
                _id = data.Cells["_Id"].Value.ToString();

                cboService.DisplayMember = data.Cells["ServiceName"].Value.ToString();
                cboMajorF.DisplayMember = data.Cells["MajorFromName"].Value.ToString();
                cboMajorT.DisplayMember = data.Cells["MajorFromName"].Value.ToString();
                txtLastName.Text = data.Cells["LastName"].Value.ToString();
                txtNote.Text = data.Cells["LastName"].Value.ToString();
                //dtpRegDay.Value = data.Cells["RequestDate"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
