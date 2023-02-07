using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary
{
    public class Holiday_Update
    {
        public static void UpdateHolidays(DataTable dt)
        {
            string db;
            if(GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                db = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
            }
            else
            {
                db = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
            }

            using (SqlConnection con = new SqlConnection(db))
            {
                SqlCommand cmd = new SqlCommand("spHolidays_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@HolidayTable";
                param.Value = dt;
                cmd.Parameters.Add(param);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
