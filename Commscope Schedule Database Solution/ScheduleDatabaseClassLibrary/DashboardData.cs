using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary
{
    public class DashboardData
    {
        int _escalationsOpenedYTD;
        int _escalationsOpenedThisWeek;
        int _escalationsClosedYTD;
        int _escalationsClosedThisWeek;
        int _escalationsCurrentlyOpen;
        int _LabRequestsOpenedYTD;
        int _LabRequestsOpenedThisWeek;
        int _LabRequestsClosedYTD;
        int _LabRequestsClosedThisWeek;
        int _LabRequestsCurrentlyOpen;


        public int EscalationsOpenedYTD { get; set; }
        public int EscalationsOpenedThisWeek { get; set; }
        public int EscalationsClosedYTD { get; set; }
        public int EscalationsClosedThisWeek { get; set; }
        public int EscalationsCurrentlyOpen { get; set; }
        public int LabRequestsOpenedYTD { get; set; }
        public int LabRequestsOpenedThisWeek { get; set; }
        public int LabRequestsClosedYTD { get; set; }
        public int LabRequestsClosedThisWeek { get; set; }
        public int LabRequestsCurrentlyOpen { get; set; }

        public DashboardData()
        {
            RefreshDashboard();
            //EscalationsOpenedYTD = _escalationsOpenedYTD;
            //EscalationsOpenedThisWeek = _escalationsOpenedThisWeek;
            //EscalationsClosedYTD = _escalationsClosedYTD;
            //EscalationsClosedThisWeek = _escalationsClosedThisWeek;
            //EscalationsCurrentlyOpen = _escalationsCurrentlyOpen;
            //LabRequestsOpenedYTD = _LabRequestsOpenedYTD;
            //LabRequestsOpenedThisWeek = _LabRequestsOpenedThisWeek;
            //LabRequestsClosedYTD = _LabRequestsClosedYTD;
            //LabRequestsClosedThisWeek = _LabRequestsClosedThisWeek;
            //LabRequestsCurrentlyOpen = _LabRequestsCurrentlyOpen;
        }
        public DashboardData RefreshDashboard()
        {
            //DashboardData data = new DashboardData();

            int thisYear = DateTime.Now.Year;
            DateTime newYearsDay = new DateTime(thisYear, 1, 1);
            DateTime today = DateTime.Now;
            int weekDay = (int)today.DayOfWeek;
            int daysToMonday = weekDay - 1;
            DateTime monday = today.AddDays(-daysToMonday);
            DateTime sunday = monday.AddDays(6);
            List<LabEscModel> escalationsYTD = GlobalConfig.Connection.DateRangeSearch(newYearsDay, today, "DateOpened",
                "AT Escalation");
            this.EscalationsOpenedYTD = escalationsYTD.Count;

            List<LabEscModel> labRequestsYTD = GlobalConfig.Connection.DateRangeSearch(newYearsDay, today, "DateOpened",
                "Lab Request");
            this.LabRequestsOpenedYTD = labRequestsYTD.Count;

            List<LabEscModel> labRequestsClosedYTD = GlobalConfig.Connection.DateRangeSearch(newYearsDay, today, "DateCompleted",
               "Lab Request");
            this.LabRequestsClosedYTD = labRequestsClosedYTD.Count;

            List<LabEscModel> escalationsClosedYTD = GlobalConfig.Connection.DateRangeSearch(newYearsDay, today,
                "DateCompleted", "AT Escalation");
            this.EscalationsClosedYTD = escalationsClosedYTD.Count;

            List<LabEscModel> escalationsOpenedThisWeek = GlobalConfig.Connection.DateRangeSearch(monday, sunday,
                 "DateOpened", "AT Escalation");
            this.EscalationsOpenedThisWeek = escalationsOpenedThisWeek.Count;

            List<LabEscModel> LabRequestsOpenedThisWeek = GlobalConfig.Connection.DateRangeSearch(monday, sunday,
                "DateOpened", "Lab Request");
            this.LabRequestsOpenedThisWeek = LabRequestsOpenedThisWeek.Count;

            List<LabEscModel> escalationsClosedThisWeek = GlobalConfig.Connection.DateRangeSearch(monday, sunday,
                 "DateCompleted", "AT Escalation");
            this.EscalationsClosedThisWeek= escalationsClosedThisWeek.Count;

            List<LabEscModel> LabRequestsClosedThisWeek = GlobalConfig.Connection.DateRangeSearch(monday, sunday,
                "DateCompleted", "Lab Request");
            this.LabRequestsClosedThisWeek = LabRequestsClosedThisWeek.Count;

            List<LabEscModel> openEscalations = CommonOps.GetReportData("E", "I");
            this.EscalationsCurrentlyOpen = openEscalations.Count;

            List<LabEscModel> openLabRequests = CommonOps.GetReportData("L", "I");
            this.LabRequestsCurrentlyOpen = openLabRequests.Count;

            return this;
        }
    }
}
