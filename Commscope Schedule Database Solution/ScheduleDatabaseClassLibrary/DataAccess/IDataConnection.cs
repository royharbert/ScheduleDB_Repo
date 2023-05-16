using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.DataAccess
{ 
    public interface IDataConnection
    {
        LabEscModel LabEscDeleted_CRUD(LabEscModel model, char action);
        List<LabEscModel>  labEscSearchDateRange(DateTime startDate, DateTime endDate);
        List<LabEscModel> LabEscGetByPID(string PID, bool restore);
        void HolidayAdd(string holiday, DateTime holidayDate);
        void UpdateHolidays(string holiday, DateTime holidayDate, int idx);
        List<LabEscModel> GetLabEscByStatus(string type, bool status);
        List<LabEscModel> GetOpenEscSortedByDateDue();
        List<HolidaysModel> GetAllHolidays();
        void InsertPerson(string tableName, PersonModel model);
        LabEscModel LabEsc_CRUD(LabEscModel model, char action);
        List<LabEscModel> LabEscSearchGen(string whereClause);
        List<LabEscModel> labRequestGenSearch(string whereClause);      
        List<LabEscModel> SearchLabRequests(string searchString);
        int Product_Add(string modelNumber, string category);
        List<T> GenericOrderedGetAll<T>(string tableName, string orderByColumn);
        int Escalation_Update(DataTable dt);
        List<T> GenericGetAll<T>(string tableName, string orderByField = "");
        List<T> GetItemByColumn<T>(string tableName,string ColumnName,string StringValue,
            int IntValue = -1);
        List<T> SearchMultipleFields<T>(string TableName, string whereClause);
        void ClearTable(string tableName);
        void DeleteAttachment(AttachmentModel model);
        List<AttachmentModel> GetAttachments(string PID);
        void InsertInto_tblAttachments(AttachmentModel model);        
        int Sequence_Get();        
        void Sequence_Set(int seq);
        int EIDSequence_Get(string tableName);
        void EIDSequence_Set(string tableName, int seq);
        int AddUser(UserModel NewUser);
        void DeleteUser(int OldUser);
        void UpdateUser(UserModel ThisUser);        
        UserModel GetUser(string userName);
        void AddCountry(String ctry);
        void DeleteCountry(int idy);
        void UpdateCountry(int idx, string designer);  
        void UpdateTable(string spName, DataTable dataTable);
        //void UpdateFE(string Action, int ID, string FirstName, string LastName, string ManagerID, string Region, string Phone, string EMail, bool Active);
           }
}
