using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class RetrieveToDisplayModel
    {
        private static List<ActivityModel> Activity_List = new List<ActivityModel>();
        private static List<ProductModel> Product_List = new List<ProductModel>();
        private static List<FE_Model> FE_List = new List<FE_Model>();
        private static List<RequestorModel> Sales_List = new List<RequestorModel>();
        private static List<CustomerModel> Contact_List = new List<CustomerModel>();
        private static List<LocationModel> Location_List = new List<LocationModel>();
        private static List<MSO_Model> MSO_List = new List<MSO_Model>();

        public static List<AssignmentDisplayModel> ConvertRetrieveToDisplay(List<AssignmentTableModel> R)
        {
            //make AssignmentDisplayModel
            List<AssignmentDisplayModel> displayAssignments = new List<AssignmentDisplayModel>();
            FE_List = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
            Hashtable feTable = DB_TableToHashTable.dbTableToHashTable(FE_List);
            FE_List = null;
            Product_List = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
            Hashtable productTable = DB_TableToHashTable.dbTableToHashTable(Product_List);
            Product_List = null;

            foreach (var assignment in R)
            {
                AssignmentDisplayModel D = new AssignmentDisplayModel();
                D.Activity = assignment.Activity;
                D.Comments = assignment.Comments;
                D.CustEMail = assignment.CustEMail;
                D.CustPhone = assignment.CustPhone; ;
                D.CRMNumber = assignment.CRMNumber;
                D.CustReqDate = assignment.CustReqDate;
                D.DateCompleted = assignment.DateCompleted;
                D.DocCovid = assignment.DocCovid;
                D.DocCrm = assignment.DocCrm;
                D.DocRoster = assignment.DocRoster;
                D.DocTripRpt = assignment.DocTripRpt;
                D.DocWRE = assignment.DocWRE;
                D.EndDate = assignment.EndDate;
                D.HrsOnSite = assignment.HrsOnSite;
                D.LocAddress = assignment.LocAddress;
                D.LocCity = assignment.LocCity;
                D.LocCountry = assignment.LocCountry;
                D.LocPostalCode = assignment.LocPostalCode;
                D.LocRegion = assignment.LocRegion;
                D.LocState = assignment.LocState;
                D.SiteName = assignment.SiteName;
                D.MSO =assignment.MSO;
                D.NumTechs = assignment.NumTechs;
                D.ProductList = makeProductList(productTable, assignment.ProductListXML);                
                //D.Requestor = assignment.SalesPerson;
                D.StartDate = assignment.StartDate;
                D.FE_List = makeFEList(feTable, assignment.FE_ListXML);
                D.RequestID = assignment.RequestID;

                displayAssignments.Add(D);
            }



            return displayAssignments;
        }

        private static string makeProductList(Hashtable table, string productListXML)
        {
            string productNames = "";
            if (productListXML != null)
            {
                ProductModel pModel = new ProductModel();
                List<int> products = Serialization.DeserializeToList<List<int>>(productListXML);
                foreach (var item in products)
                {
                    pModel = (ProductModel)table[item];
                    productNames += pModel.Product + " ";
                }

            }
            return productNames;
        }

        private static string makeFEList(Hashtable table, string fE_ListXML)
        {
            string names = "";
            if (fE_ListXML != null)
            {
                List<int> FE_IDs = Serialization.DeserializeToList<List<int>>(fE_ListXML);
                foreach (var fe in FE_IDs)
                {
                    FE_Model model = (FE_Model)table[fe];
                    names += model.FullName;
                } 
            }

           
            return names;
        }
    }
}
