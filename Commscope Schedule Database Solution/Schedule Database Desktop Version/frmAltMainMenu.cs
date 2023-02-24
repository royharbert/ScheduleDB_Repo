﻿using ScheduleDatabaseClassLibrary;
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

namespace Schedule_Database_Desktop_Version
{
    public partial class frmAltMainMenu : Form
    {
        public frmAltMainMenu()
        {
            InitializeComponent();
            setFormText();
            setDBConfigProperty();
        }

        
        private frmLabEsc showLabEscForm()
        {
            frmLabEsc EscalationsForm = new frmLabEsc();
            EscalationsForm.StartPosition = FormStartPosition.CenterScreen;

            EscalationsForm.Show();
            return EscalationsForm;
        }

        private void frmAltMainMenu_Load(object sender, EventArgs e)
        {

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

        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            frmInput inputID = new frmInput();
            inputID.Show();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscDelete;
            frmInput inputID = new frmInput();
            inputID.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {

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
            GlobalConfig.SetDatabaseMode(DatabaseType.Live);
            setDBConfigProperty();
            this.Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobalConfig.SetDatabaseMode(DatabaseType.Sandbox);
            setDBConfigProperty();
            this.Refresh();
        }
    }
}