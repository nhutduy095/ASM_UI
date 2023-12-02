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
    public partial class FormGV : Form
    {
        public FormGV()
        {
            InitializeComponent();
        }
        private void FormSV_Load(object sender, EventArgs e)
        {

        }

        private void lịchDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLichhoc frm = new FormLichhoc();
            frm.ShowDialog();
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapDiem frm = new NhapDiem();
            frm.ShowDialog();
        }
    }
}
