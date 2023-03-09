using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            List<UserModel> userModel = new List<UserModel>();
            InitializeComponent();
            txtUsername.Text = GV.USERMODEL.FullName;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            UserModel model = GV.USERMODEL;

            if (txtNewPass.Text == txtConfirmPass.Text && txtCurrentPass.Text == GV.USERMODEL.PW)
            {
                model.PW = txtNewPass.Text;
               
                GlobalConfig.Connection.UpdateUser(model);
                MessageBox.Show("Password has been updated");
                this.Close();
            }
            else if (txtNewPass.Text == txtConfirmPass.Text && txtCurrentPass.Text != GV.USERMODEL.PW)
            {
                MessageBox.Show("New Password could not be saved, please ensure previous password is correct");
            }
            else if (txtNewPass.Text != txtConfirmPass.Text && txtCurrentPass.Text == GV.USERMODEL.PW)
            {
                MessageBox.Show("Password could not be updated, password and confirmation fields do not match");
            }
            else
            {
                MessageBox.Show("Password could not be updated, please fill out required fields");
            }
        }
    }
}
