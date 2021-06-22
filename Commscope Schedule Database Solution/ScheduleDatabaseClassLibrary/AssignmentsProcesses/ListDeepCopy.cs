using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.AssignmentsProcesses
{
    public class ListDeepCopy<T>
    {
        private List<T> returnList = null;
        
        public List<T> SourceList
        {
            set
            {
                returnList = null;
                returnList = new List<T>();
                foreach (var item in value)
                {
                    returnList.Add(item);
                }
            }
        }

        public List<T> ReturnList 
        { 
            get 
            {
                return returnList;
            }            
        }
        public ListDeepCopy()
        {
           
        }
    }
}
