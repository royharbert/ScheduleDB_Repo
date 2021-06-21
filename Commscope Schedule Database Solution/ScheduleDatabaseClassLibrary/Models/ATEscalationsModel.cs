using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class ATEscalationsModel
    {
        public int id { get; set; }
        public string MSO { get; set; }
        public string ATEType { get; set; }
        public string PartNumberXML { get; set; }
        public string ATEDescription { get; set; }
        public string Quantity { get; set; }
        public DateTime ResolvedDate { get; set; }
        public string Resolution { get; set; }
        public string FELeadXML { get; set; }
        public string Comments { get; set; }
        public string CTRNumber { get; set; }
        public string PeopleSoftNumber { get; set; }
        public DateTime DateReported { get; set; }
        public string ATEStatus { get; set; }
    }
}
