using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using Squirrel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmAltMainMenu : Form
    {
        frmAMDI_Parent Parent = new frmAMDI_Parent();
        frmInput inputID = new frmInput();
        public frmAltMainMenu()
        {
            InitializeComponent();
            setFormText();
            setDBConfigProperty();
            SetMenuAccess();
        }

        public void SetMenuAccess()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    ctl.Visible = false;
                    int minimumPriviledge = int.Parse(ctl.Tag.ToString());
                    if (GV.Priviledge >= minimumPriviledge)
                    {
                        ctl.Visible = true;
                    }
                }

            }
        }
            private frmLabEsc showLabEscForm()
        {
            Mode curMode = GV.MODE;
            frmLabEsc EscalationsForm = new frmLabEsc();
            EscalationsForm.DisplayForm = EscalationsForm;
            EscalationsForm.StartPosition = FormStartPosition.CenterScreen;
            EscalationsForm.Show();
            GV.MODE = curMode;
            return EscalationsForm;
        }

        private void frmAltMainMenu_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);            
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscAdd;
            showLabEscForm();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            frmPassword passwordForm = new frmPassword();
            passwordForm.Show();
        }

        private void btnPreferredScreen_Click(object sender, EventArgs e)
        {
            {
                Form ScreenForm = new frmScreens();
                ScreenForm.Show();
            }
        }

        private void btnHolidayMaint_Click(object sender, EventArgs e)
        {
            frmHoliday holidayForm = new frmHoliday();
            holidayForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            showLabEscForm();
        }
        private List<LabEscModel> GetModels(string type = "", bool isOpen = false)
        {
            List<LabEscModel> models = new List<LabEscModel>();
            if (GV.MODE == Mode.OpenEscByDate)
            {
                models = ScheduleDatabaseClassLibrary.ReportOps.GetOpenEscByDateDue();
            }
            else
            {
                models = GlobalConfig.Connection.GetLabEscByStatus(type, isOpen);
            }

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
        private void btnDateRange_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;

            frmSearchDateRange searchDateRange = new frmSearchDateRange();
            searchDateRange.Show();
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            //frmInput inputID = new frmInput();
            inputID.Show();
            GV.inputForm = inputID;
            inputID.InputDataReady += InputID_InputDataReady;


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
                    frmLabEsc resultsForm= new frmLabEsc();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscDelete;
            Parent.prepareDeleteRestore();
        }

        private void btnRptAllOpen_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.OpenEscByDate;

            GetModels();
        }

        private void btnRptOpenEsc_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("E", true);
        }

        private void btnRptClosedEsc_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("E", false);
        }

        private void btnRptOpenReq_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", true);
        }

        private void btnRpeClosedReq_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setFormText()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string dbMode = "";
            if (GlobalConfig.DatabaseMode == DatabaseType.Live)
            {
                dbMode = "LIVE DATA";
                //pbLive.Visible = true;
                //pbSandbox.Visible = false;
            }
            else
            {
                dbMode = "SANDBOX";
                //pbSandbox.Visible = true;
                //pbLive.Visible = false;
            }
            this.Text = $"     V.{ versionInfo.FileVersion }" + "     " + dbMode;
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

        private void rdoLive_CheckedChanged(object sender, EventArgs e)
        {
            GV.Priviledge = 0;
            GV.MAINMENU.SetMenuAccess();
            GV.USERMODEL = null;
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobalConfig.SetDatabaseMode(DatabaseType.Sandbox);
            setDBConfigProperty();
            this.Refresh();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GV.USERMODEL = null;
            this.Visible = false;
            GV.Priviledge = 0;
            GV.MAINMENU.SetMenuAccess();
        }

        private void btnUserMaint_Click(object sender, EventArgs e)
        {
            frmAdminMaint adminMaint = new frmAdminMaint();
            adminMaint.Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscRestore;
            Parent.prepareDeleteRestore();
        }
    }
}
