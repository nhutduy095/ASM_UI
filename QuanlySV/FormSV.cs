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
    public partial class FormSV : Form
    {
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {

        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLichhoc frm = new FormLichhoc();
            frm.ShowDialog();
        }

        private void regServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegService frm = new FormRegService();
            frm.ShowDialog();
        }

        private void PointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBangdiem frm = new FormBangdiem();
            frm.ShowDialog();
        }
    }
}
