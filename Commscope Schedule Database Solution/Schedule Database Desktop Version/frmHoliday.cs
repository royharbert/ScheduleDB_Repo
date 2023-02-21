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
                dt.Rows.Add(dgvHolidays.Rows[k].Cells[0].Value.ToString(), dgvHolidays.Rows[k].Cells[1].Value);
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

        private void frmHoliday_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);
            HolidayList = GetHolidays();
            sHolidayList = make_hList(HolidayList);
            DataTable dtbl = makeTable(sHolidayList);
            dgvHolidays.DataSource = dtbl;
            dgvHolidays.Refresh();
            dgvHolidays.AutoGenerateColumns = false;
            dgvHolidays.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHolidays.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvHolidays_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if (col == 1)
            {
                DateTimePicker dtp = new DateTimePicker();
                dgvHolidays.Controls.Add(dtp);
                //dtp.Format = DateTimePickerFormat.Short;
                Rectangle rect = dgvHolidays.GetCellDisplayRectangle(col, row,true);
                dtp.Size = new Size(rect.Width, rect.Height);
                dtp.Location = new Point(rect.X, rect.Y);
                dtp.CloseUp += new EventHandler(dtp_CloseUp);
                dtp.Visible = true;
            }
        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dgvHolidays.CurrentCell.Value = dtp.Text.ToString();
            dtp.Visible = false;
        }

        
    }
}
