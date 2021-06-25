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
        /// Full MSO name
        /// </summary>
        public string MSO { get; set; }

        /// <summary>
        /// 3 letter abbreviation
        /// </summary>
        public string Abbreviation { get; set; }       

        public int ID { get; set; }
        /// <summary>
        /// Unique identifier
        /// </summary>

        public bool Active { get; set; }

        public MSO_Model()
        {
            this.Active = true;

        }
        public MSO_Model(int ID, string MSO, String Abbreviation, bool Active = true)
        {
            this.ID = ID;
            this.Abbreviation = Abbreviation;
            this.MSO = MSO;
            this.Active = Active;
        }


    }
}
