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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlySV
{
    public partial class UserControlDays : UserControl
    {
        private List<CollectionScheduleDtl> lstScheduleDtl;
        public UserControlDays()
        {
            InitializeComponent();
            lstScheduleDtl=new List<CollectionScheduleDtl>();
        }
        public void days(int numday)
        {
            lblday.Text = numday.ToString();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void ShowListSchedule(List<CollectionScheduleDtl> lstData)
        {
            lstScheduleDtl=lstData;
            var data = lstData?.Select(x => new { DtlId = x.DtlId, RoomId = x.SubjectId + "-" + x.Shift }).ToList();
            listBox1.DisplayMember = "RoomId";
            listBox1.ValueMember = "DtlId";
            listBox1.DataSource = data;
            //foreach (var dtl in lstData)
            //{
            //    //var dic = new Dictionary<int, string>() { { dtl.DtlId, dtl.ClassId.ToString() } };
            //    //lst.Add(dic);
            //    listBox1.Items.Add(dtl.RoomId));
            //}
            //listBox1.Items.AddRange(lstData.Select(x => new { DtlId=x.DtlId, RoomId= x.RoomId }).ToList());
            //List<Dictionary<int, string>> lst = new List<Dictionary<int, string>>();
            //foreach (var dtl in lstData)
            //{
            //    var dic = new Dictionary<int, string>() { { dtl.DtlId, dtl.ClassId.ToString() } };
            //    lst.Add(dic);
            //}
            //listView1.Items.Add(new ListViewItem(new string[] { dtl.DtlId + "", dtl.RoomId }));
            //dataGridView1.DataSource = lst;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int dtlId = int.Parse(listBox1.SelectedValue.ToString());
            //string aa=a.DtlId as string;
            var dtl=lstScheduleDtl.FirstOrDefault(x => x.DtlId == dtlId);
            FormScheduleDetail frm = new FormScheduleDetail(dtl);
            this.Hide();
            frm.Show();
        }
    }
}
