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
    public partial class FormBangdiem : Form
    {
        public FormBangdiem()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            List<Filltering> lstfilltering = new List<Filltering>();
            var filltering = new Filltering();
            filltering.CollName = "SubjectId";
            filltering.ValueDefault = txtSubjectId.Text;
            lstfilltering.Add(filltering);
            var paging = new GetDataPointForReq() { Page = 1, PerPage = 100, userId = Config.userId, subjectName = txtSubjectId.Text, Filltering = lstfilltering };
            var resData = await CallAPICenter.CallAPIPost(paging, "/api/MasterData/GetDataPointforUser");
            if (!resData.Status)
            {
                MessageBox.Show(resData.ErrMessage);
                return;
            }
            if (resData.Data == null)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị");
                return;
            }
            DataPointMst data = Util.ConvertToType<DataPointMst>(resData.Data);
            lblfail.Text = data.TotalFail + "";
            lblCredit.Text = data.TotalCreditPass + "/" + data.NumberOfCredits + " (Đạt/Tổng) - 0 miễn giảm";
            lblpointavgMst.Text = data.AveragePointsMst + "";
            lblpass.Text = data.TotalPass + "";
            lblstuding.Text = data.TotalStuding + "";
            lblnotyet.Text = data.TotalNotYet + "";
            if (data.Details != null)
            {
                List<DataPointDtl> lstDtl = Util.ConvertListToType<DataPointDtl>(data.Details);
                //var lstShow = lstDtl.Select(x => new{ 
                //    MarkId=x.MarkId,
                //    MarkDtlId = x.MarkDtlId,
                //    SubjectName = x.SubjectName,
                //    TeacherName = x.TeacherName,
                //    AveragePoints = x.AveragePoints
                //}).ToList();
                var list = new BindingList<DataPointDtl>(lstDtl);
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].Visible = false;
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
                dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSV formSV = new FormSV();
            formSV.Show();
        }
    }
}
