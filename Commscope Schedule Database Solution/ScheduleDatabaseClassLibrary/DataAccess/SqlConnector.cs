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
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ScheduleDatabaseClassLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public void InsertPerson(string tableName, PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TableName", tableName, DbType.String);
                p.Add("@FirstName", model.FirstName, DbType.String);
                p.Add("@LastName", model.LastName, DbType.String);
                p.Add("@PhoneNumber", model.PhoneNumber, DbType.String);
                p.Add("@Active", model.Active, DbType.String);
                p.Add("@ID", 0, DbType.Int32, ParameterDirection.Output);

                string sql = $@"insert into " + tableName + $@" ( FirstName, LastName, PhoneNumber, Active) 
                    values (@FirstName, @LastName, 
                    @PhoneNumber, @Active); 
                    select @ID = @@IDENTITY";
                connection.Execute(sql, p);
                int newID = p.Get<int>("@ID");
            }
        }
        public List<LabEscModel> LabEscSearchGen(string whereClause)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@whereClause", whereClause, DbType.String);

                List<LabEscModel> output = connection.Query<LabEscModel>("dbo.spLabEscSearchGen", p, 
               
                    commandType: CommandType.StoredProcedure).ToList();
                return output;

            }
        }
        public List<LabEscModel> labRequestGenSearch(string whereClause)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@whereClause", whereClause, DbType.String);

                List<LabEscModel> output = connection.Query<LabEscModel>("dbo.spLabRequestSearchGen", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public void FE_CRUD(FE_Model model, char action)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Action", action, DbType.String);
                p.Add("@ID", model.ID, DbType.Int32);
                p.Add("@FirstName", model.FirstName, DbType.String);
                p.Add("@LastName", model.LastName, DbType.String);
                p.Add("@ManagerID", model.ManagerID, DbType.String);
                p.Add("@Region", model.Region, DbType.String);
                p.Add("@Phone", model.Phone, DbType.String);
                p.Add("@Email", model.EMail, DbType.String);
                p.Add("@Active", model.Active, DbType.Boolean);

                connection.Execute("dbo.spFE_CRUD", p,
                    commandType: CommandType.StoredProcedure);
            }
        }
        public LabEscModel LabEsc_CRUD(LabEscModel model, char action)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Action", action, DbType.String);
                p.Add("@ID", model.ID, DbType.Int32);
                p.Add("@EscID", model.EscID, DbType.String);
                p.Add("@MSO", model.MSO, DbType.String);
                p.Add("@EndUser", model.EndUser, DbType.String);
                p.Add("@City", model.City, DbType.String);
                p.Add("@State", model.State, DbType.String);
                p.Add("@Country", model.Country, DbType.String);
                p.Add("@Severity", model.Severity, DbType.String);
                p.Add("@Requestor", model.Requestor, DbType.String);
                p.Add("@CTRNum", model.CTRNum, DbType.String);
                p.Add("@EscNum", model.EscNum, DbType.String);
                p.Add("@EntryAdmin", model.EntryAdmin, DbType.String);
                p.Add("@DateOpened", model.DateOpened, DbType.DateTime2);
                p.Add("@DateDue", model.DateDue, DbType.DateTime2);
                p.Add("@DateCompleted", model.DateCompleted, DbType.DateTime2);
                p.Add("@EMail", model.EMail, DbType.String);
                p.Add("@Product", model.Product, DbType.String);
                p.Add("@LeadAssigned", model.LeadAssigned, DbType.String);
                p.Add("@Quantity", model.Quantity, DbType.Int64);
                p.Add("@Status", model.Status, DbType.String);
                p.Add("@Comments", model.Comments, DbType.String);
                p.Add("@Description", model.Description, DbType.String);
                p.Add("@Resolution", model.Resolution, DbType.String);
                p.Add("@PSNumber", model.PSNumber, DbType.String);
                p.Add("@RecordType", model.RecordType, DbType.String);

                connection.Execute("dbo.spLabEsc_CRUD", p, commandType: CommandType.StoredProcedure);

                LabEscModel eModel = new LabEscModel();
                p = new DynamicParameters();
                p.Add("@EID", model.EscID, DbType.String);
                LabEscModel output = connection.Query<LabEscModel>("dbo.spGetEscByID", p,
                    commandType: CommandType.StoredProcedure).ToList().FirstOrDefault();

                return output;
            }
        }
        public List<AssignmentTableModel> fieldSearch(string whereClause)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@WhereClause", whereClause, DbType.String);

                List<AssignmentTableModel> output = connection.Query<AssignmentTableModel>("dbo.spAssignments_SearchVariableFields", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public void MSO_Add(string MSO_Name, string TLA, bool Active)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@MSO_Name", MSO_Name, DbType.String);
                p.Add("@TLA", TLA, DbType.String);
                p.Add("@Active", Active, DbType.Boolean);
                connection.Execute("dbo.spMSO_Add", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void ToggleActiveStatus(string tableName, string activeColumnName, int Idx, string idxName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
                //bool active = false;
                var p = new DynamicParameters();

                p.Add("@TableName", tableName, DbType.String, ParameterDirection.Input);
                p.Add("@ActiveColumnName", activeColumnName, DbType.String, ParameterDirection.Input);
                p.Add("@ID", Idx, DbType.Int32, ParameterDirection.Input);
                p.Add("@ID_ColName", idxName, DbType.String, ParameterDirection.Input);

                //List<bool> output =
                connection.Execute("dbo.spToggleActiveStatus", p, commandType: CommandType.StoredProcedure);
                //active = output[0];
                //return active;
            }
        }
        public List<T> GenericConditionalGetAll<T>(string tableName, string conditionColumn, string condition, string orderByField = null)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TableName", tableName, DbType.String);
                p.Add("@ConditionColumn", conditionColumn, DbType.String);
                p.Add("@Condition", condition, DbType.String);
                p.Add("@OrderByField", orderByField, DbType.String);

                List<T> output = connection.Query<T>("dbo.spGenericConditionalGetAll", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public void LabRequests_CRUD(LabEscModel model, char action)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                //p.Add("@Action", action, DbType.String);
                //p.Add("@ID", model.ID, DbType.Int32);
                //p.Add("@LRID", model.LRID, DbType.String);
                //p.Add("@MSO", model.MSO, DbType.String);
                //p.Add("@Product", model.Product, DbType.String);
                //p.Add("@StartDate", model.StartDate, DbType.DateTime);
                //p.Add("@EndDate", model.EndDate, DbType.DateTime);
                //p.Add("@Description", model.Description, DbType.String);
                //p.Add("@Remarks", model.Remarks, DbType.String);
                //p.Add("@EndUser", model.EndUser, DbType.String);

                connection.Execute("dbo.spLabRequest_CRUD", p,
                    commandType: CommandType.StoredProcedure);
            }
        }
        public List<LabEscModel> SearchLabRequests(string searchTerm)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SearchTerm", searchTerm, DbType.String);
                List<LabEscModel> output = connection.Query<LabEscModel>("dbo.spLabRequestSearch", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public void Salesperson_CRUD(char action, int ID, string name, bool active)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Action", action, DbType.String);
                p.Add("@SalesPerson", name, DbType.String);
                p.Add("@Active",active, DbType.Boolean);
                p.Add("@ID", ID, DbType.Int32);
                connection.Execute("dbo.spSalesperson_CRUD", p,
                    commandType: CommandType.StoredProcedure);
            }
        }
        public int Product_Add(string modelNumber, string category)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Product", modelNumber, DbType.String);
                p.Add("@Category", category, DbType.String);
                int success = connection.Execute("dbo.spProduct_Add", p,
                    commandType: CommandType.StoredProcedure);

                return success;
            }
        }

        public List<T> GenericOrderedGetAll<T>(string tableName, string orderByColumn)
        {
            var p = new DynamicParameters();
            p.Add("@TableName", tableName, DbType.String);
            p.Add("@OrderColumn", orderByColumn, DbType.String);
            List<T> list = new List<T>();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                list = connection.Query<T>("dbo.spGenericOrderedGetAll", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
        }
        public static string db { get; set; }
        public void MSO_Update(System.Data.DataTable dt)
        {
            string cs;
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                cs = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
            }
            else
            {
                cs = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spMSOTableTypeUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Table";
                param.SqlDbType = SqlDbType.Structured;
                param.Value = dt;
                cmd.Parameters.Add(param);
                param = null;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
        }
        public int Escalation_Update(System.Data.DataTable dt)
        {
            string cs;
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                cs = ConfigurationManager.ConnectionStrings["Live"].ConnectionString;
            }
            else
            {
                cs = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spEscalationTableTypeUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Table";
                param.SqlDbType = SqlDbType.Structured;
                param.Value = dt;
                cmd.Parameters.Add(param);
                param = null;

                con.Open();
                int success = cmd.ExecuteNonQuery();
                con.Close();
                return success;
            }
        }
        public List<ATEscalationsModel> SearchEscalations(string searchString)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@searchTerm", searchString, DbType.String);
                List<ATEscalationsModel> output = connection.Query<ATEscalationsModel>("dbo.spEscalationSearch", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public int EIDSequence_Get(string tableName)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Table", tableName, DbType.String);
                List<SequenceModel> output = connection.Query<SequenceModel>("dbo.spEIDSequence_Get", p,
                    commandType: CommandType.StoredProcedure).ToList();
                GlobalConfig.Connection.EIDSequence_Set(tableName, output[0].Sequence + 1);
                return output[0].Sequence;
            }
        }
        public void EIDSequence_Set(string tableName, int seq)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Table", tableName, DbType.String);
                p.Add("@Sequence", seq, DbType.Int32);
                connection.Execute("dbo.spEIDSequence_Set", p, commandType: CommandType.StoredProcedure);
            }
        }
        
        public int Escalations_Add(System.Data.DataTable dt)
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
                SqlCommand cmd = new SqlCommand("spEscalationTableTypeInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Table";
                param.SqlDbType = SqlDbType.Structured;
                param.Value = dt;
                cmd.Parameters.Add(param);
                param = null;

                con.Open();
                int success = cmd.ExecuteNonQuery();
                con.Close();
                return success;
            }
        }
        public List<T> GenericGetAll<T>(string tableName, string orderByField = "")
        {
            var p = new DynamicParameters();
            p.Add("@TableName", tableName, DbType.String);
            if (orderByField != "")
            {
                p.Add("@OrderColumn", orderByField, DbType.String); 
            }
            
            List<T> list = new List<T>();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                list = connection.Query<T>("dbo.spGenericOrderedGetAll", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
        }
        public List<T> GetItemByColumn<T>(string tableName, string columnName, string stringValue, int intValue = -1)
        {
            List<T> list = new List<T>();
            string iVal = intValue.ToString();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TableName", tableName, DbType.String, ParameterDirection.Input);
                p.Add("@ColumnName", columnName, DbType.String, ParameterDirection.Input);
                p.Add("@IntValue", iVal, DbType.String, ParameterDirection.Input);
                p.Add("@StringValue", stringValue, DbType.String, ParameterDirection.Input);

                list = connection.Query<T>("dbo.spGetItemByColumn", p,
                    commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
        }
        public List<LabEscModel> DateRangeSearchLab_SortBy(DateTime StartDate, DateTime EndDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@start", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@end", EndDate, DbType.DateTime, ParameterDirection.Input);
                //p.Add("@order", "StartDate", DbType.String, ParameterDirection.Input);

                List<LabEscModel> output = connection.Query<LabEscModel>("dbo.spLab_GetDateRange", p,
                commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public List<ATEscalationsDisplayModel> DateRangeSearchEscalations_SortBy(DateTime StartDate, DateTime EndDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@start", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@end", EndDate, DbType.DateTime, ParameterDirection.Input);
                //p.Add("@order", "StartDate", DbType.String, ParameterDirection.Input);

                List<ATEscalationsDisplayModel> output = connection.Query<ATEscalationsDisplayModel>("dbo.spATEscalations_GetDateRange1", p,
                commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
        public List<AssignmentTableModel> DateRangeSearch_SortBy(DateTime StartDate, DateTime EndDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@start", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@end", EndDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@order", "StartDate", DbType.String, ParameterDirection.Input);

                List<AssignmentTableModel> output = connection.Query<AssignmentTableModel>("dbo.spAssignments_GetDateRange", p,
                commandType: CommandType.StoredProcedure).ToList();
                return output;
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

        public void Assignment_CRUD(char action, string ID, System.Data.DataTable dt)
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


        public List<AssignmentTableModel> DateRangeSearch_Unfiltered(DateTime StartDate, DateTime EndDate, string SearchTerm)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@StartDate", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@EndDate", EndDate, DbType.DateTime, ParameterDirection.Input);
                List<AssignmentTableModel> output = null;

                switch (SearchTerm)
                {
                    case "DateAssigned":
                        output = connection.Query<AssignmentTableModel>("spDateRangeSearch_Unfiltered_DateAssigned",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateDue":
                        output = connection.Query<AssignmentTableModel>("spDateRangeSearch_Unfiltered_DateDue",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateCompleted":
                        output = connection.Query<AssignmentTableModel>("spDateRangeSearch_Unfiltered_DateCompleted",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    default:
                        break;
                }
                return output;
            }
        }

        public List<AssignmentTableModel> DateRangeSearch_MSOFiltered(DateTime StartDate, DateTime EndDate, string SearchTerm, string mso)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@StartDate", StartDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@EndDate", EndDate, DbType.DateTime, ParameterDirection.Input);
                p.Add("@MSO", mso, DbType.String, ParameterDirection.Input);
                List<AssignmentTableModel> output = null;

                switch (SearchTerm)
                {
                    case "DateAssigned":
                        output = connection.Query<AssignmentTableModel>("spDateRangeSearch_MSOFiltered_DateAssigned",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateDue":
                        output = connection.Query<AssignmentTableModel>("spDateRangeSearch_MSOFiltered_DateDue",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    case "DateCompleted":
                        output = connection.Query<AssignmentTableModel>("spDateRangeSearch_MSOFiltered_DateCompleted",
                            p, commandType: CommandType.StoredProcedure).ToList();
                        break;

                    default:
                        break;
                }
                return output;
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

        public List<AssignmentTableModel> GetDeletedRecordByPID(string PID)
        {
            AssignmentTableModel request = new AssignmentTableModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@PID", PID, DbType.String, ParameterDirection.Input);
                List<AssignmentTableModel> output = connection.Query<AssignmentTableModel>("dbo.spDeletedRequest_GetByPID", p, commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public List<AssignmentTableModel> SearchMultipleFields(string whereClause)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();

                //Project ID
                p.Add("@WhereClause", whereClause, DbType.String);
                List<AssignmentTableModel> output = connection.Query<AssignmentTableModel>("dbo.dspSearch_VariableFields", p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public void UpdateTable(string spName, System.Data.DataTable dt)
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

        public void Assignments_FEListXMLUpdateByID(int AssignmentID, string xmlData)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@ID", AssignmentID, DbType.Int32);
                p.Add("@Value", xmlData, DbType.String);
                connection.Execute("spAssignments_FE_ListUpdateByID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<FE_Model> FE_GetAll()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                List<FE_Model> output = connection.Query<FE_Model>("dbo.spFE_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public List<AssignmentTableModel> AssignmentSearch(string searchString)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                
                p.Add("@TID", searchString, DbType.String);
                List<AssignmentTableModel> output = connection.Query<AssignmentTableModel>
                    ("dbo.spAssignments_GetByTripID", p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }
    }
}
