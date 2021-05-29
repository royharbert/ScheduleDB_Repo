using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class LocationModel : IHaveID
    {
        public int ID { get; set; }
        public string SiteName { get; set; }
        public string MSO { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public int ContactID { get; set; }
    }
}
