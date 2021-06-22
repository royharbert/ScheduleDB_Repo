using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.TableOps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.AssignmentsProcesses
{
    public  class AssignmentSaver
    {
        private static List<AssignmentSaveModel> _request = null;
        private static DataTable _table = null;
        public  List<AssignmentSaveModel> Request 
        {     
            set
            {
                _request = value;
                TableGenerator<AssignmentSaveModel> tg = new TableGenerator<AssignmentSaveModel>();
                tg.List = _request;
                _table = tg.table;
            } 
        }
        public DataTable Table 
        { 
            get
            {
                return _table;
            }
        }
    }
}
