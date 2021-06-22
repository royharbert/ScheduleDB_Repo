using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    /// <summary>
    /// Represents MSO 
    /// </summary>
    public class MSO_Model : IHaveID
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Full MSO name
        /// </summary>
        public string MSO { get; set; }

        /// <summary>
        /// 3 letter abbreviation
        /// </summary>
        public string Abbreviation { get; set; }

    } 
}
