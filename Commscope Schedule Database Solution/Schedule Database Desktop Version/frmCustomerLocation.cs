using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmCustomerLocation : Form
    {
        private LocationModel _location = null;
        private List<LocationModel> Locations = new List<LocationModel>();
        public LocationModel CustomerLocation
        {
            set 
            {
                _location = value;
                txtLocID.Text = _location.ID.ToString();
                txtSiteName.Text = _location.SiteName;
                txtAddress.Text = _location.Address;
                cboCity.Text = _location.City;
                cboState.Text = _location.State;
                cboCountry.Text = _location.Country;
                txtPostalCode.Text = _location.PostalCode;
                cboRegion.Text = _location.Region;
                btnSave.Text= "Save";
                GV.MODE = Mode.EditCustomerLocation;

            }
        }
        public frmCustomerLocation()
        {
            InitializeComponent();
            fillComboLists();
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.Edit:
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:
                    break;
                case Mode.CustomerSearchMDI:
                    break;
                case Mode.AddCustomer:
                    break;
                case Mode.EditCustomer:
                    break;
                case Mode.DeleteCustomer:
                    break;
                case Mode.AddCustomerLocation:
                    btnSave.Text = "Save";
                    btnDelete.Visible = false;
                    break;
                case Mode.EditCustomerLocation:
                    break;
                case Mode.DeleteCustomerLocation:
                    btnSave.Text = "Search";
                    btnDelete.Visible = true;
                    break;
                case Mode.LocationSearch:
                    break;
                case Mode.LocationSearchMDI:
                    btnSave.Text = "Search";
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }

        private void fillComboLists()
        {
            List<MSO_Model> MSOs = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
            cboMSO.DataSource = MSOs;
            cboMSO.DisplayMember = "MSO";
            cboMSO.SelectedIndex = -1;

            List<CityModel> cities = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities", "City");
            cboCity.DataSource = cities;
            cboCity.DisplayMember = "City";
            cboCity.SelectedIndex = -1;

            List<StateModel> states = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates", "State");
            cboState.DataSource = states;
            cboState.DisplayMember = "Abbreviation";
            cboState.SelectedIndex = -1;

            List<CountriesModel> countries = GlobalConfig.Connection.GenericGetAll<CountriesModel>("tblCountries", "Country");
            cboCountry.DataSource = countries;
            cboCountry.DisplayMember = "Country";
            cboCountry.SelectedIndex = -1;

            List<RegionsModel> regions = GlobalConfig.Connection.GenericGetAll< RegionsModel>("tblRegions", "Region");
            cboRegion.DataSource = regions;
            cboRegion.DisplayMember = "Region";
            cboRegion.SelectedIndex = -1;
        }

        private List<SearchTermModel> collectSearchTerms()
        {
            List<SearchTermModel> searchTerms = new List<SearchTermModel>();
            foreach (Control control in this.Controls)
            {
                if ((control is TextBox | control is ComboBox) & control.Text != "")
                {
                    SearchTermModel searchTerm = new SearchTermModel();
                    searchTerm.SearchTerm = control.Tag.ToString();
                    searchTerm.SearchValue = control.Text;
                    searchTerms.Add(searchTerm);
                    searchTerm = null;
                }
            }
            return searchTerms;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.Edit:
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:
                    break;
                case Mode.CustomerSearchMDI:
                    break;
                case Mode.AddCustomer:
                    break;
                case Mode.EditCustomer:
                    break;
                case Mode.DeleteCustomer:
                    break;
                case Mode.AddCustomerLocation:
                    GlobalConfig.Connection.CustomerLocations_Get
                        ("", "Insert", 0, txtSiteName.Text, cboMSO.Text, txtAddress.Text, cboCity.Text, cboState.Text, cboCountry.Text, txtPostalCode.Text, cboRegion.Text, 0);
                    GV.MODE = Mode.EditCustomerLocation;
                    btnSave.Visible = true;
                    break;
                case Mode.EditCustomerLocation:
                    btnSave.Visible = true;
                    LocationModel location = new LocationModel();
                    int lid = 0;
                    int.TryParse(txtLocID.Text, out lid);
                    location.ID = lid;
                    location.SiteName = txtSiteName.Text;
                    location.Address = txtAddress.Text;
                    location.City = cboCity.Text;
                    location.State = cboState.Text;
                    location.Country = cboCountry.Text;
                    location.PostalCode = txtPostalCode.Text;
                    location.Region = cboRegion.Text;
                    GlobalConfig.Connection.CustomerLocations_Get
                        ("", "Update", lid, txtSiteName.Text, _location.MSO, txtAddress.Text, cboCity.Text, cboState.Text, cboCountry.Text, txtPostalCode.Text, cboRegion.Text, _location.ContactID);
                    break;
                case Mode.DeleteCustomerLocation:
                    GV.MODE = Mode.DeleteCustomerLocation;
//added search for deleting LD
                    List<SearchTermModel> searchTermsDel = collectSearchTerms();
                    string clauseDel = WhereClauseGenerator.MakeWhereClause(searchTermsDel);
                    Locations = GlobalConfig.Connection.CustomerLocations_Get(clauseDel, "Select", 0, "", "", "", "", "", "", "", "", 0);
                    frmMultiSelect locationFormDel = new frmMultiSelect();
                    locationFormDel.LocationData = Locations;
                    locationFormDel.Show();
                    locationFormDel.BringToFront();
                    
                    break;
                case Mode.LocationSearch:
                    break;
                case Mode.LocationSearchMDI:
                    List<SearchTermModel> searchTerms = collectSearchTerms();
                    string clause = WhereClauseGenerator.MakeWhereClause(searchTerms);
                    Locations = GlobalConfig.Connection.CustomerLocations_Get(clause, "Select", 0, "", "", "", "", "", "", "", "", 0);
                    frmMultiSelect locationForm = new frmMultiSelect();
                    locationForm.LocationData = Locations;
                    locationForm.Show();
                    locationForm.BringToFront();
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }

        private void clearForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
                if (ctl is ComboBox)
                {
                    ComboBox combo = (ComboBox)ctl;
                    combo.SelectedIndex = -1;
                }
            }
        }

// added delete button functions LD
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?","Delete Customer Location",buttons:MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            GV.MODE = Mode.DeleteCustomerLocation;
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.Edit:
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:
                    break;
                case Mode.CustomerSearchMDI:
                    break;
                case Mode.AddCustomer:
                    break;
                case Mode.EditCustomer:
                    break;
                case Mode.DeleteCustomer:
                    break;
                case Mode.AddCustomerLocation:
                    break;
                case Mode.EditCustomerLocation:
                    break;
                case Mode.DeleteCustomerLocation:  
                    GlobalConfig.Connection.CustomerLocations_Get
                        ("", "Delete", _location.ID, txtSiteName.Text, _location.MSO, txtAddress.Text, cboCity.Text, cboState.Text, cboCountry.Text, txtPostalCode.Text, cboRegion.Text, _location.ContactID);
                    MessageBox.Show("Customer Location Deleted");
                    clearForm();
                    btnSave.Visible = false;
                    break;
                case Mode.LocationSearch:
                    break;
                case Mode.LocationSearchMDI:
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }
    }
}
