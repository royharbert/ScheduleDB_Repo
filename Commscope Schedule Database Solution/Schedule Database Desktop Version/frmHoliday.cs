using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
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
        List<HolidaysModel> sHolidayList = new List<HolidaysModel>();
        List<HolidaysModel> HolidayList = new List<HolidaysModel>();
        public frmHoliday()
        {
            InitializeComponent();
        }
        private List<HolidaysModel> GetHolidays()
        {
            HolidayList = GlobalConfig.Connection.GetAllHolidays();
            return HolidayList;
        }
        private List<HolidaysModel> make_hList(List<HolidaysModel> cHoliday)
        {
            foreach (HolidaysModel holiday in cHoliday)
            {
                HolidaysModel sHol = new HolidaysModel();
                sHol.Holiday = holiday.Holiday;
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
            int i = dgvHolidays.Rows.Count;

            for (int k = 0; k < i - 1; k++)
            {
                int idx;
                string holiday = dgvHolidays.Rows[k].Cells[1].Value.ToString();
                DateTime date;
                DateTime.TryParse(dgvHolidays.Rows[k].Cells[2].Value.ToString() ?? "", out date);
                int.TryParse(dgvHolidays.Rows[k].Cells[0].Value.ToString(), out idx);
                GlobalConfig.Connection.UpdateHolidays(holiday, date, idx);

            }
            dgvHolidays.DataSource = null;
            dgvHolidays.DataSource = GetHolidays();
            MessageBox.Show("Updates saved");
        }

        private static DataTable makeTable(List<HolidaysModel> hList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Holiday");
            dt.Columns.Add("HolidayDate");

            foreach (HolidaysModel hDay in hList)
            {
                dt.Rows.Add(hDay.Holiday, hDay.HolidayDate);
            }
            return dt;
        }

        private void frmHoliday_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);

            SearchOps.SetMenuAccess(this, GV.USERMODEL);
            List<HolidaysModel> HolidayList = GetHolidays();
            dgvHolidays.DataSource = HolidayList;
            dgvHolidays.Refresh();
            dgvHolidays.AutoGenerateColumns = false;
            dgvHolidays.Columns[0].Visible= false;
            dgvHolidays.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHolidays.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Width = 561;
        }

        private void dgvHolidays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            switch (col)                
            {                
                case 2:
                    DateTimePicker dtp = new DateTimePicker();
                    dgvHolidays.Controls.Add(dtp);
                    Rectangle rect = dgvHolidays.GetCellDisplayRectangle(col, row, true);
                    dtp.Size = new Size(rect.Width, rect.Height);
                    dtp.Location = new Point(rect.X, rect.Y);
                    dtp.CloseUp += new EventHandler(dtp_CloseUp);
                    dtp.Format = DateTimePickerFormat.Short;
                    dtp.Visible = true;
                    break;
            }
        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dgvHolidays.CurrentCell.Value = dtp.Value.ToString();
            dtp.Visible = false;
            dtp.Dispose();
        }

        private void dgvHolidays_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int idx;
                DateTime holidayDate;
                string holiday = dgvHolidays.CurrentCell.Value.ToString();
                DateTime.TryParse(dgvHolidays.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "", out holidayDate);
                int.TryParse(dgvHolidays.CurrentRow.Cells[0].Value.ToString(), out idx);
                GlobalConfig.Connection.UpdateHolidays(holiday, holidayDate, idx);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            this.Width = 979;
        }

        private void btnNewHoliday_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.HolidayAdd(txtName.Text, dtpHoliday.Value);
            btnAddNew.Enabled = true;
            this.Width = 561;
            List<HolidaysModel> holidays = GetHolidays();
            dgvHolidays.DataSource = null;
            dgvHolidays.DataSource = holidays;
        }

        private void btnDeleteHol_Click(object sender, EventArgs e)
        {

        }
    }
}
