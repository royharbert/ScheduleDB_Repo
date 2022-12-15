using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AdminModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        { get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Prividedge { get; set; }


    }
}
