using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public class WhereClauseGenerator
    {
        public static string MakeWhereClause(List<SearchTermModel> terms)
        {
            string sql = "";
            foreach (SearchTermModel searchTerm  in terms)
            {
                sql += searchTerm.SearchTerm + " = '" + searchTerm.SearchValue + "' and ";
            }
            sql = sql.Substring(0, sql.Length - 5);
            return sql;
        }
    }
}
