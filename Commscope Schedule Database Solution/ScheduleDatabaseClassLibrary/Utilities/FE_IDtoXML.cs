using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Utilities
{
    public static class FE_IDtoXML
    {
        public static void SerializeFEID()
        {
            List<AssignmentModel> assignments = GlobalConfig.Connection.Assignments_GetAll();
            foreach (AssignmentModel assignment in assignments)
            {
                List<int> IDs = new List<int>();
                if (assignment.FE1ID != 0)
                {
                    IDs.Add(assignment.FE1ID);
                }

                if (assignment.FE2ID != 0)
                {
                    IDs.Add(assignment.FE2ID);
                }

                if (assignment.FE3ID != 0)
                {
                    IDs.Add(assignment.FE3ID);
                }

                string feXML = GeneralOps.Serialization.SerializeToXml<List<int>>(IDs);
                GlobalConfig.Connection.Assignments_FEListXMLUpdateByID(assignment.ID, feXML);
            }
        }

        public static void SerializeProductListToXML()
        {
            List<AssignmentModel> assignments = GlobalConfig.Connection.Assignments_GetAll();
            foreach (var assignment in assignments)
            {
                List<int> productIDs = new List<int>();
                if (assignment.ProductList != null & assignment.ProductList != "")
                {
                    string[] products = assignment.ProductList.Split('^');
                    if (products[0] != "")
                    {


                        List<string> productString = products.ToList();
                        foreach (var item in productString)
                        {
                            List<ProductModel> product = GlobalConfig.Connection.Products_GetByColumn("Product", item);
                            productIDs.Add(product[0].ID);
                        }
                        string productXML = GeneralOps.Serialization.SerializeToXml(productIDs);
                        GlobalConfig.Connection.Assignment_ProductsTOXML(assignment.ID, productXML);
                    }
                }
            }
        }
    }        
}
