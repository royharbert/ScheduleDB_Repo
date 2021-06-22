using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class TableToDisplayConverter
    {
        public static List<AssignmentDisplayModel> ConvertTableToDisplayModel(List<AssignmentTableModel> tableList)
        {
            List<AssignmentDisplayModel> displayList = new List<AssignmentDisplayModel>();
            foreach (var T in tableList)
            {
                AssignmentDisplayModel D = new AssignmentDisplayModel();
                D.Activity = T.Activity;
                D.Comments = T.Comments;
                D.CRMNumber = T.CRMNumber;
                D.CustEMail = T.CustEMail;
                D.CustomerFirstName = T.CustFirstName;
                D.CustomerLastName = T.CustLastName;
                D.CustPhone = T.CustPhone;
                D.CustReqDate = T.CustReqDate;
                D.DateCompleted = T.DateCompleted;
                D.DocCovid = T.DocCovid;
                D.DocCrm = T.DocCrm;
                D.DocRoster = T.DocRoster;
                D.DocTripRpt = T.DocTripRpt;
                D.DocWRE = T.DocWRE;
                D.EndDate = T.EndDate;
                D.FE_List = makeListFromXML(T.FE_ListXML, ListType.FE);
                D.HrsOnSite = T.HrsOnSite;
                D.LocAddress = T.LocAddress;
                D.LocCity = T.LocCity;
                D.LocCountry = T.LocCountry;
                D.LocPostalCode = T.LocPostalCode;
                D.LocRegion = T.LocRegion;
                D.LocState = T.LocState;
                D.MSO = T.MSO;
                D.NumTechs = T.NumTechs;
                D.ProductList = makeListFromXML(T.ProductListXML, ListType.Product);
                D.RequestID = T.RequestID;
                D.SalesPerson = T.SalesPerson;
                D.SiteName = T.SiteName;
                D.StartDate = T.StartDate;
                D.CustomerID = T.ContactID;
                D.LocationID = T.LocationID;

                displayList.Add(D);
            }
            
            return displayList;
        }

        private static string makeListFromXML(string ListXML, ListType listType)
        {
            List<int> IDs = new List<int>();
            Hashtable table = new Hashtable();
            IDs = Serialization.DeserializeToList<List<int>>(ListXML);
            string listData = "";

            switch (listType)
            {                
                case ListType.FE:
                    List<FE_Model> feList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
                    foreach (var fe in feList)
                    {
                        table.Add(fe.ID, fe);
                    }

                    if (IDs != null)
                    {
                        foreach (var item in IDs)
                        {
                            FE_Model data = (FE_Model)table[item];
                            listData += data.FullName + " / ";
                        } 
                    }
                    break;

                case ListType.Product:
                    List<ProductModel> productList = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
                    foreach (var product in productList)
                    {
                        table.Add(product.ID, product);
                    }


                    if (IDs != null)
                    {
                        foreach (var item in IDs)
                        {
                            ProductModel data = (ProductModel)table[item];
                            listData += data.Product + " / ";
                        } 
                    }
                    break;

                default:
                    break;
            }
            string returnData = "";
            if (listData.Length>3)
            {
                returnData = listData.Substring(0, listData.Length - 3); 
            }
            return returnData;



        }
    }
}
