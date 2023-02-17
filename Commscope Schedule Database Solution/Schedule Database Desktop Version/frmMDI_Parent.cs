﻿using ScheduleDatabaseClassLibrary;
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
            frmLabEsc EscalationsForm = new frmLabEsc();
            //EscalationsForm.MdiParent= this;
            EscalationsForm.StartPosition = FormStartPosition.CenterScreen;
            //EscalationsForm.Height = 718;
            //EscalationsForm.Width = 1330;
            EscalationsForm.Show();
            return EscalationsForm;
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            frmLabEsc escForm = showLabEscForm();
            
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
            List<CompanyHolidaysModel> holidays = GlobalConfig.Connection.GenericGetAll<CompanyHolidaysModel>("tblHolidaysList", "HolidayDate");
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

        private void closedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("E", false);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", true);
        }

        private void closedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscReport;
            GetModels("L", false);
        }
    }
}
 