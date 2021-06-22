using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class PID_Generator
    {
        public static string GeneratePID(MSO_Model mso)
        {
            string pid = "SR_";
            string dateStamp = DateTime.Today.ToString("yyMMdd");
            string sequence = GlobalConfig.Connection.Sequence_Get().ToString();
            sequence = sequence.PadLeft(5, '0');
            pid += mso.Abbreviation + "_" + dateStamp + "_" + sequence;

            return pid;
        }
    }
}
