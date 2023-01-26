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
            //frmAssignment frmAssignment = new frmAssignment();
            //frmAssignment.MdiParent = this;
            //frmAssignment.Dock = DockStyle.Fill;
            //GV.ASSIGNMENTFORM = frmAssignment;
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

        private void showLabEscForm()
        {
            frmLabEsc EscalationsForm = new frmLabEsc();
            EscalationsForm.MdiParent = this;
            //EscalationsForm.Height = 970;
            //EscalationsForm.Width = 1950;
            EscalationsForm.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscSearch;
            showLabEscForm();
        }
    }
}
 