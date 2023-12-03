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
    public partial class FormQLSV : Form
    {
        public FormQLSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsLstService_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListService frm = new ListService();
            frm.ShowDialog();
        }

        private void tsServiceConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SrvConfirm frm = new SrvConfirm();
            frm.ShowDialog();
        }

        private void tsLstStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Manage frm = new Student_Manage();
            frm.ShowDialog();
        }

        private void tsLstSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc frm = new MonHoc();
            frm.ShowDialog();
        }

        private void tsLstTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherManage frm = new TeacherManage();
            frm.ShowDialog();
        }
    }
}
