using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class ProductIDToProduct
    {
        public static List<string> ProductIdToProduct(string xmlList)
        {
            List<int> productList = Serialization.DeserializeToList<List<int>>(xmlList);

            //make list of product models from ID's
            List<string> productNameList = new List<string>();
            if (productList.Count > 0)
            {
                for (int j = 0; j < productList.Count; j++)
                {
                    List<ProductModel> products = GlobalConfig.Connection.GetItemByColumn<ProductModel>
                        ("tblProducts", "ID","",  productList[j]);
                    if (products.Count > 0)
                    {
                        productNameList.Add(products[0].Product);
                    }
                }
            }
            return productNameList;
        }
    }
}
