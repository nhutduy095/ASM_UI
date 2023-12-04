using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
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
    public partial class MonHoc : Form
    {
        private string Event = string.Empty;
        private string _id = string.Empty;
        private string subjectId = string.Empty;
        private string subjectName = string.Empty;
        private int numberOfCredits = 0;

        public MonHoc()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var subjectReq = new CollSubject();
            subjectReq.SubjectId = txtSubjectId.Text;
            subjectReq.SubjectName = txtSubjectName.Text;
            subjectReq.NumberOfCredits = int.Parse(txtTinchi.Text);

            var res = await CallAPICenter.CallAPIPost(subjectReq, "/api/MasterData/CreateOrUpdateSubject");
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
            List<Filltering> lstfilltering = new List<Filltering>();
            var filltering = new Filltering();
            filltering.CollName = "SubjectId";
            filltering.ValueDefault = txtSId.Text;
            lstfilltering.Add(filltering);
            RequestPaging requestPaging = new RequestPaging();
            requestPaging.Page = 1;
            requestPaging.PerPage = 100;
            requestPaging.Filltering = lstfilltering;
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/GetCollectionSubject");
            if (data.Status)
            {
                if (data.Data != null)
                {
                    List<CollSubject> lstDtl = Util.ConvertListToType<CollSubject>(data.Data);
                    var list = new BindingList<CollSubject>(lstDtl);
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

                txtSubjectId.Enabled = false;
                txtSubjectName.Enabled = false;
                txtTinchi.Enabled = false;

            }
            else if (even == "Add" || even == "Edit")
            {
                txtSubjectId.Enabled = true;
                txtSubjectName.Enabled = true;
                txtTinchi.Enabled = true;
                if (even == "Add")
                {
                    txtSubjectId.Text = string.Empty;
                    txtSubjectName.Text = string.Empty;
                    txtTinchi.Text = string.Empty;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                }
            }
            else if (even == "Clear")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;

                txtSubjectId.Enabled = true;
                txtSubjectName.Enabled = true;
                txtTinchi.Enabled = true;

                txtSubjectId.Text = string.Empty;
                txtSubjectName.Text = string.Empty;
                txtTinchi.Text = string.Empty;
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
                subjectId = data.Cells["SubjectId"].Value.ToString();
                subjectName = data.Cells["SubjectName"].Value.ToString();
                numberOfCredits = int.Parse(data.Cells["NumberOfCredits"].Value.ToString());

                txtSubjectId.Text = subjectId;
                txtSubjectName.Text = subjectName;
                txtTinchi.Text = numberOfCredits+"";

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
