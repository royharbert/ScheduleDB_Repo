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
        public string EscID { get; set; }
        public string MSO { get; set; }
        public string EndUser { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Severity { get; set; }
        public string Requestor { get; set; }
        public string CTRNum { get; set; }
        public string EscNum { get; set; }
        public bool IsEsc { get; set; }
        public string EntryAdmin { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateCompleted { get; set; }
        public string EMail { get; set; }
        public string Product { get; set; }
        public string LeadAssigned { get; set; }
        public Int64 Quantity { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public string PSNumber { get; set; }
    }
}
