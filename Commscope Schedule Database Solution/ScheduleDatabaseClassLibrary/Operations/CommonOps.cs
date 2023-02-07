using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.Operations
{
    public static class CommonOps
    { 
         /// <summary>
         /// locks or unlocks all textboxes, comboboxes, richtext boxes and list boxes
         /// unless they are in the comma separated skipList(no spaces)
         /// </summary>
         /// <param name="lockControl"> bool to indicate whether to lock or unlock</param>
         /// <param name="skipList">Comma separated list of control names to skip over</param>
        public static void lockControls(bool lockControl, Form frm, string skipList)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox | control is ComboBox | control is RichTextBox | control is ListBox
                     | control is DateTimePicker)
                {
                    int idx = skipList.IndexOf(control.Name);
                    if (idx == -1)
                    {
                        control.Enabled = !lockControl;
                    }
                }
            }
            //lockPanels(lockControl, "", pnlCustomer);
            //lockPanels(lockControl, "", pnlLocation);
    }
    
        public static FE_Model ToggleFE_ActiveStatus(FE_Model model)
        {
            GlobalConfig.Connection.ToggleActiveStatus("tblFE", "Active", model.ID, "ID");
            model.Active = ! model.Active;
            return model;
        }


        public static void ToggleMSO_ActiveStatus(DataGridView dgv)
        {
            int idx = 0;
            int.TryParse(dgv.CurrentRow.Cells[2].Value.ToString(), out idx);
            //bool status =  GlobalConfig.Connection.GetCurrentActivityStatus("tblMSO", "Active", idx, "ID");
            GlobalConfig.Connection.ToggleActiveStatus("tblMSO", "Active", idx, "ID");
            List<MSO_Model> msoList = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
            dgv.DataSource = msoList;
        }
        public static void MakeMSO_StatusList(List<MSO_Model> msoList, DataGridView dgv)
        {
            dgv.DataSource = msoList;
            dgv.Columns[1].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static DateTime dtpReset(DateTimePicker dtp)
        {
            if (dtp.Value <= Globals.nullDate)
            {
                dtp.Value = new DateTime(1900, 1, 1);
                Application.DoEvents();
                dtp.CustomFormat = " ";
                dtp.Format = DateTimePickerFormat.Custom;
            }
            return dtp.Value;
        }


        public static DateTime dtpForcedReset(DateTimePicker dtp)
        {
            
            dtp.Value = new DateTime(1900, 1, 1);
            Application.DoEvents();
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
            
            return dtp.Value;
        }

        public static  void loadComboList<T>(ComboBox cbo)
        {
            string tagString = cbo.Tag.ToString();
            string[] tagArray = tagString.Split('|');
            string tableName = tagArray[0];
            string displayItem = tagArray[1];
            List<T> boxList = GlobalConfig.Connection.GenericGetAll<T>(tableName, displayItem);
        }
        public static DateTime CalculateDateDue(DateTime StartDate, string severity)
        {
            //get list of holidays
            List<CompanyHolidaysModel> holidayList = GlobalConfig.Connection.GetAllHolidays();
            //create list of holiday dates
            List<DateTime> holidayDates = new List<DateTime>();
            foreach (var holiday in holidayList)
            {
                holidayDates.Add(holiday.HolidayDate.Date);
            }
            //use Pty to determine work days
            int workDays = 0;
            switch (severity)
            {
                case "L1":
                    workDays = (int)sevty.L1;
                    break;

                case "L2":
                    workDays = (int)sevty.L2;
                    break;

                case "L3":
                    workDays = (int)sevty.L3;
                    break;

                default:
                    break;
            }
            //loop thru for number of days
            DateTime currentDay = StartDate;
            int wkDay = 1;
            while (wkDay <= workDays)
            {
                //check day of week
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    //check to see if current date is holiday
                    if (!holidayDates.Contains(currentDay.Date))
                    {
                        //if not holiday increment counter
                        wkDay++;
                    }
                }
                currentDay = currentDay.AddDays(1);

            }

            //make sure not returning holiday or weekend
            while (currentDay.DayOfWeek == DayOfWeek.Saturday || currentDay.DayOfWeek == DayOfWeek.Sunday
                || holidayDates.Contains(currentDay.Date))
            {
                currentDay = currentDay.AddDays(1);
            }
            //at end of loop return date
            return currentDay.Date;
        }
    }
}
