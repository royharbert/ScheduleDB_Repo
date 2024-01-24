using Microsoft.Office.Interop.Excel;
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if (control is System.Windows.Forms.TextBox | control is System.Windows.Forms.ComboBox | control is RichTextBox | control is System.Windows.Forms.ListBox
                     | control is DateTimePicker)
                {
                    int idx = skipList.IndexOf(control.Name);
                    if (idx == -1)
                    {
                        control.Enabled = !lockControl;
                    }
                }
            }
        }

        

        public static List<LabEscModel> GetReportData(string RecordType = "", string RecordStatus = "")
        {
            List<LabEscModel> models = new List<LabEscModel>();
            string status = "";
            switch (RecordType)
            {
                case "E":
                    RecordType = "AT Escalation";
                    status = GetStatusString(RecordStatus);
                    models = GlobalConfig.Connection.GetReportModel(status, RecordType);
                    break;
                case "L":
                    RecordType = "Lab Request";
                    status = GetStatusString(RecordStatus);
                    models = GlobalConfig.Connection.GetReportModel(status, RecordType);
                    break;
                case "":
                    models = GlobalConfig.Connection.GetOpenEscSortedByDateDue();
                    break;

            }

            return models;
        }

        private static string GetStatusString(string recStatus)
        {
            string status = "";
            switch (recStatus)
            {
                case "I":
                    status = "In process";
                    break;
                case "C":
                    status = "Closed";
                    break;
                case "X":
                    status = "Canceled";
                    break;
            }
            return status;
        }

        

        public static void lockControls(bool lockControl, TableLayoutPanel frm, string skipList)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is System.Windows.Forms.TextBox | control is System.Windows.Forms.ComboBox | control is RichTextBox | control is System.Windows.Forms.ListBox
                     | control is DateTimePicker)
                {
                    int idx = skipList.IndexOf(control.Name);
                    if (idx == -1)
                    {
                        control.Enabled = !lockControl;
                    }
                }
            }
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
                System.Windows.Forms.Application.DoEvents();
                dtp.CustomFormat = " ";
                dtp.Format = DateTimePickerFormat.Custom;
            }
            return dtp.Value;
        }


        public static DateTime dtpForcedReset(DateTimePicker dtp)
        {
            
            dtp.Value = new DateTime(1900, 1, 1);
            System.Windows.Forms.Application.DoEvents();
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
            
            return dtp.Value;
        }

        public static  void loadComboList<T>(System.Windows.Forms.ComboBox cbo)
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
            List<HolidaysModel> holidayList = GlobalConfig.Connection.GetAllHolidays();
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
