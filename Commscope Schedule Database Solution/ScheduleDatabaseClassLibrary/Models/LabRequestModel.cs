using ScheduleDatabaseClassLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class LabRequestModel
    {
        //[ExcelExportProperty]
        public int ID { get; set; }
        [ExcelExportProperty]
        public string LRID { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public string Product { get; set; }
        [ExcelExportProperty]
        public DateTime StartDate { get; set; }
        [ExcelExportProperty]
        public DateTime EndDate { get; set; }
        [ExcelExportProperty]
        public string Description { get; set; }
        [ExcelExportProperty]
        public string Remarks { get; set; }
    }
}
