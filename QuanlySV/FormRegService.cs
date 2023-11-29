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
    public partial class FormRegService : Form
    {
        public FormRegService()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
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
            //var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/CreateOrUpdateServiceReg");
            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/GetCollectionServiceReg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private async void btnReg_Click(object sender, EventArgs e)
        {

            var data = await CallAPICenter.CallAPIPost(new RequestPaging() { Page = 1, PerPage = 100 }, "/api/MasterData/CreateOrUpdateServiceReg");

        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
