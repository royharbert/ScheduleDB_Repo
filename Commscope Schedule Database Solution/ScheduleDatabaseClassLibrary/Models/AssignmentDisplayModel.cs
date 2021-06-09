using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleDatabaseClassLibrary.Attributes;
using ScheduleDatabaseClassLibrary.GeneralOps;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AssignmentDisplayModel
    {
        [ExcelExportProperty]
        public string RequestID { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public string Activity { get; set; }
        [ExcelExportProperty]
        public string FE_List  { get; set; }
        [ExcelExportProperty]
        public DateTime StartDate { get; set; }
        [ExcelExportProperty]
        public DateTime EndDate { get; set; }        
        public DateTime CustReqDate { get; set; }
        [ExcelExportProperty]
        public string SalesPerson { get; set; }
        [ExcelExportProperty]
        public string ProductList { get; set; }        
        [ExcelExportProperty]
        public int NumTechs { get; set; }
        [ExcelExportProperty]
        public DateTime DateCompleted { get; set; }
        [ExcelExportProperty]
        public int HrsOnSite { get; set; }
        [ExcelExportProperty]
        public string Comments { get; set; }
        [ExcelExportProperty]
        public string CRMNumber { get; set; } 
        public bool DocCovid { get; set; }
        public bool DocCrm { get; set; }
        public bool DocTripRpt { get; set; }
        public bool DocWRE { get; set; }
        public bool DocRoster { get; set; }
        [ExcelExportProperty]
        public string CustomerFirstName { get; set; }
        [ExcelExportProperty]
        public string CustomerLastName { get; set; }
        public int CustomerID { get; set; }
        [ExcelExportProperty]
        public string CustEMail { get; set; }
        [ExcelExportProperty]
        public string CustPhone { get; set; }
        public int LocationID { get; set; }
        [ExcelExportProperty]
        public string SiteName { get; set; } 
        [ExcelExportProperty]
        public string LocAddress { get; set; }
        [ExcelExportProperty]
        public string LocCity { get; set; }
        [ExcelExportProperty]
        public string LocState { get; set; }
        [ExcelExportProperty]
        public string LocCountry { get; set; }
        [ExcelExportProperty]
        public string LocPostalCode { get; set; }
        [ExcelExportProperty]
        public string LocRegion { get; set; }
    }
}
