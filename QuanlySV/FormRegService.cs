using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlySV
{
    public partial class FormRegService : Form
    {
        private string Event = string.Empty;
        public FormRegService()
        {
            InitializeComponent();
            LoadData();
            LoadCombobox();
        }
        private async void LoadData()
        {

            //var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/CreateOrUpdateServiceReg");
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/GetCollectionServiceReg");
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            var modelReq = new CollectionServiceReg();
            modelReq.ServiceId = cboService.SelectedValue.ToString();
            modelReq.Remark = txtRemark.Text;
            modelReq.MajorFrom = cboMajorF.SelectedValue.ToString();
            modelReq.MajorTo = cboMajorT.SelectedValue.ToString();
            modelReq.SubjectId = cboService.SelectedValue.ToString();
            var res = await CallAPICenter.CallAPIPost(modelReq, "/api/MasterData/CreateOrUpdateServiceReg");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
                return;
            }
            LoadData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Hanldebutton("Clear");
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
    }
}
