using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Utilities
{
    public static class FEListConverterToXML
    {
        public static void ConvertFEListToXML()
        {
            List<AssignmentModel> assignments = GlobalConfig.Connection.Assignments_GetAll();
            {
                int assignmentID = 0;
                foreach (var assignment in assignments)
                {
                    List<FE_Model> feList = new List<FE_Model>();
                    assignmentID = assignment.ID;
                    int[] feIDs = new int[] { assignment.FE1ID, assignment.FE2ID, assignment.FE3ID };

                    for (int i = 0; i < feIDs.Length; i++)
                    {
                        if (feIDs[i] > 0)
                        {
                            FE_Model fe = GlobalConfig.Connection.FE_GetByID(feIDs[i])[0];
                            if (fe != null)
                            {
                                feList.Add(fe);
                            }
                        }
                    }

                    if (feList.Count > 0)
                    {
                        string xmlData = Serialization.SerializeToXml<List<FE_Model>>(feList);
                        GlobalConfig.Connection.Assignments_FEListXMLUpdateByID(assignmentID, xmlData);
                    }

                    feList = null;
                }

            }
        }
    }
}
