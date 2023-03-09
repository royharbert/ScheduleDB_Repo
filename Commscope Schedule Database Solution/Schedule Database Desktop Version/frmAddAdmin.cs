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
            if (!AddingAdmin)
            {
                txtFirstName.Text = admin.FirstName;
                txtLastName.Text = admin.LastName;
                txtPassword.Text = admin.PW;                
                cboPriviledge.Text = admin.Priviledge.ToString();
                if (admin.Active)
                {
                    rdoActive.Checked = true;
                }
                else
                {
                    rdoActive.Checked = false;
                }
            }
        }
    }
}
