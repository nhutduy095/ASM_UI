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
    public partial class SrvConfirm : Form
    {
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
            cboConfirm.Items.Add(new {Key="A",Value="Approve"});
            cboConfirm.Items.Add(new { Key="R",Value= "Reject" });
            cboConfirm.ValueMember = "Key";
            cboConfirm.DisplayMember = "Value";

        }

    
    }
}
