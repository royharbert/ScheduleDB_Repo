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
    public partial class frmAddAdmin : Form
    {
        public UserModel admin { get; set; }
        public bool AddingAdmin { get; set; }
        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);
            txtID.Hide();
            //if (!AddingAdmin)
            //{
            //    txtFirstName.Text = admin.FirstName;
            //    txtLastName.Text = admin.LastName;
            //    txtPassword.Text = admin.PW;                
            //    cboPriviledge.Text = admin.Priviledge.ToString();
            //    if (admin.Active)
            //    {
            //        rdoActive.Checked = true;
            //    }
            //    else
            //    {
            //        rdoActive.Checked = false;
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = 0;
            UserModel model = new UserModel();
            model.FirstName = txtFirstName.Text;
            model.LastName = txtLastName.Text;
            model.PW = txtPassword.Text;
            int priv = 0;
            int.TryParse(cboPriviledge.Text, out priv);
            model.Priviledge = priv;
            if (rdoActive.Checked)
            {
                model.Active = true;
            }
            else
            {
                model.Active = false;
            }
            int id = 0;
            int.TryParse(txtID.Text, out id);
            model.ID = id;

            ID = GlobalConfig.Connection.AddUser(model);
            MessageBox.Show(model.FullName + " added");
            this.Close();
            frmAdminMaint adminMaint = new frmAdminMaint();
            adminMaint.ShowDialog();
        }
    }
}
