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

        public static List<AssignmentDisplayModel> ConvertRetrieveToDisplay(List<AssignmentRetrieveModel> R)
        {
            //make AssignmentDisplayModel
            List<AssignmentDisplayModel> displayAssignments = new List<AssignmentDisplayModel>();
            FE_List = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
            Hashtable feTable = DB_TableToHashTable.dbTableToHashTable(FE_List);
            FE_List = null;
            Sales_List = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons");
            Hashtable salesTable = DB_TableToHashTable.dbTableToHashTable(Sales_List);
            Sales_List = null;
            Product_List = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
            Hashtable productTable = DB_TableToHashTable.dbTableToHashTable(Product_List);
            Product_List = null;
            Activity_List = GlobalConfig.Connection.GenericGetAll<ActivityModel>("tblActivity");
            Hashtable activityTable = DB_TableToHashTable.dbTableToHashTable(Activity_List);
            Activity_List = null;
            Contact_List = GlobalConfig.Connection.GenericGetAll<CustomerModel>("tblCustContact");
            Hashtable customerTable = DB_TableToHashTable.dbTableToHashTable(Contact_List);
            Contact_List = null;
            Location_List = GlobalConfig.Connection.GenericGetAll<LocationModel>("tblCustomerLocations");
            Hashtable locationTable = DB_TableToHashTable.dbTableToHashTable(Location_List);
            Location_List = null;
            MSO_List = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO");
            Hashtable msoTable = DB_TableToHashTable.dbTableToHashTable(MSO_List);
            MSO_List = null;

            foreach (var assignment in R)
            {
                AssignmentDisplayModel D = new AssignmentDisplayModel();
                D.Activity = assignmentLookup(assignment.Activity_ID);
                D.Comments = assignment.Comments;
                string[] custInfo = makeMSO_Contact(assignment.ContactID);
                D.CustEMail = custInfo[1];
                D.CustomerFullName = custInfo[0];
                D.CustPhone = custInfo[2];
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
                string[] locationInfo = makeLocationInfo(assignment.LocationID);
                D.LocAddress = locationInfo[1];
                D.LocCity = locationInfo[2];
                D.LocCountry = locationInfo[5];
                D.LocPostalCode = locationInfo[4];
                D.LocRegion = locationInfo[6];
                D.LocState = locationInfo[3];
                D.SiteName = locationInfo[0];
                D.MSO = MSO_List[assignment.MSO_ID].MSO;
                D.NumTechs = assignment.NumTechs;
                D.ProductList = makeProductList(assignment.ProductListXML);
                D.RequestID = assignment.RequestID;
                D.Requestor = Sales_List[assignment.Requestor].SalesPerson;
                D.StartDate = assignment.StartDate;
                D.FE_List = makeFEList(assignment.FE_ListXML);

                displayAssignments.Add(D);
            }



            return displayAssignments;
        }

        private static string makeFEList(string fE_ListXML)
        {
            string names = "";
            List<int> FE_IDs = Serialization.DeserializeToList<List<int>>(fE_ListXML);
            foreach (var fe in FE_IDs)
            {
                names = FE_List[fe].FullName;
            }

            return names;
        }

        private static string makeProductList(string productListXML)
        {
            string names = "";
            List<int> productIDs = Serialization.DeserializeToList<List<int>>(productListXML);
            foreach (var product in productIDs)
            {
                names = Product_List[product].Product;
            }

            return names;
        }

        private static string[] makeLocationInfo(int locationID)
        {
            string[] locationInfo = new string[7];
            locationInfo[0] = Location_List[locationID].SiteName;
            locationInfo[1] = Location_List[locationID].Address;
            locationInfo[2] = Location_List[locationID].City;
            locationInfo[3] = Location_List[locationID].State;
            locationInfo[4] = Location_List[locationID].PostalCode;
            locationInfo[5] = Location_List[locationID].Country;
            locationInfo[6] = Location_List[locationID].Region;

            return locationInfo;
        }

        private static string[] makeMSO_Contact(int contactID)
        {
            string[] customerInfo = new string[3];
            customerInfo[0] = Contact_List[contactID].FullName;
            customerInfo[1] = Contact_List[contactID].EMail;
            customerInfo[2] = Contact_List[contactID].Phone;

            return customerInfo;
        }

        private static string assignmentLookup(int activity)
        {

            if(Activity_List[activity].Purpose!= null )
            {   
                return Activity_List[activity].Purpose;
            }
            else
            {
                return "";
            }
        }
    }
}
