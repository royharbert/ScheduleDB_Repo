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
            List<int> feIDs = GlobalConfig.Connection.AssignedFEs_Get(RID);
            return feIDs;
        }

        public static void MakeAssignments(DateTime StartDate, DateTime EndDate, string RID, string FE_IDs)
        {
            List<int> FEs = Serialization.DeserializeToList<List<int>>(FE_IDs);
            foreach (int id in FEs)
            {
                GlobalConfig.Connection.MakeAssignment( RID, id, StartDate, EndDate);
            }
        }

        public static void UnMakeAssignments(DateTime StartDate, DateTime EndDate, string RID, string FE_IDs)
        {
            List<int> FEs = Serialization.DeserializeToList<List<int>>(FE_IDs);
            foreach (int id in FEs)
            {
                GlobalConfig.Connection.UnMakeAssignment(RID, id, StartDate, EndDate);
            }
        }
        /// <summary>
        /// Returns a list of FE_Model of unassigned FE's in date range
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public static List<FE_Model> GetAvailability(DateTime StartDate, DateTime EndDate )
        {
            List<string> RIDs = getRIDs(StartDate, EndDate);
            List<FE_Model> available = RemoveAssignedFEs(RIDs);
            return available;
        }

        /// <summary>
        /// gets request ID's from tblSched between dates
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        private static List<string> getRIDs(DateTime StartDate, DateTime EndDate)
        {
            List<string> RIDs = new List<string>();
            List<FE_CalendarModel> CalList = GlobalConfig.Connection.GetFEAssignments(StartDate, EndDate);

            foreach (var request in CalList)
            {
                PropertyInfo[] properties = request.GetType().GetProperties();
                for (int i = 1; i < properties.Length; i++)
                {
                    if (properties[i].GetValue(request) != null)
                    {
                        string propVal = properties[i].GetValue(request).ToString();

                        if (!RIDs.Contains(propVal) & propVal != null)
                        {
                            RIDs.Add(propVal);
                        }
                    }

                }

            }
            return RIDs;
        }

        /// <summary>
        /// Removes assigned FE's from FE list, leaving only available ones
        /// </summary>
        /// <param name="RID_List"></param>
        /// <returns></returns>
        private static List<FE_Model> RemoveAssignedFEs(List<string> RID_List)
        {
            List<FE_Model> availableFE = GlobalConfig.Connection.FE_GetAllActive();
            foreach (string RID in RID_List)
            {
                string feXML = GlobalConfig.Connection.FEListXML_GetByRID(RID);
                List<int> FEs = Serialization.DeserializeToList<List<int>>(feXML);
                if (FEs != null)
                {
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
