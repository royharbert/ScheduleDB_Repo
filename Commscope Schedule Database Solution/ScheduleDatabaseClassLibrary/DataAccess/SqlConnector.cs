using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleDatabaseClassLibrary.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace ScheduleDatabaseClassLibrary.DataAccess
{

    public class SqlConnector : IDataConnection
    {
        public List<T> GetItemByColumn<T>(string tableName, string ColumnName, string StringValue,
            int IntValue)
        {
            string iVal = IntValue.ToString();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TableName", tableName, DbType.String, ParameterDirection.Input);
                p.Add("@ColumnName", ColumnName, DbType.String, ParameterDirection.Input);
                p.Add("@IntVal", iVal, DbType.String, ParameterDirection.Input);
                p.Add("@StringVal", StringValue, DbType.String, ParameterDirection.Input);
                List<T> output = connection.Query<T>("dbo.spAssignments_GetDateRange", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public List<AssignmentDisplayModel> DateRangeSearch_SortBy(DateTime StartDate, DateTime EndDate, string OrderBy)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@start", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@end", EndDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@order", OrderBy, DbType.String, ParameterDirection.Input);

                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spAssignments_GetDateRange", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public List<FE_Model> FE_GetAllActive()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<FE_Model> output = connection.Query<FE_Model>("dbo.spFE_GetAllActive",
                   commandType: CommandType.StoredProcedure).ToList();
                if (output.Count>0)
                {
                    return output;
                }
                else
                {
                    return null;
                }
            }
        }

        public string FEListXML_GetByRID(string RID)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Request", RID, DbType.String);
                
                List<string> outputList = connection.Query<string>("dbo.spFEListXML_GetByRID", p,
               commandType: CommandType.StoredProcedure).ToList();
                if (outputList.Count > 0)
                {
                    return outputList[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public List<FE_CalendarModel> GetFEAssignments(DateTime StartDate, DateTime EndDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@StartDate", StartDate, DbType.DateTime);
                p.Add("@EndDate", EndDate, DbType.DateTime);
                List<FE_CalendarModel> output = connection.Query<FE_CalendarModel>("dbo.spFE_Calendar_GetAssignments", p,
                   commandType: CommandType.StoredProcedure).ToList();               
                return output;
            }
        }
        public void UnMakeAssignment(string RID, int FE_ID, DateTime StartDate, DateTime EndDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@RequestID", RID, DbType.String);
                p.Add("@FE_ID", FE_ID, DbType.Int32);
                p.Add("@StartDate", StartDate, DbType.Date);
                p.Add("@EndDate", EndDate, DbType.Date);
                connection.Execute("dbo.spAssign_FE_Unassign", p,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void MakeAssignment(string RID, int FE_ID, DateTime StartDate, DateTime EndDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@RequestID", RID, DbType.String);
                p.Add("@FE_ID", FE_ID, DbType.Int32);
                p.Add("@StartDate", StartDate, DbType.Date);
                p.Add("@EndDate", EndDate, DbType.Date);
                connection.Execute("dbo.spAssign_FE", p,
                    commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// takes RequestID and returns list of FE ID's assigned to it
        /// </summary>
        /// <param name="RID"></param>
        /// <returns></returns>
        public List<int> AssignedFEs_Get(string RID)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<string> output = new List<string>();
                List<int> outputInt = new List<int>();
                var p = new DynamicParameters();
                p.Add("@RID", RID, DbType.String);
                output = connection.Query<string>("dbo.spAssignedFEs_Get", p,
                   commandType: CommandType.StoredProcedure).ToList();
                if (output.Count > 0)
                {
                    outputInt = GeneralOps.Serialization.DeserializeToList<List<int>>(output[0]);
                }
                return outputInt;
            }
        }

        public List<LocationModel> CustomerLocations_Get(string WhereClause, string action, int ID, string siteName, string mso, 
            string address, string city, string state, string country, string postalCode, string region, int custID)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Action", action, DbType.String);
                p.Add("@ID", ID, DbType.Int32);
                p.Add("@SiteName", siteName, DbType.String);
                p.Add("@MSO", mso, DbType.String);
                p.Add("@Address", address, DbType.String);
                p.Add("@City", city, DbType.String);
                p.Add("@State", state, DbType.String);
                p.Add("@Country", country, DbType.String);
                p.Add("@PostalCode", postalCode, DbType.String);
                p.Add("@Region", region, DbType.String);
                p.Add("@ContactID", custID, DbType.Int32);
                p.Add("@WhereClause", WhereClause, DbType.String);

                List<LocationModel> output = connection.Query<LocationModel>("dbo.spCustomerLocations_CRUD", p,
                   commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public void Activity_Update_ID(string activity, int ID)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Activity", activity);
                p.Add("@ID", ID);
                

                connection.Execute("dbo.spActivity_UpdateID", p,
                    commandType: CommandType.StoredProcedure);
            }
        }
        public List<ActivityModel> Activities_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {            
                List<ActivityModel> output = connection.Query<ActivityModel>("dbo.spActivity_GetAll", 
                    commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }
        public List<AssignmentDisplayModel> Assignments_GetByActivity(string activity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Activity", activity, DbType.String);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spAssignments_GetAllOfType", p,
                    commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }
        public void Assignment_CRUD(char action, string ID, DataTable dt)
        {
            string db;
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                db = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
            }
            else
            {
                db = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
            }

            using (SqlConnection con = new SqlConnection(db))
            {
                SqlCommand cmd = new SqlCommand("spAssignment_CRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Action";
                param.Value = action;
                cmd.Parameters.Add(param);
                param = null;

                param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = ID;
                cmd.Parameters.Add(param);
                param = null;

                param = new SqlParameter();
                param.ParameterName = "@typAssignment";
                param.Value = dt;
                cmd.Parameters.Add(param);
                param = null;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Customer_CRUD(CustomerModel customer,string action)
        {
            using(IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Action", action, DbType.String, ParameterDirection.Input);
                p.Add("@ID", customer.ID, DbType.Int32,ParameterDirection.Input);
                p.Add("@FirstName", customer.FirstName,DbType.String,ParameterDirection.Input);
                p.Add("@LastName", customer.LastName, DbType.String, ParameterDirection.Input);
                p.Add("@MSO", customer.MSO, DbType.String, ParameterDirection.Input);
                p.Add("@LocID", customer.LocID, DbType.Int32, ParameterDirection.Input);
                p.Add("@EMail", customer.EMail, DbType.String, ParameterDirection.Input);
                p.Add("@Phone", customer.Phone, DbType.String, ParameterDirection.Input);
                connection.Execute("dbo.spCustomerContact_CRUD", p,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<T> SearchMultipleFields<T>(string TableName, string whereClause)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@TableName", TableName, DbType.String);
                p.Add("@WhereClause", whereClause, DbType.String);
                List<T> output = connection.Query<T>("dbo.spSearchVariableFields", p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public static string db { get; set; }

        public List<ProductModel> Products_GetByColumn(string column, string val)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Column", column, DbType.String);
                p.Add("@Value", val, DbType.String);
                List<ProductModel> output = connection.Query<ProductModel>("dbo.spProducts_GetByColumn", p,
                    commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }
        public void Assignment_ProductsTOXML(int ID, string productXML)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ID", ID);
                p.Add("@Value", productXML);              

                connection.Execute("dbo.spAssignments_Product_ListUpdateXMLByID", p, 
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<AssignmentDisplayModel> Assignment_GetByID(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ID", ID, DbType.Int32);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spAssignments_GetByID", p,
                    commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public List<AssignmentDisplayModel> Assignment_GetByTripID(string TID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@TID", TID, DbType.String);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spAssignments_GetByTripID", p,
                    commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public void AddUser(UserModel NewUser)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", NewUser.FirstName);
                p.Add("LastName", NewUser.LastName);
                p.Add("@PW", NewUser.PW);
                p.Add("@Priviledge", NewUser.Priviledge);
                p.Add("ActiveDesigner", NewUser.ActiveDesigner);
                p.Add("ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                //TODO - Add try catch to handle duplicate users
                connection.Execute("dbo.spUser_Add", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteUser(int OldUser)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Ident", OldUser);
                connection.Execute("dbo.spUser_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<UserModel> GetUsers_All()
        {
            List<UserModel> output = null;
            ;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                output = connection.Query<UserModel>("dbo.spUsers_GetAll").ToList();
            }

            return output;

        }


        public void UpdateUser(UserModel ThisUser)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@FirstName", ThisUser.FirstName);
                p.Add("LastName", ThisUser.LastName);
                p.Add("@PWord", ThisUser.PW);
                p.Add("@Priv", ThisUser.Priviledge);
                p.Add("@Active", ThisUser.ActiveDesigner);
                p.Add("@Ident", ThisUser.ID);


                connection.Execute("dbo.spUser_Update", p, commandType: CommandType.StoredProcedure);
            }
        }


        public UserModel GetUser(string userName)
        {

            UserModel myUser = new UserModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@FullName", myUser.FullName, DbType.String, ParameterDirection.Input);
                List<UserModel> output = connection.Query<UserModel>("dbo.spUser_GetByName", p, commandType: CommandType.StoredProcedure).ToList();
                if (output.Count == 0)
                {
                    return null;
                }
                else
                {
                    return output[0];
                }

            }

        }

        public UserModel GetUser(int userID)
        {

            UserModel myUser = new UserModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@Ident", userID, DbType.Int32, ParameterDirection.Input);
                List<UserModel> output = connection.Query<UserModel>("dbo.spUser_Get", p, commandType: CommandType.StoredProcedure).ToList();
                if (output.Count == 0)
                {
                    return null;
                }
                else
                {
                    return output[0];
                }

            }

        }

        public List<CompanyHolidaysModel> GetAllHolidays()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<CompanyHolidaysModel> output = connection.Query<CompanyHolidaysModel>("dbo.spHolidays_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public void AddCountry(string ctry)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@cAdd", ctry, DbType.String);
                connection.Execute("dbo.spCountries_Add", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteCountry(int idx)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Idx", idx, DbType.Int32);
                connection.Execute("dbo.spCountry_Delete", p, commandType: CommandType.StoredProcedure);
            }

        }

        public void UpdateCountry(int idx, string country)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Idx", idx, DbType.Int32);
                p.Add("@country", country, DbType.String);
                connection.Execute("dbo.spCountry_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<CountriesModel> Countries_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<CountriesModel> output = connection.Query<CountriesModel>("dbo.spCountries_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<MSO_Model> MSO_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<MSO_Model> output = connection.Query<MSO_Model>("dbo.spMSO_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<CityModel> GetAllCities()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<CityModel> output = connection.Query<CityModel>("dbo.spCities_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<StateModel> GetAllStates()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<StateModel> output = connection.Query<StateModel>("dbo.spStates_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<RegionsModel> GetAllRegions()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<RegionsModel> output = connection.Query<RegionsModel>("dbo.spRegions_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public int Sequence_Get()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<SequenceModel> output = connection.Query<SequenceModel>("dbo.spSequence_Get", 
                    commandType: CommandType.StoredProcedure).ToList();
                GlobalConfig.Connection.Sequence_Set(output[0].Sequence + 1);
                return output[0].Sequence;               
            }
        }

        public void Sequence_Set(int seq)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Sequence", seq, DbType.Int32);
                connection.Execute("dbo.spSequence_Set", p, commandType: CommandType.StoredProcedure);
            }
        }



        public void InsertInto_tblAttachments(AttachmentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                //Unique ID for record
                p.Add("@ID", model.ID, DbType.String, ParameterDirection.Input);
                //Text to display in grid. Equals File Name no Path
                p.Add("@DisplayText", model.DisplayText, DbType.String);
                //Path to server
                p.Add("@ItemType", model.ItemType, DbType.String);
                //Project ID
                p.Add("@PID", model.PID, DbType.String);
                connection.Execute("spAttachment_Insert", p, commandType: CommandType.StoredProcedure);
            }
            //System.Windows.Forms.MessageBox.Show("Operation Complete");
        }

        public void DeleteAttachment(AttachmentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                //Project ID
                p.Add("@PID", model.PID, DbType.String);
                p.Add("@DisplayText", model.DisplayText, DbType.String);
                connection.Execute("spAttachment_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }
        public List<AttachmentModel> GetAttachments(string PID)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@PID", PID, DbType.String, ParameterDirection.Input);
                List<AttachmentModel> output = connection.Query<AttachmentModel>("spAttachments_GetByPID", p, commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }


        public List<AssignmentDisplayModel> DateRangeSearch_Unfiltered(DateTime StartDate, DateTime EndDate, string SearchTerm)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@StartDate", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@EndDate", EndDate, DbType.DateTime, ParameterDirection.Input);
                List<AssignmentDisplayModel> output = null;

                switch (SearchTerm)
                {
                    case "DateAssigned":
                        output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_Unfiltered_DateAssigned",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateDue":
                        output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_Unfiltered_DateDue",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateCompleted":
                        output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_Unfiltered_DateCompleted",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    default:
                        break;
                }
                return output;
            }
        }

        public List<AssignmentDisplayModel> DateRangeSearch_MSOFiltered(DateTime StartDate, DateTime EndDate, string SearchTerm, string mso)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@StartDate", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@EndDate", EndDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@MSO", mso, DbType.String, ParameterDirection.Input);
                List<AssignmentDisplayModel> output = null;

                switch (SearchTerm)
                {
                    case "DateAssigned":
                        output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_MSOFiltered_DateAssigned",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateDue":
                        output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_MSOFiltered_DateDue",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateCompleted":
                        output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_MSOFiltered_DateCompleted",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    default:
                        break;
                }
                return output;
            }
        }

        public List<AssignmentDisplayModel> GetSnapshotData(string MSO, DateTime start, DateTime end)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();


                p.Add("@MSO", MSO, DbType.String, ParameterDirection.Input);
                p.Add("@StartDate", start, DbType.DateTime, ParameterDirection.Input);
                p.Add("@EndDate", end, DbType.DateTime, ParameterDirection.Input);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("spDateRangeSearch_MSOFiltered_DateAssigned",
                    p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public void UpdateSnapshotMSO_s(string mso)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                //Project ID
                p.Add("@MSO", mso, DbType.String);
                connection.Execute("spInsertIntoSnapshotMSO_S", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<string> GetSnapshotMSO_s()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<string> output = connection.Query<string>("spGetAllSnapshotMSO_S",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public void ClearTable(string tableName)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                //Project ID
                p.Add("@TableName", tableName, DbType.String);
                connection.Execute("spDeleteAllRecordsFromTable", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<AssignmentDisplayModel> GetDeletedRecordByPID(string PID)
        {
            AssignmentDisplayModel request = new AssignmentDisplayModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@PID", PID, DbType.String, ParameterDirection.Input);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spDeletedRequest_GetByPID", p, commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public List<AssignmentDisplayModel> GetOpenRequests()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spRequestsGetOpen", commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public List<AssignmentDisplayModel> GetOverdueRequests(DateTime dueDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@DueDate", dueDate, DbType.DateTime, ParameterDirection.Input);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spRequestsOverdue", p, commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public List<AssignmentDisplayModel> SearchMultipleFields(string whereClause)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                //Project ID
                p.Add("@WhereClause", whereClause, DbType.String);
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.dspSearch_VariableFields", p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<AssignmentDisplayModel> Assignments_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<AssignmentDisplayModel> output = connection.Query<AssignmentDisplayModel>("dbo.spAssignments_GetAll", commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public void UpdateTable(string spName, DataTable dt)
        {
            string db;
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                db = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
            }
            else
            {
                db = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
            }

            using (SqlConnection con = new SqlConnection(db))
            {
                DataColumn idColumn = dt.Columns["ID"];
                if (idColumn != null)
                {
                    dt.Columns.Remove("ID"); 
                }
                SqlCommand cmd = new SqlCommand(spName, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Assignments_tableType";
                param.Value = dt;
                cmd.Parameters.Add(param);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        public List<FE_Model> FE_GetByID(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ID", ID, DbType.Int32);
                List<FE_Model> output = connection.Query<FE_Model>("dbo.spFE_GetByID", p, commandType: CommandType.StoredProcedure).ToList();
                //List<RequestModel> output = connection.Query<RequestModel>("dbo.dspSearch_VariableFields", p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public void Assignments_FEListXMLUpdateByID(int AssignmentID, string xmlData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ID", AssignmentID, DbType.Int32);
                p.Add("@Value", xmlData, DbType.String);
                connection.Execute("spAssignments_FE_ListUpdateByID", p, commandType: CommandType.StoredProcedure);
            }
        }



        public List<ActivityModel> Activity_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<ActivityModel> output = connection.Query<ActivityModel>("dbo.spActivity_GetAll", 
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<FE_Model> FE_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<FE_Model> output = connection.Query<FE_Model>("dbo.spFE_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<CityModel> Cities_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<CityModel> output = connection.Query<CityModel>("dbo.spCities_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<ProductModel> Products_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<ProductModel> output = connection.Query<ProductModel>("dbo.spProducts_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<RegionsModel> Regions_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<RegionsModel> output = connection.Query<RegionsModel>("dbo.spRegions_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<StateModel> States_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<StateModel> output = connection.Query<StateModel>("dbo.spStates_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<RequestorModel> Requestors_GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<RequestorModel> output = connection.Query<RequestorModel>("dbo.spRequestors_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
    }
}
