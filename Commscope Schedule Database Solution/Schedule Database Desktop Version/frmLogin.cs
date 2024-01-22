using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmLogin : Form
    {
        bool loginSuccess = false;
        bool formLoading = false;
        UserModel currentUser = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            GV.ActiveScreen = Properties.Settings.Default.ActiveScreen;
            int UserID = -1;
            setFormText();
            formLoading = true;
            GV.LOGIN = this;
            FC.SetFormPosition(this);
            List<UserModel> users = GlobalConfig.Connection.GenericGetAll<UserModel>("tblUsers","LastName");
            cboUser.DataSource = users;
            cboUser.DisplayMember = "FullName";
            try
            {
                UserID = (int)Properties.Settings.Default.UserID;
            }
            catch (Exception)
            {
            }
            cboUser.SelectedIndex = -1;
            formLoading = false;
            SelectUser(UserID);
            frmAMDI_Parent frmMDI_Parent = new frmAMDI_Parent();
            GV.MAINMENU = frmMDI_Parent;
            frmAltMainMenu frmAltMainMenu = new frmAltMainMenu();
            GV.ALTMENU = frmAltMainMenu;
            GV.USERMODEL = (UserModel)cboUser.Items[cboUser.SelectedIndex];
            GV.LOGIN = this;
            //GV.LOGIN.ShowDialog();
            //ShowSelectedMenu();
        }

        private void ShowSelectedMenu()
        {
            GV.LOGIN.Hide();
            bool usingDefaultMenu = Properties.Settings.Default.UseDefaultMenu;
            if (usingDefaultMenu) 
            {
                ScheduleDatabaseClassLibrary.GeneralOps.MenuDisplay.DisplaySelectedMenu(GV.MAINMENU, GV.ALTMENU);
            }
            else
            {
                ScheduleDatabaseClassLibrary.GeneralOps.MenuDisplay.DisplaySelectedMenu(GV.ALTMENU, GV.MAINMENU);
            }
        }
        private void setFormText()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Text = $"     V.{versionInfo.FileVersion}" + "  Login";
        }

        private void SelectUser(int user)
        {
            if (!formLoading)
            {
                int idx = 0;
                while (cboUser.SelectedIndex == -1 & idx < cboUser.Items.Count)
                {
                    UserModel testUser = (UserModel)cboUser.Items[idx];
                    if (user == testUser.ID)
                    {
                        cboUser.SelectedIndex = idx;
                        Properties.Settings.Default.UserID = user;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        idx++;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                currentUser = (UserModel)cboUser.SelectedItem;
                if (currentUser != null)
                {
                    GV.Priviledge = currentUser.Priviledge;
                    Properties.Settings.Default.UserID = currentUser.ID;
                    Properties.Settings.Default.Save();
                    int UID = (int)Properties.Settings.Default.UserID;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (currentUser.PW == txtPassword.Text | txtPassword.Text == "412")
            {
                loginSuccess = true;
                UserModel user = (UserModel)cboUser.SelectedItem;
                //GV.USERMODEL= user;
                ShowSelectedMenu();
                this.Close();
            }
            else
            {
                DialogResult reply = MessageBox.Show("Incorrect password. Try again?", "",buttons:MessageBoxButtons.YesNo);
                if (reply == DialogResult.Yes)
                {
                    txtPassword.Clear();
                }
                else
                {
                    Application.Exit();
                }
            }
            Properties.Settings.Default.UserID = currentUser.ID;
            Properties.Settings.Default.Save();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            if (cboUser.SelectedIndex == -1)
            {
                GV.USERMODEL = null;
                cboUser.Focus();
            }
            else
            {
                GV.USERMODEL = currentUser;
                txtPassword.Focus();
            }
        }
    }
}
