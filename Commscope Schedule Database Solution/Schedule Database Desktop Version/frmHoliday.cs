using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Schedule_Database_Desktop_Version
{
    public partial class frmHoliday : Form
    {
        List<StringHolidaysModel> sHolidayList = new List<StringHolidaysModel>();
        List<CompanyHolidaysModel> HolidayList = new List<CompanyHolidaysModel>();
        public frmHoliday()
        {
            InitializeComponent();
            HolidayList = GetHolidays();
            sHolidayList = make_hList(HolidayList);
            DataTable dtbl = makeTable(sHolidayList);
            dgvHolidays.DataSource = dtbl;
            dgvHolidays.Refresh();
            dgvHolidays.AutoGenerateColumns = false;
        }
        private List<CompanyHolidaysModel> GetHolidays()
        {
            HolidayList = GlobalConfig.Connection.GetAllHolidays();
            return HolidayList;
        }
        private List<StringHolidaysModel> make_hList(List<CompanyHolidaysModel> cHoliday)
        {
            foreach (CompanyHolidaysModel holiday in cHoliday)
            {
                StringHolidaysModel sHol = new StringHolidaysModel();
                sHol.Holiday = holiday.Holiday;
                sHol.HolidayDate = holiday.HolidayDate.ToShortDateString();
                sHolidayList.Add(sHol);
            }
            return sHolidayList;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Holiday");
            dt.Columns.Add("HolidayDate");
            int i = dgvHolidays.Rows.Count;

            for (int k = 0; k < i - 1; k++)
            {
                dt.Rows.Add(dgvHolidays.Rows[k].Cells[0].Value.ToString(), dgvHolidays.Rows[k].Cells[1].Value.ToString());
            }
            ScheduleDatabaseClassLibrary.Holiday_Update.UpdateHolidays(dt);
            MessageBox.Show("Updates saved");
        }

        private static DataTable makeTable(List<StringHolidaysModel> hList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Holiday");
            dt.Columns.Add("HolidayDate");

            foreach (StringHolidaysModel hDay in hList)
            {
                dt.Rows.Add(hDay.Holiday, hDay.HolidayDate);
            }
            return dt;
        }
    }
}
