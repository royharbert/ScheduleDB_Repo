using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Utilities;
using System;
using System.Collections.Generic;
using Squirrel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmAMDI_Parent : Form
    {
        public frmAMDI_Parent()
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            CheckForUpdates();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            InitializeComponent();
            GV.ActiveScreen = Properties.Settings.Default.ActiveScreen;
            FC.SetFormPosition(this);
            //Color defaultBackColor = this.BackColor;
            GV.MAINMENU = this;
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog();
            frmAssignment frmAssignment = new frmAssignment();
            frmAssignment.MdiParent = this;
            frmAssignment.Dock = DockStyle.Fill;
            GV.ASSIGNMENTFORM = frmAssignment;
            int configMode = Properties.Settings.Default.DatabaseMode;
            if (configMode == 1)
            {
                GlobalConfig.DatabaseMode = DatabaseType.Live;
            }
            else
            {
                GlobalConfig.DatabaseMode = DatabaseType.Sandbox;
            }
            setFormText();
            setDBConfigProperty();
            SetMenuAccess();
        }
        private void setFormText()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string dbMode = "";
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                dbMode = "LIVE DATA";
            }
            else
            {
                dbMode = "SANDBOX";
            }
            this.Text = $"     V.{ versionInfo.FileVersion }" + "     " + dbMode;
        }

        public void SetMenuAccess()
        {
            foreach (ToolStripMenuItem item in mnuMain.Items)
            {
                item.Visible = false;
                int minimumPriviledge = int.Parse(item.Tag.ToString());
                if (GV.Priviledge >= minimumPriviledge)
                {
                    item.Visible = true;
                    foreach (ToolStripDropDownItem subItem in item.DropDownItems)
                    {
                        subItem.Visible = false;
                        minimumPriviledge = int.Parse(subItem.Tag.ToString());
                        if (GV.Priviledge >= minimumPriviledge)
                        {
                            subItem.Visible = true;
                        }
                    }
                }

            }
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"\\sccacve1\Databases\ScheduleDB"))
            {
                await manager.UpdateApp();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.New;
            GV.ASSIGNMENTFORM.Show();
        }

        private void liveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalConfig.SetDatabaseMode(DatabaseType.Live);
            setDBConfigProperty();
        }

        private void setDBConfigProperty()
        {
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                Properties.Settings.Default.DatabaseMode = 1;
                setFormText();
            }
            else
            {
                Properties.Settings.Default.DatabaseMode = 0;
                setFormText();
            }
            Properties.Settings.Default.Save();
        }

        private void sandboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalConfig.SetDatabaseMode(DatabaseType.Sandbox);
            setDBConfigProperty();
            this.Refresh();
        }

        private void fEUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFE feForm = new frmFE();
            feForm.MdiParent = this;
            feForm.Show();
        }

        private void editRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.Edit;
            GV.ASSIGNMENTFORM.Show();
            GV.ASSIGNMENTFORM.getAssignmentSearchData();
        }

        private void fEToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FE_IDtoXML.SerializeFEID();
        }

        private void productsToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FE_IDtoXML.SerializeProductListToXML();
        }

        private void addNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.AddCustomer;
            frmCustomerContact ContactForm = new frmCustomerContact();
            ContactForm.MdiParent = this;
            ContactForm.Show();
        }

        private void searchContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.CustomerSearchMDI;
            frmCustomerContact ContactForm = new frmCustomerContact();
            ContactForm.MdiParent = this;
            ContactForm.Show();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.AddCustomerLocation;
            frmCustomerLocation LocationForm = new frmCustomerLocation();
            LocationForm.MdiParent = this;
            LocationForm.Show();
        }

        private void activityToINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ActivityModel> activities = GlobalConfig.Connection.GenericGetAll<ActivityModel>("tblActivities", "Activity");
            foreach (ActivityModel activity in activities)
            {
                GlobalConfig.Connection.Activity_Update_ID(activity.Purpose, activity.ID);
            }
        }

        private void searchLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LocationSearchMDI;
            frmCustomerLocation LocationForm = new frmCustomerLocation();
            LocationForm.MdiParent = this;
            GV.LOCATIONFORM = LocationForm;
            LocationForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.Priviledge = 0;
            SetMenuAccess();
            GV.USERMODEL = null;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog();
            SetMenuAccess();
        }

        private void setPreferredScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ScreenForm = new frmScreens();
            ScreenForm.Show();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.DeleteCustomer;
            frmCustomerContact ContactForm = new frmCustomerContact();
            ContactForm.MdiParent = this;
            ContactForm.Show();
        }




        //--------------------------------------------------------------------------------------------------


        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.DeleteCustomerLocation;
            frmCustomerLocation LocationForm = new frmCustomerLocation();
            LocationForm.MdiParent = this;
            GV.LOCATIONFORM = LocationForm;
            LocationForm.Show();
        }
        

        private void dateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateRange DateRangeForm = new frmDateRange();
            DateRangeForm.MdiParent = this;
            DateRangeForm.Show();
        } 

        private void addEscalationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscAdd;
            frmLabEsc EscalationsForm = new frmLabEsc();
            EscalationsForm.MdiParent = this;
            EscalationsForm.Show();
        }

        private void deleteEscalationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscDelete;
            frmInput ATInputForm = new frmInput();
            ATInputForm.MdiParent = this;
            ATInputForm.Show();
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendar calendar = new frmCalendar();
            calendar.Show();
        }

        private void mSOUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMSO MSOEditForm = new frmMSO();
            MSOEditForm.Show();
        }

        private void updaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelUpdate updater = new frmModelUpdate();
            updater.Show();
        }

        private void newRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscAdd;
            frmLabRequest labForm = new frmLabRequest();
            labForm.Show();
        }

        private void salespersonUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesPerson SalesForm = new frmSalesPerson();
            SalesForm.Show();
        }

        private void updateRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getRequestID();
        }
        private void getRequestID()
        {
            GV.MODE = Mode.LabEscEdit;
            frmLabRequest labForm = new frmLabRequest();
            labForm.Show();
            labForm.getAssignmentSearchData();

        }

        private void escalationIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            frmLabEsc LabEscForm = new frmLabEsc();
            GV.LABESCFORM = LabEscForm;
            LabEscForm.MdiParent = this;
            LabEscForm.Show();
        }

        private void dateRangeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.DateRangeReport;
            frmDateRange DateRangeForm = new frmDateRange();
            DateRangeForm.MdiParent = this;
            DateRangeForm.Show();
        }

        private void searchDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.DateRangeReportAT;
            frmDateRange DateRangeForm = new frmDateRange();
            DateRangeForm.MdiParent = this;
            DateRangeForm.Show();
        }

        private void byMSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.AssignmentSearchByMSO;
            frmMSOPicker MSOform = new frmMSOPicker();
            MSOform.MdiParent = this;
            MSOform.Show();
        }

        private void partNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byRequestIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.Edit;
            GV.ASSIGNMENTFORM.Show();
            GV.ASSIGNMENTFORM.getAssignmentSearchData();

        }

        private void generalSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.SearchFieldRequest;
            GV.ASSIGNMENTFORM.Show();
        }

        private void requestIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getRequestID();
        }

        private void dateRangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscDateRange;
            frmDateRange frmDateRange = new frmDateRange();
            frmDateRange.Show();
            frmDateRange.MdiParent = this;
        }

        private void dateRangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            searchEscalationsByDateRange();
        }

        private void byDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchEscalationsByDateRange();
        }
        private void searchEscalationsByDateRange()
        {
            GV.MODE = Mode.LabEscDateRange;
            frmDateRange frmDateRange = new frmDateRange();
            frmDateRange.Show();
            frmDateRange.MdiParent = this;
        }
        private void byDateRangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void searchRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generalSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            frmLabRequest frmLabRequest = new frmLabRequest();
            frmLabRequest.Show();
            frmLabRequest.MdiParent= this;
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            frmLabEsc frmLabEsc = new frmLabEsc();
            frmLabEsc.Show();
            frmLabEsc.MdiParent = this;
        }
    }
}
 