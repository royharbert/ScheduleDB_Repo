using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AdminModel
    {
        public int ID { get; set; }
        public string PW { get; set; }
        public int Priviledge { get; set; }
        public bool Active { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName 
        { get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
