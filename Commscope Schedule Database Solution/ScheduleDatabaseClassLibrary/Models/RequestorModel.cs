using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class RequestorModel : IHaveID
    {
        public string SalesPerson { get; set; }
        public bool Active { get; set; }
        public int ID { get; set; }
    }
}
