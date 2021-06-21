using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.DataAccess
{ 
    public interface IDataConnection
    {
        List<T> GenericGetAll<T>(string tableName);
        List<T> GetItemByColumn<T>(string tableName,string ColumnName,string StringValue,
            int IntValue = -1);
        List<AssignmentTableModel> DateRangeSearch_SortBy(DateTime StartDate, DateTime EndDate);
        List<FE_CalendarModel> GetFEAssignments(DateTime StartDate, DateTime EndDate);
        void UnMakeAssignment(string RID, int FE_ID, DateTime StartDate, DateTime EndDate);
        void MakeAssignment(string RID, int FE_ID, DateTime StartDate, DateTime EndDate);
        List<LocationModel> CustomerLocations_Get(string WhereClause, string action, int ID, string siteName, string mso,
            string address, string city, string state, string country, string postalCode, string region, int custID);
        void Activity_Update_ID(string activity, int ID);
        //List<ActivityModel> Activities_GetAll();
        //List<AssignmentTableModel> Assignments_GetByActivity(string activity);
        void Assignment_CRUD(char action, string ID, DataTable dt);
        void Customer_CRUD(CustomerModel customer, string action);
        List<T> SearchMultipleFields<T>(string TableName, string whereClause);
        void Assignment_ProductsTOXML(int ID, string productXML);
        List<FE_Model> FE_GetAll();
        List<ActivityModel> Activity_GetAll();        
        void Assignments_FEListXMLUpdateByID(int AssignmentID, string xmlData);
        void ClearTable(string tableName);
        List<AssignmentTableModel> AssignmentSearch(string searchString);

        /// <summary>
        /// Returns an FE_Model for the FE corresponding to ID input parameter
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        List<FE_Model> FE_GetByID(int ID);
        void DeleteAttachment(AttachmentModel model);
        List<AttachmentModel> GetAttachments(string PID);
        void InsertInto_tblAttachments(AttachmentModel model);        
        int Sequence_Get();        
        void Sequence_Set(int seq);        
        List<RegionsModel> GetAllRegions();
        List<StateModel> GetAllStates();
        void AddUser(UserModel NewUser);
        void DeleteUser(int OldUser);
        void UpdateUser(UserModel ThisUser);        
        UserModel GetUser(string userName);
        List<UserModel> GetUsers_All();
        List<CompanyHolidaysModel> GetAllHolidays();
        List<CountriesModel> Countries_GetAll();
        void AddCountry(String ctry);
        void DeleteCountry(int idy);
        void UpdateCountry(int idx, string designer);        
        List<MSO_Model> MSO_GetAll();
        List<CityModel> GetAllCities();
        List<AssignmentRetrieveModel> Assignments_GetAll();
        void UpdateTable(string spName, DataTable dataTable);
        void UpdateFE(string Action, int ID, string FirstName, string LastName, string ManagerID, string Region, string Phone, string EMail, bool Active);
    }
}
