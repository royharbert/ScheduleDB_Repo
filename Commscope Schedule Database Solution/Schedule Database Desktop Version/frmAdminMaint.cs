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
    public partial class frmAdminMaint : Form
    {
        bool AddingUser = false;
        int selRow = -1;
        public frmAdminMaint()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void formatDGV()
        {
            dgvAdmin.Columns[0].Visible = false;
            dgvAdmin.Columns[1].Visible = false;
            dgvAdmin.Columns[2].Visible = false;
            dgvAdmin.Columns[3].Visible = false;
            dgvAdmin.Columns[5].Visible = false;
            dgvAdmin.Columns[4].Visible =false;
            dgvAdmin.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAdmin.Columns[6].HeaderText = "User";
            dgvAdmin.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvAdmin.Columns[6].HeaderCell.Style.Font = new Font("Arial", 9.75F, FontStyle.Bold);
        }
        private void frmAdminMaint_Load(object sender, EventArgs e)
        {
            loadDGV();
            FC.SetFormPosition(this);
        }

        private void loadDGV()
        {
            DataGridViewCell curCell = dgvAdmin.CurrentCell;
            int idx = -1;
            if (selRow != -1)
            {
                idx = dgvAdmin.CurrentRow.Index;
            }
            List<UserModel> admins = GlobalConfig.Connection.GenericGetAll<UserModel>("tblUsers", "LastName");
            dgvAdmin.DataSource = admins;
            formatDGV();
            if (selRow != -1)
            {
                dgvAdmin.ClearSelection();
                dgvAdmin.Rows[idx].Selected = true; 
                //dgvAdmin.CurrentCell = curCell;
            }
        }

        private void dgvAdmin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selRow = dgvAdmin.CurrentRow.Index;
            AddingUser = false;
            List<UserModel> admins = (List <UserModel>) dgvAdmin.DataSource;
            int curRow = dgvAdmin.CurrentRow.Index;
            UserModel model = admins[curRow];
            txtFirstName.Text = model.FirstName;
            txtLastName.Text = model.LastName;
            txtPassword.Text = model.PW;
            cboPriviledge.Text = model.Priviledge.ToString();
            txtID.Text = model.ID.ToString();
            if (model.Active)
            {
                rdoActive.Checked = true;
            }
            else 
            {
                rdoActive.Checked = false;
            }
            //loadDGV();
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

            switch (AddingUser)
            {
                case true:
                     ID = GlobalConfig.Connection.AddUser(model);
                    MessageBox.Show( model.FullName + " added");
                    break;
                case false:                    
                    GlobalConfig.Connection.UpdateUser(model);
                    MessageBox.Show(model.FullName + " updated");
                    clearBoxes();
                    //loadDGV();
                    break;
            }
            loadDGV();
           
        }

        private void clearBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtID.Clear();
            cboPriviledge.Text = string.Empty;
            rdoActive.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAdmin addAdmin = new frmAddAdmin();
            addAdmin.ShowDialog();
            //lblFunction.Text= "Adding User";
            AddingUser = true;
            clearBoxes();
            this.Close();
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }    
}
