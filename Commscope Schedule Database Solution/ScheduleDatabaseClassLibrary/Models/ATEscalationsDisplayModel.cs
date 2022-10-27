using ScheduleDatabaseClassLibrary.Attributes;
using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class ATEscalationsDisplayModel
    {
        //public int ID { get; set; }
        //[ExcelExportProperty]
        public string EscalationID { get; set; }
        [ExcelExportProperty]
        public string FELead { get; set; }
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
        public DateTime DateReported { get; set; }
        [ExcelExportProperty]
        public DateTime ResolvedDate { get; set; }
        [ExcelExportProperty]
        public string Resolution { get; set; }
        [ExcelExportProperty]
        public string Comments { get; set; }
        [ExcelExportProperty]
        public string CTRNumber { get; set; }
        [ExcelExportProperty]
        public string PeopleSoftNumber { get; set; }
        [ExcelExportProperty]
        public string ATEStatus { get; set; }
        [ExcelExportProperty]
        //added this because missing 10-27-22 LMD
        public string EndUser { get; set; }
       

        //added this for new MSO field 10-27-22 LMD

        public ATEscalationsDisplayModel(){}
        public ATEscalationsDisplayModel(ATEscalationsModel model)
        {
            this.ATEDescription = model.ATEDescription;
            this.ATEStatus = model.ATEStatus;
            this.ATEType = model.ATEType;
            this.Comments = model.Comments;
            this.CTRNumber = model.CTRNumber;
            this.DateReported = model.DateReported;
            this.EscalationID = model.EscalationID;
            this.FELead = deserializeLead(model.FELeadXML);
            this.MSO = model.MSO;
            this.Product = model.Product;
            this.PeopleSoftNumber = model.PeopleSoftNumber;
            this.Quantity = model.Quantity;
            this.Resolution = model.Resolution;
            this.ResolvedDate = model.ResolvedDate;
            this.EndUser = model.EndUser;
        }

        private string deserializeProducts(string partNumberXML)
        {
            List<string> products = Serialization.DeserializeToList<List<string>>(partNumberXML);
            string result = "";
            if (products != null)
            {
                foreach (var product in products)
                {
                    result += product + ", ";
                }
                if (result.Length > 2)
                {
                    result = result.Substring(0, result.Length - 2);
                } 
            }
            return result;
        }

        private string deserializeLead(string leadsXML)
        {
            List<string> leads = Serialization.DeserializeToList<List<string>>(leadsXML);
            string result = "";

            if (leads != null)
            {
                foreach (var lead in leads)
                {
                    result += lead + ", ";
                }

                if (result.Length > 2)
                {
                    result = result.Substring(0, result.Length - 2);
                } 
            }
            return result;
        }
    }
}
