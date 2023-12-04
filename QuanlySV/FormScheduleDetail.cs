using QuanlySV.Configuration;
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
    public partial class FormScheduleDetail : Form
    {
        public FormScheduleDetail(CollectionScheduleDtl dtl)
        {
            InitializeComponent();
            lblclass.Text = dtl.ClassId;
            lblday.Text = dtl.Day;
            lblendtime.Text = dtl.ToTime;
            lblfromtime.Text = dtl.FromTime;
            lblmonhoc.Text = dtl.SubjectId;
            lblshift.Text = dtl.Shift;
            lbltecher.Text = dtl.TeacherId;
            if (Config.userType == "S")
            {
                lblclass.Visible = true;
                label3.Visible = true;
                lblclass.Text = dtl.RoomId;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLichhoc formLichhoc = new FormLichhoc();
            formLichhoc.Show();
        }
    }
}
