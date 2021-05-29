using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class CustomerModel : IHaveID
    {
        private string fullName;
        private string firstName;
        private string lastName;

        public int ID { get; set; }
        public string FirstName 
        {
            get 
            { 
                return firstName; 
            }
            set 
            {
                firstName = value;
                makeFullName(); 
            }
        }
        public string LastName
        {
            get 
            { 
                return lastName; 
            }
            set 
            {
                lastName = value;
                makeFullName(); 
            }
        }
        
        public string MSO { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public int LocID { get; set; }

        public string FullName
        {
            get { return fullName; }            
        }

        private void makeFullName()
        {
            fullName = firstName + " " + lastName;
        }


    }
}
