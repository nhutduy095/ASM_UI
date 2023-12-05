using QuanlySV.Configuration;
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
        private int dtlId = 0;
        private List<CollServiceForCombo> lstService = new List<CollServiceForCombo>();
        private List<CollSubjectCombo> lstSubject = new List<CollSubjectCombo>();
        private List<CollMajorCombo> lstMajorF = new List<CollMajorCombo>();
        private List<CollMajorCombo> lstMajorT = new List<CollMajorCombo>();
        private List<ServiceRegStatusCombo> lstStatus = new List<ServiceRegStatusCombo>();
        public SrvConfirm()
        {
            InitializeComponent();
            txtLastName.Enabled = false;
            txtNote.Enabled = false;
            dtpRegDay.Enabled = false;
            cboMajorF.Enabled = false;
            cboMajorT.Enabled = false;
            cboSubject.Enabled = false;
            cboService.Enabled = false;
            LoadCombobox();
            LoadData();
        }
        private async void LoadCombobox()
        {
            var resDataCombo = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollServiceForComb");
            if (resDataCombo.Status)
            {
                if (resDataCombo.Data != null)
                {
                    lstService = Util.ConvertListToType<CollServiceForCombo>(resDataCombo.Data);
                    cboService.DataSource = lstService;
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
                    lstMajorF = Util.ConvertListToType<CollMajorCombo>(resDataComboMajor.Data);
                    cboMajorF.DataSource = lstMajorF;
                    cboMajorF.ValueMember = "MajorID";
                    cboMajorF.DisplayMember = "MajorName";
                }
            }

            var resDataComboMajorT = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollMajorCombo");
            if (resDataComboMajorT.Status)
            {
                if (resDataComboMajor.Data != null)
                {
                    lstMajorT = Util.ConvertListToType<CollMajorCombo>(resDataComboMajorT.Data);
                    cboMajorT.DataSource = lstMajorT;
                    cboMajorT.ValueMember = "MajorID";
                    cboMajorT.DisplayMember = "MajorName";
                }
            }

            cboConfirm.DataSource= lstStatus;
            lstStatus.Add(new ServiceRegStatusCombo{ StatusCode = "A", StatusName = "Approve" });
            lstStatus.Add(new ServiceRegStatusCombo{ StatusCode = "R", StatusName = "Reject" });
            lstStatus.Add(new ServiceRegStatusCombo{ StatusCode = "N", StatusName = "New" });
            lstStatus.Add(new ServiceRegStatusCombo { StatusCode = "C", StatusName = "Cancel" });
            cboConfirm.DataSource = lstStatus;

            cboConfirm.ValueMember = "StatusCode";
            cboConfirm.DisplayMember = "StatusName";

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
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100, Filltering = lstfilltering }, "/api/MasterData/GetCollectionServiceReg");
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
            serviceReq.DtlID = dtlId;
            serviceReq.Remark1 = txRemark1.Text;
            serviceReq.Status = cboConfirm.SelectedValue.ToString();
            serviceReq.ConfirmDate = dtpCofirmDay.Value.ToString("yyyy-MM-dd");
            serviceReq.ReciveDate = dtpFinishDay.Value.ToString("yyyy-MM-dd");
            serviceReq.ConfirmBy = Config.userId;
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
                dtlId = int.Parse(data.Cells["DtlID"].Value.ToString());


                txtLastName.Text = data.Cells["RequestName"].Value.ToString();
                txtNote.Text = data.Cells["Remark"].Value.ToString();
                if (data.Cells["RequestDate"].Value == null || string.IsNullOrEmpty(data.Cells["RequestDate"].Value.ToString()))
                {
                    dtpCofirmDay.Value = DateTime.Now;
                }
                else
                {
                    dtpRegDay.Value = DateTime.Parse(data.Cells["RequestDate"].Value.ToString());
                }
                
                //cboService.SelectedIndex = lstService.IndexOf(lstService.FirstOrDefault(x => x.ServiceId == data.Cells["ServiceId"].Value.ToString()));
                //cboSubject.SelectedIndex = lstSubject.IndexOf(lstSubject.FirstOrDefault(x => x.SubjectId == data.Cells["SubjectId"].Value.ToString()));
                cboService.SelectedIndex = data.Cells["ServiceId"].Value == null ? 0 : string.IsNullOrEmpty(data.Cells["ServiceId"].Value.ToString()) ? 0 : lstService.IndexOf(lstService.FirstOrDefault(x => x.ServiceId == data.Cells["ServiceId"].Value.ToString()));
                cboSubject.SelectedIndex = data.Cells["SubjectId"].Value == null ? 0 : string.IsNullOrEmpty(data.Cells["SubjectId"].Value.ToString()) ? 0 : lstSubject.IndexOf(lstSubject.FirstOrDefault(x => x.SubjectId == data.Cells["SubjectId"].Value.ToString()));
                cboMajorF.SelectedIndex = data.Cells["MajorFrom"].Value == null ? 0 : string.IsNullOrEmpty(data.Cells["MajorFrom"].Value.ToString()) ? 0 : lstMajorF.IndexOf(lstMajorF.FirstOrDefault(x => x.MajorID == data.Cells["MajorFrom"].Value.ToString()));
                cboMajorT.SelectedIndex = data.Cells["MajorTo"].Value == null ? 0 : string.IsNullOrEmpty(data.Cells["MajorTo"].Value.ToString()) ? 0 : lstMajorT.IndexOf(lstMajorT.FirstOrDefault(x => x.MajorID == data.Cells["MajorTo"].Value.ToString()));
                cboConfirm.SelectedIndex = data.Cells["Status"].Value == null ? 0 : string.IsNullOrEmpty(data.Cells["Status"].Value.ToString()) ? 0 : lstStatus.IndexOf(lstStatus.FirstOrDefault(x => x.StatusCode == data.Cells["Status"].Value.ToString()));
                if (data.Cells["ConfirmDate"].Value==null || string.IsNullOrEmpty(data.Cells["ConfirmDate"].Value.ToString())){
                    dtpCofirmDay.Value = DateTime.Now;
                }
                else
                {
                    dtpCofirmDay.Value = DateTime.Parse(data.Cells["ConfirmDate"].Value.ToString());
                }
                if (data.Cells["ReciveDate"].Value == null || string.IsNullOrEmpty(data.Cells["ReciveDate"].Value.ToString()))
                {
                    dtpCofirmDay.Value = DateTime.Now;
                }
                else
                {
                    dtpFinishDay.Value = DateTime.Parse(data.Cells["FinishConfirmDate"].Value.ToString());
                }
                //cboConfirm.ValueMember = data.Cells["Status"].Value.ToString();

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
