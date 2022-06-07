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
        private DateTime _startDate;
        private DateTime _endDate;
        //[ExcelExportProperty]
        public int ID { get; set; }
        [ExcelExportProperty]
        public string LRID { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public string Product { get; set; }
        [ExcelExportProperty]
        public DateTime StartDate 
        {
            get { return _startDate; }
            set 
            {
                _startDate = value;
                _startDate = _startDate.Date;
            }
        }
        [ExcelExportProperty]
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                _endDate = _endDate.Date;

            }
        }
        [ExcelExportProperty]
        public string Description { get; set; }
        [ExcelExportProperty]
        public string Remarks { get; set; }
    }
}
