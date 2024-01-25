using ScheduleDatabaseClassLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class LabEscDisplayModel
    {

        //public int ID { get; set; }
        //[ExcelExportProperty]
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
        [ExcelExportProperty]
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
        public string TimeSpent { get; set; }
        [ExcelExportProperty]
        public string Architecture { get; set; }
        [ExcelExportProperty]
        public string SerialNumbers { get; set; }

    

        public LabEscDisplayModel(LabEscModel model)
        {
            this.MSO = model.MSO;
            this.EndUser = model.EndUser;
            this.City = model.City;
            this.State = model.State;
            this.Country = model.Country;
            this.Severity = model.Severity;
            this.Requestor = model.Requestor;
            this.CTRNum = model.CTRNum;
            this.EscNum = model.EscNum;
            this.EntryAdmin = model.EntryAdmin;
            this.DateCompleted = model.DateCompleted;
            this.DateOpened = model.DateOpened;
            this.DateDue = model.DateDue;
            this.EMail = model.EMail;
            this.Product = model.Product;
            this.LeadAssigned = model.LeadAssigned;
            this.Quantity = model.Quantity;
            this.Status = model.Status;
            this.Comments = model.Comments;
            this.Description = model.Description;  
            this.Resolution = model.Resolution;
            this.PSNumber = model.PSNumber;
            this.RecordType = model.RecordType;
            this.Architecture = model.Architecture;
            this.TimeSpent = model.TimeSpent;
            this.SerialNumbers = model.SerialNumbers;
        }
    }

}
