using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AssignmentSaveModel
    {
        public int LocationID { get; set; }
        public string CRMNumber { get; set; }
        public int MSO_ID { get; set; }
        public DateTime CustReqDate { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Activity { get; set; }
        public string ProductList { get; set; }
        public int FE1ID { get; set; }
        public int FE2ID { get; set; }
        public int FE3ID { get; set; }
        public string RequestID { get; set; }
        public string Comments { get; set; }
        public int ContactID { get; set; }
        public bool DocCovid { get; set; }
        public bool DocCrm { get; set; }
        public bool DocTripRpt { get; set; }
        public bool DocWRE { get; set; }
        public bool DocRoster { get; set; }
        public int HrsOnSite { get; set; }
        public int Requestor { get; set; }
        public DateTime DateCompleted { get; set; }
        public int NumTechs { get; set; }
        public string ProductListXML { get; set; }
        public string FE_ListXML { get; set; }
        public int Activity_ID { get; set; }

    }
}
