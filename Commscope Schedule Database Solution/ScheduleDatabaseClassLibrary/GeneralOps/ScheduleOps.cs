using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public class ScheduleOps
    {
        /// <summary>
        /// Returns a list if int of any FE's currently assigned to project
        /// Can then be used to highlight FE's in list box
        /// </summary>
        /// <param name="RID"></param>
        /// <returns></returns>
        public static List<int> CheckForExistingAssignments(string RID)
        {
            //List<int> feIDs = GlobalConfig.Connection.AssignedFEs_Get(RID);
            List<AssignmentTableModel> assignments = GlobalConfig.Connection.GetItemByColumn<AssignmentTableModel>
                ("tblAssignments", "RequestID", RID);
            string feXML = assignments[0].FE_ListXML;
            List<int> feIDs = Serialization.DeserializeToList<List<int>>(feXML);
            return feIDs;
        }

        /// <summary>
        /// Removes assigned FE's from FE list, leaving only available ones
        /// </summary>
        /// <param name="RID_List"></param>
        /// <returns></returns>
        private static List<FE_Model> RemoveAssignedFEs(List<string> RID_List)
        {
            //List<FE_Model> availableFE = GlobalConfig.Connection.FE_GetAllActive();
            List<FE_Model> availableFE = GlobalConfig.Connection.GetItemByColumn<FE_Model>("tblFE",
                "Active","",1);
            foreach (string RID in RID_List)
            {
                //Get assignment info
                List<AssignmentTableModel> feXML_List = GlobalConfig.Connection.GetItemByColumn<AssignmentTableModel>
                    ("tblAssignments", "RequestID", RID, -1);
                if (feXML_List.Count > 0)
                {
                    string feXML = feXML_List[0].FE_ListXML;                
                    List<int> FEs = Serialization.DeserializeToList<List<int>>(feXML);
                
                    foreach (int FE in FEs)
                    {
                        try
                        {
                            FE_Model toReomve = availableFE.Where(x => x.ID == FE).Single();
                            availableFE.Remove(toReomve);
                        }
                        catch (Exception)
                        {

                           
                        }
                    }
                }
            }
            return availableFE;
        }
    }
}
