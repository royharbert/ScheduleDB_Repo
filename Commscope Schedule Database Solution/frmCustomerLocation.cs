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
                    break;
                case Mode.EditCustomerLocation:
                    break;
                case Mode.DeleteCustomerLocation:
                    break;
                case Mode.LocationSearch:
                    break;
                case Mode.LocationSearchMDI:
                    btnDelete.Visible = false;
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
            List<CityModel> cities = GlobalConfig.Connection.Cities_GetAll();
            cboCity.DataSource = cities;
            cboCity.DisplayMember = "City";
            cboCity.SelectedIndex = -1;

            List<StateModel> states = GlobalConfig.Connection.States_GetAll();
            cboState.DataSource = states;
            cboState.DisplayMember = "State";
            cboState.SelectedIndex = -1;

            List<CountriesModel> countries = GlobalConfig.Connection.Countries_GetAll();
            cboCountry.DataSource = countries;
            cboCountry.DisplayMember = "Country";
            cboCountry.SelectedIndex = -1;

            List<RegionsModel> regions = GlobalConfig.Connection.Regions_GetAll();
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
                    break;
                case Mode.EditCustomerLocation:
                    break;
                case Mode.DeleteCustomerLocation:
                    break;
                case Mode.LocationSearch:
                    break;
                case Mode.LocationSearchMDI:
                    List<SearchTermModel> searchTerms = collectSearchTerms();
                    string clause = whereClauseGenerator.MakeWhereClause(searchTerms);
                    List<LocationModel> Locations = GlobalConfig.Connection.CustomerLocations_Get(clause, "Select", 0, "", "", "", "", "", "", "", "", 0);
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }
    }
}
