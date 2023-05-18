using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{ 
    public  class SearchOps
    {
        public static void SetMenuAccess(Form frm, UserModel user)
        {
            foreach (Control ctl  in frm.Controls)
            {
                if (ctl is Button)
                {
                    ctl.Visible = false;
                    int minimumPriviledge = int.Parse(ctl.Tag.ToString());
                    if (user.Priviledge >= minimumPriviledge)
                    {
                        ctl.Visible = true;
                    } 
                }

            }
        }
        /// <summary>
        /// takes a list of search terms (field name/value) and builds a where clause to append to dynamic query.
        /// case sensitive
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="searchTerms"></param>
        /// <param name="TableName"></param>
        /// <param name="isAnd"></param>
        /// <returns></returns>
        public static List<T> FieldSearch<T>(List<FieldSearchModel> searchTerms, string TableName, bool isAnd)
        {
            StringBuilder whereClause = new StringBuilder();
            string op = "OR";
            if (isAnd)
            {
                op = "AND";
            }           
            
            foreach (FieldSearchModel item in searchTerms)
            {
                string delim = "'";

                if (item.FieldName == "TotalHours" || item.FieldName == "BOM_Value" || item.FieldName == "PercentageProjectCovered")
                {
                    delim = "";
                }
                whereClause.Append(item.FieldName + " LIKE " + delim +"%" + item.FieldValue + "%" + delim + " " + op + " ");
            }
            string where = whereClause.ToString();
            int opLength = op.Length + 1;
            where = where.Substring(0, where.Length - opLength);
            List<T> requests = GlobalConfig.Connection.SearchMultipleFields<T>(TableName, where);
            return requests;        
        }
        /// <summary>
        /// takes a list of search terms (field name/value) and builds a where clause to append to dynamic query.
        /// case insensitive
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="searchTerms"></param>
        /// <param name="TableName"></param>
        /// <param name="isAnd"></param>
        /// <returns></returns>
        public static List<T> FieldSearchCI<T>(List<FieldSearchModel> searchTerms, string TableName, bool isAnd)
        {
            StringBuilder whereClause = new StringBuilder();
            string op = "OR";
            if (isAnd)
            {
                op = "AND";
            }

            foreach (FieldSearchModel item in searchTerms)
            {
                string delim = "'";

                //if (item.FieldName == "TotalHours" || item.FieldName == "BOM_Value" || item.FieldName == "PercentageProjectCovered")
                Type t = item.FieldValue.GetType();
                if (t.Name == "int")
                {
                    delim = "";
                }

                if (delim == "'")
                {
                    whereClause.Append("Upper(" + item.FieldName +") LIKE upper(" + delim + "%" + item.FieldValue + 
                        "%" + delim + ") " + op + " ");
                }
                else
                {
                    whereClause.Append(item.FieldName + " LIKE " + delim + "%" + item.FieldValue +
                        "%" + delim + " " + op + " ");
                }
            }
            string where = whereClause.ToString();
            int opLength = op.Length + 1;
            where = where.Substring(0, where.Length - opLength);
            List<T> requests = GlobalConfig.Connection.SearchMultipleFields<T>(TableName, where);
            return requests;
        }
    }
}
