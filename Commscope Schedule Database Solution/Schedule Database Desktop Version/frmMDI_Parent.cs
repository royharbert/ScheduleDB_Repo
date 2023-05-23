using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
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
using System.Drawing.Imaging;

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
            GV.MAINMENU = this;
            frmLogin LoginForm = new frmLogin();

            if (GV.MODE != Mode.Dashboard)
            {
                LoginForm.ShowDialog();
            }
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
        private void frmInput_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            List<LabEscModel> labEsc = new List<LabEscModel>();
        }
        private void setFormText()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string dbMode = "";
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                dbMode = "LIVE DATA";
                pbLive.Visible = true;
                pbSandbox.Visible = false;
            }
            else
            {
                dbMode = "SANDBOX";
                pbSandbox.Visible = true;
                pbLive.Visible = false;
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
            using (var manager = new UpdateManager(@"\\usca5pdbatdgs01\Databases\LabProgramUpadtes"))
            {
                await manager.UpdateApp();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void addEscalationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscAdd;
            showLabEscForm();
        }

        private frmLabEsc showLabEscForm()
        {
            Mode curMode= GV.MODE;
            frmLabEsc EscalationsForm = new frmLabEsc();
            EscalationsForm.StartPosition = FormStartPosition.CenterScreen;
            EscalationsForm.fillComboBoxes();
            EscalationsForm.FillProductList();
            EscalationsForm.DisplayForm = EscalationsForm;
            EscalationsForm.Show();
            GV.MODE = curMode;
            return EscalationsForm;
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            showLabEscForm();
        }
       private void openItemsByDateDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.OpenEscByDate;
            GetModels();
        }

        private List<LabEscModel> GetModels(string type = "", bool isOpen = false)
        {
            List<LabEscModel> models = new List<LabEscModel>();
            if (GV.MODE == Mode.OpenEscByDate)
            {
                models = ReportOps.GetOpenEscByDateDue();
            }
            else
            {
                models = GlobalConfig.Connection.GetLabEscByStatus(type, isOpen);
            }
            DateTime emptyDate = new DateTime(1900, 1, 1);
            switch (models.Count)
            {
                case 0:
                    MessageBox.Show("No matching escalations/requests");
                    break;
                case 1:
                    frmLabEsc escForm = showLabEscForm();
                    escForm.LabEsc = models[0];
                    break;

                default:
                    frmMultiSelect results = new frmMultiSelect();
                    
                    results.LabRequests = models;
                    results.Show();

                    break;
            }

            return models;
        }

        private void updateHolidays()
        {
            frmHoliday holidayForm = new frmHoliday();
            holidayForm.Show();
        }

        private void updateHolidayListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            updateHolidays();
        }

        private void checkHolidaySched()
        {
            List<HolidaysModel> holidays = GlobalConfig.Connection.GenericGetAll<HolidaysModel>("tblHolidaysList", "HolidayDate");
            DateTime ckDate = holidays[2].HolidayDate;
            int ckYear = ckDate.Year;
            int curYear = DateTime.Now.Year;
            if (curYear > ckYear)
            {
                MessageBox.Show("Please update Holidays List");
            }
        }

        private void frmAMDI_Parent_Load(object sender, EventArgs e)
        {
            checkHolidaySched();
            //frmLabEsc escForm = new frmLabEsc();
            frmInput inputForm = new frmInput();
            //GV.inputForm = inputForm;
            //GV.inputForm.InputDataReady += InputID_InputDataReady;
            //GV.LABESCFORM = escForm;
            //GV.LABESCFORM.fillComboBoxes();
            //GV.LABESCFORM.FillProductList();
        }

        private void holidaysListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateHolidays();
        }

        private void adminMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminMaint adminForm = new frmAdminMaint();
            adminForm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("E", true);
        }

        private void 
            ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("E", false);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", true);
        }

        private void 
            ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", false);
        }

        private void dashboardViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword passwordForm = new frmPassword();
            passwordForm.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.Dashboard;
            frmAltMainMenu altMainMenu = new frmAltMainMenu();
            altMainMenu.Show();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscDelete;
            prepareDeleteRestore();
        }

        public void prepareDeleteRestore()
        {
            //GV.MODE = Mode.LabEscDelete;
            frmInput inputfrm = new frmInput();
            inputfrm.Show();
            GV.inputForm = inputfrm;
            inputfrm.InputDataReady += Inputfrm_InputDataReady;
        }
        private void Inputfrm_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            string pid = e.SearchString.ToString();
            List<LabEscModel> results= new List<LabEscModel>();
            if (GV.MODE != Mode.LabEscRestore)
            {
                results = GlobalConfig.Connection.LabEscGetByPID("%" + pid + "%", false); 
            }
            else
            {
                results = GlobalConfig.Connection.LabEscGetByPID("%" + pid + "%", true);
            }
            switch (results.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found");
                    break;
                case 1:
                    frmLabEsc resultsForm = new frmLabEsc();
                    resultsForm.fillComboBoxes();
                    resultsForm.FillProductList();
                    resultsForm.LabEsc = results[0];
                    resultsForm.Show();
                    break;
                default:
                    frmMultiSelect frmMultiSelect = new frmMultiSelect();
                    frmMultiSelect.LabRequests = results;
                    frmMultiSelect.Show();
                    break;
            }
        }

        private void restoreRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscRestore;
            prepareDeleteRestore();
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            frmInput inputID = new frmInput();
            inputID.Show();
            GV.inputForm = inputID;
            GV.inputForm.InputDataReady += InputID_InputDataReady;

        }
        private void InputID_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            string pid = e.SearchString.ToString();
            List<LabEscModel> results = GlobalConfig.Connection.LabEscGetByPID("%" + pid + "%", false);
            switch (results.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found");
                    break;
                case 1:
                    frmLabEsc escForm = new frmLabEsc();
                    escForm.LabEsc = results[0];
                    //escForm.ShowDialog();
                    break;
                default:
                    frmMultiSelect frmMultiSelect = new frmMultiSelect();
                    frmMultiSelect.LabRequests = results;
                    frmMultiSelect.Show();
                    break;
            }
        }

        private void closedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("E", false);
        }

        private void closedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", false);
        }
    }
}
 