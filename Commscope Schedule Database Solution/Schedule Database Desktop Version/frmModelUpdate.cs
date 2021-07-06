using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.TableOps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmModelUpdate : Form
    {
        private enum updateModel
        {
            Activities,
            Cities,
            Countries,
            CustContact,
            CustLocations,
            FE,
            Holidays,
            Managers,
            MSO,
            Products,
            Regions,
            Salespersons,
            States,
            Users
        }

        private int tableType = -1;
        public frmModelUpdate()
        {
            InitializeComponent();
        }
        private T CastObject<T>(object input)
        {
            return (T)input;
        }

        private void rdoFE_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;

            if(button.Checked)
            {
                string senderName = button.Name;
                setDataModel(senderName); 
            }
        }

        private void setDataModel(string senderName)
        {            
            switch (senderName)
            {
                case "rdoActivity":
                    List<ActivityModel> activityList = GlobalConfig.Connection.GenericGetAll<ActivityModel>("tblActivity");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = activityList;
                    tableType = (int)updateModel.Activities;
                    break;
                case "rdoCities":
                    List<CityModel> citiesList = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = citiesList;
                    tableType = (int)updateModel.Cities;
                    break;
                case "rdoCountries":
                    List<CountriesModel> countryList = GlobalConfig.Connection.GenericGetAll<CountriesModel>("tblCountries");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = countryList;
                    tableType = (int)updateModel.Countries;
                    break;
                case "rdoCustContact":
                    List<CustomerModel> customerList = GlobalConfig.Connection.GenericGetAll<CustomerModel>("tblCustContact");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = customerList;
                    tableType = (int)updateModel.CustContact;
                    break;
                case "rdoLocations":
                    List<LocationModel> locationList = GlobalConfig.Connection.GenericGetAll<LocationModel>("tblCustomerLocations");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = locationList;
                    tableType = (int)updateModel.CustLocations;
                    break;                
                case "rdoFE":
                    List<FE_Model> feList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = feList;
                    tableType = (int)updateModel.FE;                   
                    break;
                case "rdoHolidays": 
                    List<CompanyHolidaysModel> holidayList = GlobalConfig.Connection.GenericGetAll<CompanyHolidaysModel>("tblHolidaysList");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = holidayList;
                    tableType = (int)updateModel.Holidays;
                    break;
                case "rdoManagers":
                    List<FE_Model> managerList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblManagers");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = managerList;
                    tableType = (int)updateModel.Managers;
                    break;
                case "rdoMSO":
                    List<MSO_Model> msoList = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = msoList;
                    tableType = (int)updateModel.MSO;
                    break;
                case "rdoProducts":
                    List<ProductModel> productList = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = productList;
                    tableType = (int)updateModel.Products;
                    break;
                case "rdoRegions":
                    List<RegionsModel> regionList = GlobalConfig.Connection.GenericGetAll<RegionsModel>("tblRegions");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = regionList;
                    tableType = (int)updateModel.Regions;
                    break;
                case "rdoSales":
                    List<RequestorModel> salesList = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = salesList;
                    tableType = (int)updateModel.Salespersons;
                    break;
                case "rdoStates":
                    List<StateModel> stateList = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = stateList;
                    tableType = (int)updateModel.States;
                    break;
                case "rdoUsers":
                    List<UserModel> userList = GlobalConfig.Connection.GenericGetAll<UserModel>("tblUsers");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = userList;
                    tableType = (int)updateModel.Users;
                    break;
                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Type modelType = dgvModel.DataSource.GetType();
            //TableGenerator<typeof(modelType)> tg = new TableGenerator<dgvModel.DataSource.GetType() > ();
            //{


            //}
            //List<)> tList = new List<Type>();

            //updateRecord(dgvModel.CurrentRow.Index);
        }
        private void updateRecord<T>(int selRow, T record)
        {

        }
    }
}
