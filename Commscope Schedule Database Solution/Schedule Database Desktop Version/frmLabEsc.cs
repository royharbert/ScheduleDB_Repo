using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Operations;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmLabEsc : Form
    {
        bool isEscalation = false;
        public frmLabEsc()
        {
            InitializeComponent();
        }

        private void clearDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    DateTime newDate = CommonOps.dtpForcedReset(sourceControl as DateTimePicker);
                    DateTimePicker dtp = (DateTimePicker)sourceControl;
                    dtp.Value = newDate;
                }                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLabEsc_Load(object sender, EventArgs e)            
        {
            // determine type
            RadioButton[] buttons = { rdoATEsc, rdoLabReq };
            for (int i = 0; i < buttons.Length - 1; i++)
            {
                if (true)
                {
                    switch (i)
                    {
                        case 0:
                            isEscalation = true;
                            break;
                        case 1:
                            isEscalation = false;
                            break;
                    
                    }
                }
            }

            //load combo lists
            List<MSO_Model> models = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
            populateCBOList<MSO_Model>(cboMSO, models, "MSO");

            List<CityModel> cities = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities", "City");
            populateCBOList<CityModel>(cboCity, cities, "City");

            List<StateModel> states = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates", "State");
            populateCBOList<StateModel>(cboState, states, "State");

            List<CountriesModel> countries = GlobalConfig.Connection.GenericGetAll<CountriesModel>("tblCountries", "Country");
            populateCBOList<CountriesModel>(cboCountry, countries, "Country");

            List<PriorityModel> priorities = GlobalConfig.Connection.GenericGetAll<PriorityModel>("tblPriorities", "Priority");
            populateCBOList<PriorityModel>(cboSeverity, priorities, "Priority");

            List<RequestorModel> salesPersons = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons", "SalesPerson");
            populateCBOList<RequestorModel>(cboRequestor, salesPersons, "Salesperson");

            List<AdminModel> admins = GlobalConfig.Connection.GenericGetAll<AdminModel>("tblAdmins", "FullName");
            populateCBOList<AdminModel>(cboEntryAdmin, admins, "FullName");

            List<FE_Model> FEs = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE", "Last" +
                "Name");
            populateCBOList<FE_Model>(cboEntryAdmin, FEs, "FullName");
        }

        private void populateCBOList<T>(ComboBox cbo, List<T> models, string displayMember)
        {
            cbo.DataSource = models;
            cbo.DisplayMember = displayMember;
            cbo.SelectedIndex = -1;
        }
       
    }
}
