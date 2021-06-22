
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PW { get; set; }
        public int Priviledge { get; set; }
        public bool ActiveDesigner { get; set; }
        private string _fullName;

        public string FullName
        {
            get 
            {
                _fullName = FirstName + " " + LastName;
                return _fullName; 
            }
            
        }


        public UserModel()
        {

        }

        public UserModel (string lastName, string firstName, string pW, string priviledge, string activeDesigner, string id)
        {
            LastName = lastName;
            firstName = FirstName;            
            PW = pW;

            int pValue = 0;
            int.TryParse(priviledge, out pValue);
            Priviledge = pValue;

            bool pActive = true;
            bool.TryParse(activeDesigner, out pActive);
            ActiveDesigner = pActive;

            int IDval = 0;
            int.TryParse(id, out IDval);
            ID = IDval;
        }
    }


}
