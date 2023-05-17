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
    public partial class frmAddPerson : Form
    {
        PersonModel model = new PersonModel();
        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
                model.FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
                model.LastName = value;
            }
        }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public string ActiveTable { get; set; }
        public frmAddPerson()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            rdoActive.Checked = true;
            FC.SetFormPosition(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            loadModel(model);
            GlobalConfig.Connection.InsertPerson(ActiveTable, model);
            this.Close();
        }

        private PersonModel loadModel(PersonModel model)
        {
            model.FirstName = txtFirstName.Text;
            model.LastName = txtLastName.Text;
            model.PhoneNumber= txtPhoneNumber.Text;
            if (rdoActive.Checked)
            {
                model.Active = true;
            }
            else
            {
                model.Active = false;
            }
            this.BringToFront();
            return model;
        }
    }
}
