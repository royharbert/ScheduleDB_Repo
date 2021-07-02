using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmModelUpdate : Form
    {
        object obj = new object();
        public frmModelUpdate()
        {
            InitializeComponent();
        }
        private T CastObject<T>(object input)
        {
            return (T)input;
        }

        private void frmModelUpdate_Load(object sender, EventArgs e)
        {
            
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
                    break;
                case "rdoCities":
                    List<CityModel> citiesList = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = citiesList;
                    break;
                case "rdoCountries":
                    List<CountriesModel> countryList = GlobalConfig.Connection.GenericGetAll<CountriesModel>("tblCountries");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = countryList;
                    break;
                case "rdoCustContact":
                    List<CustomerModel> customerList = GlobalConfig.Connection.GenericGetAll<CustomerModel>("tblCustContact");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = customerList;                    
                    break;
                case "rdoLocations":
                    List<LocationModel> locationList = GlobalConfig.Connection.GenericGetAll<LocationModel>("tblCustomerLocations");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = locationList;
                    break;                
                case "rdoFE":
                    List<FE_Model> feList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = feList;
                    break;
                case "rdoHolidays": 
                    List<CompanyHolidaysModel> holidayList = GlobalConfig.Connection.GenericGetAll<CompanyHolidaysModel>("tblHolidaysList");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = holidayList;
                    break;
                case "rdoManagers":
                    List<FE_Model> managerList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblManagers");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = managerList;
                    break;
                case "rdoMSO":
                    List<MSO_Model> msoList = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = msoList;
                    break;
                case "rdoProducts":
                    List<ProductModel> productList = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = productList;
                    break;
                case "rdoRegions":
                    List<RegionsModel> regionList = GlobalConfig.Connection.GenericGetAll<RegionsModel>("tblRegions");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = regionList;
                    break;
                case "rdoSales":
                    List<RequestorModel> salesList = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = salesList;
                    break;
                case "rdoStates":
                    List<StateModel> stateList = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = stateList;
                    break;
                case "rdoUsers":
                    List<UserModel> userList = GlobalConfig.Connection.GenericGetAll<UserModel>("tblUsers");
                    dgvModel.DataSource = null;
                    dgvModel.DataSource = userList; ;
                    break;
                default:
                    break;
            }
        }
    }
}
