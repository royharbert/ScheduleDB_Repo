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

        /// <summary>
        /// Gets sequence number for escalationID and increments table
        /// </summary>
        /// <param name="mso"></param>
        /// <returns></returns>
        public static string GenerateEID(MSO_Model mso, string prefix, bool dataloading)
        {
            if (dataloading)
            {
                string sequence = "";
                string eid = prefix;
                string dateStamp = DateTime.Today.ToString("yyMMdd");
                switch (prefix)
                {
                    case "ESC_":
                        sequence = GlobalConfig.Connection.EIDSequence_Get("tblEIDSequence").ToString();
                        break;
                    case "LAB_":
                        sequence = GlobalConfig.Connection.EIDSequence_Get("tblSeqLabRequest").ToString();
                        break;
                    default:
                        break;
                }

                sequence = sequence.PadLeft(5, '0');
                eid += mso.Abbreviation + "_" + dateStamp + "_" + sequence;
                return eid; 
            }
            else
            {
                return "";
            }
        }

    }
}
