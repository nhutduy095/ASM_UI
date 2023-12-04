using QuanlySV.Configuration;
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
    public partial class FormLichhoc : Form
    {
        private int month, year;
        public FormLichhoc()
        {
            InitializeComponent();
            Display();
            if (Config.userType == "T")
            {
                label18.Text = "Lịch dạy";
            }
            else
            {
                label18.Text = "Lịch học";
            }
        }
        private async void LoadData()
        {
            //List<Filltering> lstfilltering = new List<Filltering>();
            //var filltering=new Filltering();
            //filltering.CollName = "Shift";
            //filltering.ValueDefault = cboHocKy.Text;
            //lstfilltering.Add(filltering);
            //var filltering1 = new Filltering();
            //filltering1.CollName = "Day";
            //filltering1.ValueDefault = dateTimePicker1.Value.ToString();
            //lstfilltering.Add(filltering1);
            //RequestPaging requestPaging = new RequestPaging();
            //requestPaging.Page = 1;
            //requestPaging.PerPage = 100;
            //requestPaging.Filltering = lstfilltering;
            ////var data = await CallAPICenter.CallAPIPost(requestPaging);
            //var data = await CallAPICenter.CallAPIPost(requestPaging, "/api/MasterData/GetCollectionScheduleDtl");
            //if (data.Status)
            //{
            //    if (data.Data != null)
            //    {
            //        List<CollectionScheduleDtl> lstDtl = Util.ConvertListToType<CollectionScheduleDtl>(data.Data);
            //        var list = new BindingList<CollectionScheduleDtl>(lstDtl);
            //        dataGridView1.DataSource = list;

            //    }
            //}
        }
        private async void Display()
        {
            daycontainer.Controls.Clear();
            DateTime now = DateTime.Now;
            DateTime startofmonth = new DateTime(now.Year, now.Month, 1);
            month = now.Month;
            year = now.Year;
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));
            string url = "/api/MasterData/GetScheduleForUser?userId=" + Config.userId + "&month=" + month + "&year=" + year + "@shift=" + cboHocKy.SelectedValue;
            //List<Filltering> lstfilltering = new List<Filltering>();
            //var filltering = new Filltering();
            //filltering.CollName = "Shift";
            //filltering.ValueDefault = cboHocKy.Text;
            //lstfilltering.Add(filltering);
            //var filltering1 = new Filltering();
            //filltering1.CollName = "Day";
            //filltering1.ValueDefault = dateTimePicker1.Value.ToString();
            //lstfilltering.Add(filltering1);
            //RequestPaging requestPaging = new RequestPaging();
            //requestPaging.Page = 1;
            //requestPaging.PerPage = 100;
            //requestPaging.Filltering = lstfilltering;
            var res = await CallAPICenter.CallAPIGet(url);
            List<CollectionScheduleDtl> lstScheduleOfMonth = Util.ConvertListToType<CollectionScheduleDtl>(res.Data);
            for (int i = 0; i < dayofweek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                daycontainer.Controls.Add(userControl);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                var lstScheduleOfDay = lstScheduleOfMonth?.Where(x => DateTime.Parse(x.Day).Day == i).ToList();
                ucDays.ShowListSchedule(lstScheduleOfDay);
                daycontainer.Controls.Add(ucDays);
            }
        }

        private async void btnPre_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));
            string url = "/api/MasterData/GetScheduleForUser?userId=" + Config.userId + "&month=" + month + "&year=" + year;
            var res = await CallAPICenter.CallAPIGet(url);
            List<CollectionScheduleDtl> lstScheduleOfMonth = Util.ConvertListToType<CollectionScheduleDtl>(res.Data);
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                daycontainer.Controls.Add(userControl);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                var lstScheduleOfDay = lstScheduleOfMonth.Where(x => DateTime.Parse(x.Day).Day == i).ToList();
                ucDays.ShowListSchedule(lstScheduleOfDay);
                daycontainer.Controls.Add(ucDays);

            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));
            string url = "/api/MasterData/GetScheduleForUser?userId=" + Config.userId + "&month=" + month + "&year=" + year;
            var res = await CallAPICenter.CallAPIGet(url);
            List<CollectionScheduleDtl> lstScheduleOfMonth = Util.ConvertListToType<CollectionScheduleDtl>(res.Data);
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank userControl = new UserControlBlank();
                daycontainer.Controls.Add(userControl);
            }
            for (int i = 1; i <= days; i++)
            {

                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                var lstScheduleOfDay = lstScheduleOfMonth.Where(x => DateTime.Parse(x.Day).Day == i).ToList();
                ucDays.ShowListSchedule(lstScheduleOfDay);
                daycontainer.Controls.Add(ucDays);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        
    }
}
