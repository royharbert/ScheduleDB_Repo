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
    //public class Holiday_Update
    //{
    //    public static void UpdateHolidays(DataTable dt)
    //    {
    //        string db;
    //        if(GlobalConfig.DatabaseMode == DatabaseType.Live)
    //        {
    //            db = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
    //        }
    //        else
    //        {
    //            db = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
    //        }

    //        using (SqlConnection con = new SqlConnection(db))
    //        {
    //            SqlCommand cmd = new SqlCommand("spHolidays_Update", con);
    //            cmd.CommandType = CommandType.StoredProcedure;

    //            SqlParameter param = new SqlParameter();
    //            param.ParameterName = "@HolidayTable";
    //            param.Value = dt;
    //            cmd.Parameters.Add(param);

    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //            con.Close();
    //        }
    //    }
    //}

    //public class Holiday_Update
    //{
    //    //public static void UpdateHolidays(string holiday, DateTime holidayDate)
    //    //{
    //        //string db;
    //        //if (GlobalConfig.DatabaseMode == DatabaseType.Live)
    //        //{
    //        //    db = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
    //        //}
    //        //else
    //        //{
    //        //    db = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
    //        //}

    //        //using (SqlConnection con = new SqlConnection(db))
    //        //{
    //        //    SqlCommand cmd = new SqlCommand("spHolidays_Update", con);
    //        //    cmd.CommandType = CommandType.StoredProcedure;

    //        //    SqlParameter param = new SqlParameter();
    //        //    param.ParameterName = "@Holiday";
    //        //    param.Value = holiday;
    //        //    cmd.Parameters.Add(param);
    //        //    SqlParameter paramDate= new SqlParameter();
    //        //    paramDate.ParameterName = "@HolidayDate";
    //        //    param.Value = holidayDate;
    //        //    cmd.Parameters.Add(paramDate);

    //        //    con.Open();
    //        //    cmd.ExecuteNonQuery();
    //    //    //    con.Close();
    //    //    }
    //    //}
    //}
}
