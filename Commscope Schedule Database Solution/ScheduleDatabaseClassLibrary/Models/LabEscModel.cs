using ScheduleDatabaseClassLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class LabEscModel    
    {
        public int ID { get; set; }
        [ExcelExportProperty]
        public string EscID { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public string EndUser { get; set; }
        [ExcelExportProperty]
        public string City { get; set; }
        [ExcelExportProperty]
        public string State { get; set; }
        [ExcelExportProperty]
        public string Country { get; set; }
        [ExcelExportProperty]
        public string Severity { get; set; }
        [ExcelExportProperty]
        public string Requestor { get; set; }
        [ExcelExportProperty]
        public string CTRNum { get; set; }
        [ExcelExportProperty]
        public string EscNum { get; set; }
        [ExcelExportProperty]
        public string EntryAdmin { get; set; }
        [ExcelExportProperty]
        public DateTime DateOpened { get; set; }
        [ExcelExportProperty]
        public DateTime DateDue { get; set; }
        [ExcelExportProperty]
        public DateTime DateCompleted { get; set; }
        public string EMail { get; set; }
        [ExcelExportProperty]
        public string Product { get; set; }
        [ExcelExportProperty]
        public string LeadAssigned { get; set; }
        [ExcelExportProperty]
        public Int64 Quantity { get; set; }
        [ExcelExportProperty]
        public string Status { get; set; }
        [ExcelExportProperty]
        public string Comments { get; set; }
        [ExcelExportProperty]
        public string Description { get; set; }
        [ExcelExportProperty]
        public string Resolution { get; set; }
        [ExcelExportProperty]
        public string PSNumber { get; set; }
        [ExcelExportProperty]
        public string RecordType { get; set; }
        [ExcelExportProperty]
        public string ProdApp { get; set; }
        public string Architecture { get; set; }
    }
}
