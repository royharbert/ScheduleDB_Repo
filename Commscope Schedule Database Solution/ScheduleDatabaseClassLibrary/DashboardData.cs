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
        public List<LabEscModel> EscalationsOpenedYTD { get; set; }
        public List<LabEscModel> EscalationsOpenedThisWeek { get; set; }
        public List<LabEscModel> EscalationsClosedYTD { get; set; }
        public List<LabEscModel> EscalationsClosedThisWeek { get; set; }
        public List<LabEscModel> EscalationsCurrentlyOpen { get; set; }
        public List<LabEscModel> LabRequestsOpenedYTD { get; set; }
        public List<LabEscModel> LabRequestsOpenedThisWeek { get; set; }
        public List<LabEscModel> LabRequestsClosedYTD { get; set; }
        public List<LabEscModel> LabRequestsClosedThisWeek { get; set; }
        public List<LabEscModel> LabRequestsCurrentlyOpen { get; set; }

        public DashboardData()
        {
            RefreshDashboard();   
        }
        public DashboardData RefreshDashboard()
        {
            DateTime today = DateTime.Now.Date;
            TimeFrameModel timeFrame = new TimeFrameModel();
            List<LabEscModel> allItems = GlobalConfig.Connection.GenericGetAll<LabEscModel>("tblEscalations", "EscID");
            List<LabEscModel> escalationsList = allItems.Where(x => x.RecordType == "AT Escalation" && x.DateOpened >= timeFrame.NewYearsDay).ToList();
            List<LabEscModel> requestsList = allItems.Where(x => x.RecordType == "Lab Request" && x.DateOpened >= timeFrame.NewYearsDay).ToList();
            allItems = null;

            this.EscalationsOpenedYTD = escalationsList.Where(x => x.DateOpened >= timeFrame.NewYearsDay 
                &&  x.DateOpened <= today && x.Status == "In process").ToList();
            this.EscalationsOpenedThisWeek = escalationsList.Where(x => x.DateOpened >= timeFrame.MondaysDate
                && x.DateOpened <= timeFrame.SundaysDate && x.Status == "In process").ToList();
            this.EscalationsCurrentlyOpen = escalationsList.Where(x => x.Status == "In process").ToList();
            this.EscalationsClosedYTD = escalationsList.Where(x => x.DateCompleted >= timeFrame.NewYearsDay 
                && x.DateCompleted <= today && x.Status == "Closed").ToList();
            this.EscalationsClosedThisWeek = escalationsList.Where(x => x.DateCompleted >= timeFrame.MondaysDate
                && x.DateCompleted <= today && x.Status == "Closed").ToList();

            this.LabRequestsOpenedYTD = requestsList.Where(x => x.DateOpened >= timeFrame.NewYearsDay
                && x.DateOpened <= today && x.Status == "In process").ToList();
            this.LabRequestsOpenedThisWeek = requestsList.Where(x => x.DateOpened >= timeFrame.MondaysDate
                && x.DateOpened <= timeFrame.SundaysDate && x.Status == "In process").ToList();
            this.LabRequestsCurrentlyOpen = requestsList.Where(x => x.Status == "In process").ToList();
            this.LabRequestsClosedYTD = requestsList.Where(x => x.DateCompleted >= timeFrame.NewYearsDay
                && x.DateCompleted <= today && x.Status == "Closed").ToList();
            this.LabRequestsClosedThisWeek = requestsList.Where(x => x.DateCompleted >= timeFrame.MondaysDate
                && x.DateCompleted <= today && x.Status == "Closed").ToList();

            return this;
        }
    }
}
