using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlySV
{
    public partial class FormRegService : Form
    {
        private string Event = string.Empty;
        int dtlID = 0;
        private List<CollServiceForCombo> lstService= new List<CollServiceForCombo>();
        private List<CollSubjectCombo> lstSubject= new List<CollSubjectCombo>();
        private List<CollMajorCombo> lstMajorF= new List<CollMajorCombo>();
        private List<CollMajorCombo> lstMajorT= new List<CollMajorCombo>();
        public FormRegService()
        {
            InitializeComponent();
            LoadData();
            LoadCombobox();
        }
        private async void LoadData()
        {
            dtlID = 0;
            List<Filltering> lstfilltering = new List<Filltering>();
            var filltering = new Filltering();
            filltering.CollName = "ServiceId";
            filltering.ValueDefault = cboService.DisplayMember;
            lstfilltering.Add(filltering);
            var filltering1 = new Filltering();
            //var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/CreateOrUpdateServiceReg");
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100, Filltering = lstfilltering }, "/api/MasterData/GetCollectionServiceReg");
            if (data.Status)
            {
                if (data.Data != null)
                {
                    List<CollectionServiceReg> lstDtl = Util.ConvertListToType<CollectionServiceReg>(data.Data);
                    var list = new BindingList<CollectionServiceReg>(lstDtl);
                    dataGridView1.DataSource = list;

                    /*dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[10].Name = "AveragePoints";
                    dataGridView1.Columns[10].HeaderText = "Điểm";
                    dataGridView1.Columns[13].Name = "SubjectName";
                    dataGridView1.Columns[13].HeaderText = "Tên Môn";
                    dataGridView1.Columns[14].Name = "TeacherName";
                    dataGridView1.Columns[14].HeaderText = "Giáo Viên";
                    dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
                }
            }
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            var modelReq = new CollectionServiceReg();
            modelReq.DtlID = Event == "Add" ? 0 : dtlID;
            modelReq.ServiceId = cboService.SelectedValue.ToString();
            modelReq.Remark = txtRemark.Text;
            modelReq.MajorFrom = cboMajorF.SelectedValue.ToString();
            modelReq.MajorTo = cboMajorT.SelectedValue.ToString();
            modelReq.SubjectId = cboService.SelectedValue.ToString();
            modelReq.Status = Event == "Cancel" ? "C" : "N";
            var res = await CallAPICenter.CallAPIPost(modelReq, "/api/MasterData/CreateOrUpdateServiceReg");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
                return;
            }
            LoadData();
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            if (dtlID == 0)
            {
                MessageBox.Show("Vui long chọn một đăng ký bạn muốn hủy!");
                return;
            }
            var modelReq = new CollectionServiceReg();
            modelReq.DtlID = Event == "Add" ? 0 : dtlID;
            modelReq.ServiceId = cboService.SelectedValue.ToString();
            modelReq.Remark = txtRemark.Text;
            modelReq.MajorFrom = cboMajorF.SelectedValue.ToString();
            modelReq.MajorTo = cboMajorT.SelectedValue.ToString();
            modelReq.SubjectId = cboService.SelectedValue.ToString();
            modelReq.Status = "C" ;
            var res = await CallAPICenter.CallAPIPost(modelReq, "/api/MasterData/CreateOrUpdateServiceReg");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
                return;
            }
            LoadData();
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVal = cboService.SelectedValue.ToString();
            if (selectedVal == "SV005")
            {
                cboSubject.Enabled = false;
                cboMajorF.Enabled = true;
                cboMajorT.Enabled = true;

            }
            else
            {
                cboSubject.Enabled = true;
                cboMajorF.Enabled = false;
                cboMajorT.Enabled = false;
            }
        }
        private void Hanldebutton(string even)
        {
            Event = even;
            if (even == "Load")
            {
                btnReg.Enabled = true;
                btndelete.Enabled = false;
                button3.Enabled = false;

                cboService.Enabled = true;
                cboSubject.Enabled = false;

            }

            else if (even == "Clear")
            {
                btnReg.Enabled = true;
                btndelete.Enabled = true;
                button3.Enabled = true;

                cboService.Enabled = true;
                cboSubject.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSV formSV = new FormSV();
            formSV.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex];

                dtlID = int.Parse(data.Cells["DtlID"].Value.ToString());

                txtRemark.Text = data.Cells["Remark"].Value.ToString();
                cboSubject.SelectedIndex = lstSubject.IndexOf(lstSubject.FirstOrDefault(x => x.SubjectId == data.Cells["SubjectId"].Value.ToString()));
                cboMajorF.SelectedIndex = data.Cells["MajorFrom"].Value==null?0:string.IsNullOrEmpty(data.Cells["MajorFrom"].Value.ToString())?0: lstMajorF.IndexOf(lstMajorF.FirstOrDefault(x => x.MajorID == data.Cells["MajorFrom"].Value.ToString()));
                cboMajorT.SelectedIndex = data.Cells["MajorTo"].Value == null ? 0 : string.IsNullOrEmpty(data.Cells["MajorTo"].Value.ToString()) ? 0 : lstMajorT.IndexOf(lstMajorT.FirstOrDefault(x => x.MajorID == data.Cells["MajorTo"].Value.ToString()));
                //cboMajor.sel = data.Cells["Image"].Value.ToString();

                //Hanldebutton("Edit");
                btndelete.Enabled = true;
                btnReg.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
