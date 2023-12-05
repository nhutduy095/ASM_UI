using QuanlySV.Model.ModelRequest;
using QuanlySV.Model;
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
    public partial class ListService : Form
    {
        private string Event = string.Empty;
        private string _id = string.Empty;
        public ListService()
        {
            InitializeComponent();
            Hanldebutton("Load");
            LoadData();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var serviceReq = new CollectionServiceMst();
            serviceReq.IdService = txtSId.Text;
            serviceReq.ServiceName = txtSName.Text;

            var res = await CallAPICenter.CallAPIPost(serviceReq, "/api/MasterData/CreateOrUpdateServiceMst");
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
            filltering.CollName = "ServiceId";
            filltering.ValueDefault = txtServiceId.Text;
            lstfilltering.Add(filltering);
            RequestPaging requestPaging = new RequestPaging();
            requestPaging.Page = 1;
            requestPaging.PerPage = 100;
            requestPaging.Filltering = lstfilltering;
            var data = await CallAPICenter.CallAPIPost(requestPaging, "/api/MasterData/GetCollectionServiceMst");
            if (data.Status)
            {
                if (data.Data != null)
                {
                    List<CollectionServiceMst> lstDtl = Util.ConvertListToType<CollectionServiceMst>(data.Data);
                    var list = new BindingList<CollectionServiceMst>(lstDtl);
                    dataGridView1.DataSource = list;

                }
            }
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

                txtSId.Enabled = false;
                txtSName.Enabled = false;

            }
            else if (even == "Add" || even == "Edit")
            {
                txtSId.Enabled = true;
                txtSName.Enabled = true;
                if (even == "Add")
                {
                    txtSId.Text = string.Empty;
                    txtSName.Text = string.Empty;

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

                txtSId.Enabled = true;
                txtSName.Enabled = true;

                txtSId.Text = string.Empty;
                txtSName.Text = string.Empty;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex];
                _id = data.Cells["_Id"].Value.ToString();

                txtSId.Text = data.Cells["IdService"].Value.ToString(); 
                txtSName.Text = data.Cells["ServiceName"].Value.ToString();

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
