using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleDatabaseClassLibrary.Attributes;
using ScheduleDatabaseClassLibrary.GeneralOps;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AssignmentDisplayModel
    {
        private string _CustomerFullName;
        private string _ProductListXML;
        private string _FE_ListXML;

        [ExcelExportProperty]
        public string RequestID { get; set; }
        [ExcelExportProperty]
        public string MSO { get; set; }
        [ExcelExportProperty]
        public string Activity { get; set; }
        [ExcelExportProperty]
        public DateTime StartDate { get; set; }
        [ExcelExportProperty]
        public DateTime EndDate { get; set; }        
        public DateTime CustReqDate { get; set; }
        [ExcelExportProperty]
        public string SalesPerson { get; set; }
        [ExcelExportProperty]
        public string ProductList { get; internal set; }        
        [ExcelExportProperty]
        public List<String> FE_List { get; internal set; }
        [ExcelExportProperty]
        public int NumTechs { get; set; }
        [ExcelExportProperty]
        public DateTime DateCompleted { get; set; }
        [ExcelExportProperty]
        public int HrsOnSite { get; set; }
        [ExcelExportProperty]
        public string Comments { get; set; }
        [ExcelExportProperty]
        public string CRMNumber { get; set; }        
        public int FE1ID { get; set; }
        public int FE2ID { get; set; }
        public int FE3ID { get; set; }
        public int ContactID { get; set; }
        public bool DocCovid { get; set; }
        public bool DocCrm { get; set; }
        public bool DocTripRpt { get; set; }
        public bool DocWRE { get; set; }
        public bool DocRoster { get; set; }
        public int MSO_ID { get; set; }
        public int LocationID { get; set; }
        public string ProductListXML
        {
            get
            {
                return _ProductListXML;
            }
            
            set
            {
                _ProductListXML = value;
                List<string> productList = ProductIDToProduct.ProductIdToProduct(ProductListXML);
                foreach (var item in productList)
                {
                   this.ProductList = productList[0] + "\n";
                }
            }
        }
        public string FE_ListXML 
        { 
            get
            {
                return _FE_ListXML;
            }
            set 
            {
                _FE_ListXML = value;
                this.FE_List = FE_XMLtoFE_List.FE_XMLtoList(this.FE_ListXML);
            }
        }
        public int Requestor { get; set; }
        [ExcelExportProperty]
        public int ID { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        [ExcelExportProperty]
        public string CustomerFullName
        {
            get
            {
                _CustomerFullName = CustFirstName + " " + CustLastName;
                return _CustomerFullName;
            }
        }
        public string ContactMSO { get; set; }
        [ExcelExportProperty]
        public string CustEMail { get; set; }
        [ExcelExportProperty]
        public string CustPhone { get; set; }        
        public int ID_CustomerTable { get; set; }
        [ExcelExportProperty]
        public string SiteName { get; set; }        
        public string LocMSO { get; set; }
        [ExcelExportProperty]
        public string LocAddress { get; set; }
        [ExcelExportProperty]
        public string LocCity { get; set; }
        [ExcelExportProperty]
        public string LocState { get; set; }
        [ExcelExportProperty]
        public string LocCountry { get; set; }
        [ExcelExportProperty]
        public string LocPostalCode { get; set; }
        [ExcelExportProperty]
        public string LocRegion { get; set; }
        public int Activity_ID { get; set; }
    }
}
