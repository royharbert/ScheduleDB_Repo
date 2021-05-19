using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class FE_Model
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ManagerID { get; set; }
        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Region { get; set; }
        public string Phone { get; set; }        
        public string EMail { get; set; }
    }
}
