using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class FE_XMLtoFE_List
    {
        public static List<string> FE_XMLtoList(string xmlList)
        {
            List<int> feList = Serialization.DeserializeToList<List<int>>(xmlList);

            //make list of product models from ID's
            List<string> FE_NameList = new List<string>();
            if (feList.Count > 0)
            {
                for (int j = 0; j < feList.Count; j++)
                {
                    List<FE_Model> FE_Models = GlobalConfig.Connection.GetItemByColumn<FE_Model>("tblFE","ID",
                        "",feList[j]);
                    if (FE_Models.Count > 0)
                    {
                        FE_NameList.Add(FE_Models[0].FullName);
                    }
                }
            }

            return FE_NameList;
        }
    }
}
