using ScheduleDatabaseClassLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class ATEscalationsModel
    {
        //public int ID { get; set; }
        [ExcelExportProperty]
        public string EscalationID { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public string ATEType { get; set; }
        [ExcelExportProperty]
        public string Product { get; set; }
        [ExcelExportProperty]
        public string ATEDescription { get; set; }
        [ExcelExportProperty]
        public string Quantity { get; set; }
        [ExcelExportProperty]
        public DateTime ResolvedDate { get; set; }
        [ExcelExportProperty]
        public string Resolution { get; set; }
        [ExcelExportProperty]
        public string FELeadXML { get; set; }
        [ExcelExportProperty]
        public string Comments { get; set; }
        [ExcelExportProperty]
        public string CTRNumber { get; set; }
        [ExcelExportProperty]
        public string PeopleSoftNumber { get; set; }
        [ExcelExportProperty]
        public DateTime DateReported { get; set; }
        [ExcelExportProperty]
        public string ATEStatus { get; set; }
        [ExcelExportProperty]
        public string EndUser { get; set; }
        [ExcelExportProperty]

        public string TimeSpent { get; set; }
        [ExcelExportProperty]
        public string SerialNumbers { get; set; }
        [ExcelExportProperty]
        public string TrackingIn { get; set; }
        [ExcelExportProperty]
        public string TrackingOut { get; set; }
        public ATEscalationsDisplayModel DisplayModel()
        {
            ATEscalationsDisplayModel displayModel = new ATEscalationsDisplayModel(this);
            return displayModel;
        }
    }
}
