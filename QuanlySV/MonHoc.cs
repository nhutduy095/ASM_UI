using QuanlySV.Model;
using QuanlySV.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class MonHoc : Form
    {
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
            var subjectReq = new CollSubject();
            subjectReq.SubjectId = txtSId.Text;
            LoadData();
        }
    }
}
