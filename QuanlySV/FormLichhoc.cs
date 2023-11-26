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
    public partial class FormLichhoc : Form
    {
        private int month, year;
        public FormLichhoc()
        {
            InitializeComponent();
            Display();
        }
        private void LoadData()
        {

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
    }
}
