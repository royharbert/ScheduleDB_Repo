using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary
{
    public static class ReportOps
    {
        public static List<LabEscModel>GetOpenEscByDateDue()
        {
            return GlobalConfig.Connection.GetOpenEscSortedByDateDue();
        }
    }
}
