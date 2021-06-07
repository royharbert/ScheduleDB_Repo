using ScheduleDatabaseClassLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AssignmentTableModel
    {
        public int ID { get; set; }
        [ExcelExportProperty]
        public string RequestID { get; set; }
        [ExcelExportProperty]
        public string CRMNumber { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public DateTime CustReqDate { get; set; }
        [ExcelExportProperty]
        public DateTime StartDate { get; set; }
        [ExcelExportProperty]
        public DateTime EndDate { get; set; }
        [ExcelExportProperty]
        public string Activity { get; set; }
        [ExcelExportProperty]
        public string Comments { get; set; }
        [ExcelExportProperty]
        public bool DocCovid { get; set; }
        [ExcelExportProperty]
        public bool DocCrm { get; set; }
        [ExcelExportProperty]
        public bool DocTripRpt { get; set; }
        [ExcelExportProperty]
        public bool DocWRE { get; set; }
        [ExcelExportProperty]
        public bool DocRoster { get; set; }
        [ExcelExportProperty]
        public int HrsOnSite { get; set; }
        [ExcelExportProperty]
        public string SalesPerson { get; set; }
        [ExcelExportProperty]
        public DateTime DateCompleted { get; set; }
        [ExcelExportProperty]
        public int NumTechs { get; set; }
        public string ProductListXML { get; set; }
        public string FE_ListXML { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        [ExcelExportProperty]
        public string CustEMail { get; set; }
        [ExcelExportProperty]
        public string CustPhone { get; set; }
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
