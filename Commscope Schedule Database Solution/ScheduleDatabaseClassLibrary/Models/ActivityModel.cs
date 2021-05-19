using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class ActivityModel
    {
        public int ID { get; set; }
        public string Purpose { get; set; }
        public bool CRMTicket { get; set; }
        public bool TripReport { get; set; }
        public bool WeeklyReportEntry { get; set; }
        public bool Roster { get; set; }
        public bool COVID_Form { get; set; }
    }
}
