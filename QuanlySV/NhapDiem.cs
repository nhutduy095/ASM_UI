using QuanlySV.Model;
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

namespace QuanlySV
{
    public partial class NhapDiem : Form
    {
        private string Event = string.Empty;
        private string _id = string.Empty;
        private int markId = 0;
        private int markDtlId = 0;
        private static List<SeasonCombo> lstseason = new List<SeasonCombo>();
        private static List<CollSubject> lstSubject = new List<CollSubject>();
        public NhapDiem()
        {
            InitializeComponent();
            LoadDataCombo();
            //lstseason=new List<SeasonCombo>();
            //lstSubject = new List<CollSubject>();

            LoadData();
        }
        private async void LoadDataCombo()
        {
            //var resDataComboMajor = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollMajorCombo");
            //if (resDataComboMajor.Status)
            //{
            //    if (resDataComboMajor.Data != null)
            //    {
            //        var dataCombo = Util.ConvertListToType<CollMajorCombo>(resDataComboMajor.Data);
            //        cboMajor.DataSource = dataCombo;
            //        cboMajor.ValueMember = "MajorID";
            //        cboMajor.DisplayMember = "MajorName";

            //    }
            //}

            cboSeason.Items.Clear();
            lstseason.Add(new SeasonCombo { SeasonId = "HKI", SeasonName = "Học kỳ 1" });
            lstseason.Add(new SeasonCombo { SeasonId = "HKII", SeasonName = "Học kỳ 2" });
            lstseason.Add(new SeasonCombo { SeasonId = "HKIII", SeasonName = "Học kỳ 3" });
            lstseason.Add(new SeasonCombo { SeasonId = "HKIV", SeasonName = "Học kỳ 4" });
            lstseason.Add(new SeasonCombo { SeasonId = "HKV", SeasonName = "Học kỳ 5" });
            lstseason.Add(new SeasonCombo { SeasonId = "HKVI", SeasonName = "Học kỳ 6" });
            lstseason.Add(new SeasonCombo { SeasonId = "HKVII", SeasonName = "Học kỳ 7" });
            cboSeason.DataSource = lstseason;
            cboSeason.ValueMember = "SeasonId";
            cboSeason.DisplayMember = "SeasonName";
            cboSeason.DisplayMember = "SeasonName";


            var resDataComboSubject = await CallAPICenter.CallAPIGet("/api/MasterData/GetCollSubjectForCombo");
            if (resDataComboSubject.Status)
            {
                if (resDataComboSubject.Data != null)
                {
                    lstSubject = Util.ConvertListToType<CollSubject>(resDataComboSubject.Data);
                    cboSubject.DataSource = lstSubject;
                    cboSubject.ValueMember = "SubjectId";
                    cboSubject.DisplayMember = "SubjectName";

                }
            }

            //var resDataComboDept = await CallAPICenter.CallAPIGet("/api/MasterData/GetColDeptForCombo");
            //if (resDataComboDept.Status)
            //{
            //    if (resDataComboDept.Data != null)
            //    {
            //        var dataCombo = Util.ConvertListToType<ColDeptCombo>(resDataComboDept.Data);
            //        cboDept.DataSource = dataCombo;
            //        cboDept.ValueMember = "DeptId";
            //        cboDept.DisplayMember = "DeptName";

            //    }
            //}
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            decimal chuyencan = (decimal.Parse(string.IsNullOrEmpty(txtPointChuyenCan.Text) ? "0" : txtPointChuyenCan.Text) * 20);
            decimal asm = ((decimal.Parse(string.IsNullOrEmpty(txtPointASM.Text) ? "0" : txtPointASM.Text)) * 40);
            decimal baove = ((decimal.Parse(string.IsNullOrEmpty(txtPointBaove.Text) ? "0" : txtPointBaove.Text)) * 40);
            label12.Text = ((chuyencan + asm + baove) / 100) + "";
        }
        private void Hanldebutton(string even)
        {
            Event = even;
            if (even == "Load")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDel.Enabled = false;
                btnSave.Enabled = false;

                txtUserId.Enabled = false;
                textBox2.Enabled = false;
                cboSubject.Enabled = false;
                cboSeason.Enabled = false;
                //cboMajor.Enabled = false;
                //cboDept.Enabled = false;
                cboSeason.Enabled = false;
                txtPointChuyenCan.Enabled = false;
                txtPointASM.Enabled = false;
                txtPointBaove.Enabled = false;
                txtUserId.Text = string.Empty;
                textBox2.Text = string.Empty;
                //cboSubject.SelectedIndex = 0;
                //cboSeason.SelectedIndex = 0;
                //cboMajor.SelectedIndex = 0;
                //cboDept.SelectedIndex = 0;
                txtPointChuyenCan.Text = "0";
                txtPointASM.Text = "0";
                txtPointBaove.Text = "0";
            }
            else if (even == "Add" || even == "Edit")
            {
                txtUserId.Enabled = true;
                textBox2.Enabled = true;
                cboSubject.Enabled = true;
                cboSeason.Enabled = true;
                //cboMajor.Enabled = true;
                //cboDept.Enabled = true;
                txtPointChuyenCan.Enabled = true;
                txtPointASM.Enabled = true;
                txtPointBaove.Enabled = true;
                if (even == "Add")
                {
                    txtUserId.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    cboSubject.SelectedIndex = 0;
                    cboSeason.SelectedIndex = 0;
                    //cboMajor.SelectedIndex = 0;
                    //cboDept.SelectedIndex = 0;
                    txtPointChuyenCan.Text = "0";
                    txtPointASM.Text = "0";
                    txtPointBaove.Text = "0";

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDel.Enabled = false;
                    btnSave.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDel.Enabled = false;
                    btnSave.Enabled = true;
                }
            }
            else if (even == "Clear")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDel.Enabled = false;
                btnSave.Enabled = false;

                txtUserId.Enabled = false;
                textBox2.Enabled = false;
                cboSubject.Enabled = false;
                cboSeason.Enabled = false;
                //cboMajor.Enabled = false;
                //cboDept.Enabled = false;
                txtPointChuyenCan.Enabled = false;
                txtPointASM.Enabled = false;
                txtPointBaove.Enabled = false;
                txtUserId.Text = string.Empty;
                textBox2.Text = string.Empty;
                cboSubject.SelectedIndex = 0;
                cboSeason.SelectedIndex = 0;
                //cboMajor.SelectedIndex = 0;
                //cboDept.SelectedIndex = 0;
                txtPointChuyenCan.Text = "0";
                txtPointASM.Text = "0";
                txtPointBaove.Text = "0";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var pointReq = new InputPointRequest()
            {
                _Id = _id,
                MarkId = markId,
                MarkDtlId = markDtlId,
                StudentId = txtUserId.Text,
                SubjectId = cboSubject.SelectedValue.ToString(),
                DeptId = string.Empty,
                MajorId = string.Empty,
                PointDiligence = decimal.Parse(txtPointChuyenCan.Text),
                PointASM = decimal.Parse(txtPointASM.Text),
                PointProtect = decimal.Parse(txtPointBaove.Text),
                AveragePoints = decimal.Parse(label12.Text),
                Season = cboSeason.SelectedValue.ToString()
            };
            var res = await CallAPICenter.CallAPIPost(pointReq, "/api/MasterData/InputPointForStudent");
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
                return;
            }
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hanldebutton("Add");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hanldebutton("Edit");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Hanldebutton("Delete");
        }
        private async void LoadData()
        {
            Hanldebutton("Load");
            string url = "/api/MasterData/GetDataPointforTeacher" + (string.IsNullOrEmpty(txtSearch.Text) ? "" : "?mssv=" + txtSearch.Text);
            var res = await CallAPICenter.CallAPIGet(url);
            if (!res.Status)
            {
                MessageBox.Show(res.ErrMessage);
            }
            if (res.Data == null)
            {
                MessageBox.Show("No data");
                return;
            }
            List<DataPointDtl> lstDtl = Util.ConvertListToType<DataPointDtl>(res.Data);
            //var lstShow = lstDtl.Select(x => new{ 
            //    MarkId=x.MarkId,
            //    MarkDtlId = x.MarkDtlId,
            //    SubjectName = x.SubjectName,
            //    TeacherName = x.TeacherName,
            //    AveragePoints = x.AveragePoints
            //}).ToList();
            var list = new BindingList<DataPointDtl>(lstDtl);
            dataGridView1.DataSource = list;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
            //dataGridView1.Columns[10].Name = "AveragePoints";
            //dataGridView1.Columns[10].HeaderText = "Điểm";
            //dataGridView1.Columns[13].Name = "SubjectName";
            //dataGridView1.Columns[13].HeaderText = "Tên Môn";
            //dataGridView1.Columns[14].Name = "TeacherName";
            //dataGridView1.Columns[14].HeaderText = "Giáo Viên";
            //dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex];
                _id = data.Cells["_Id"].Value.ToString();
                markId = int.Parse(data.Cells["MarkId"].Value.ToString());
                markDtlId = int.Parse(data.Cells["MarkDtlId"].Value.ToString());

                txtUserId.Text = data.Cells["UserId"].Value.ToString();
                textBox2.Text = data.Cells["LastName"].Value.ToString();
                txtPointChuyenCan.Text = data.Cells["PointDiligence"].Value.ToString();
                txtPointBaove.Text = data.Cells["PointProtect"].Value.ToString();
                txtPointASM.Text = data.Cells["PointASM"].Value.ToString();
                label12.Text = data.Cells["AveragePoints"].Value.ToString();
                cboSubject.SelectedIndex = lstSubject.IndexOf(lstSubject.FirstOrDefault(x => x.SubjectId == data.Cells["SubjectId"].Value.ToString()));
                cboSeason.SelectedIndex = lstseason.IndexOf(lstseason.FirstOrDefault(x => x.SeasonId == data.Cells["Season"].Value.ToString()));
                //cboMajor.sel = data.Cells["Image"].Value.ToString();

                Hanldebutton("Edit");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Hanldebutton("Clear");
        }
    }
}
