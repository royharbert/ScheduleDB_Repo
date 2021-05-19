using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
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
    public partial class frmCustomerContact : Form
    {
        List<TextBox> boxes = new List<TextBox>();
        public frmCustomerContact()
        {
            InitializeComponent();

            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    TextBox box = ctl as TextBox;
                    boxes.Add(box);
                }
            }
            switch (GV.MODE)
            {
                case Mode.AddCustomer:
                    btnSave.Text = "Save";
                    btnDelete.Visible = false;
                    clearBoxes();
                    break;
                case Mode.EditCustomer:
                    btnSave.Text = "Save";
                    btnDelete.Visible = false;
                    break;
                case Mode.DeleteCustomer:
                    btnDelete.Visible = false;
                    btnSave.Text = "Search";
                    clearBoxes();
                    break;
                case Mode.CustomerSearchMDI:
                    clearBoxes();
                    btnDelete.Visible = false;
                    btnSave.Text = "Search";
                    break;

            }
        }

        private void searchContact()
        {
            GV.MODE = Mode.CustomerSearchMDI;
            btnDelete.Visible = false;
            List<FieldSearchModel> searchTerms = new List<FieldSearchModel>();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox & control.Text != "")
                {
                    FieldSearchModel model = new FieldSearchModel();
                    model.FieldName = control.Tag.ToString();
                    model.FieldValue = control.Text;
                    searchTerms.Add(model);
                    model = null;
                }
            }
            List<CustomerModel> customers = SearchOps.FieldSearchCI<CustomerModel>(searchTerms, "tblCustContact",
                true);
            frmMultiSelect ResultsForm = new frmMultiSelect();
            ResultsForm.CustomerData = customers;
            ResultsForm.CallingForm = this;
            ResultsForm.Show();
            //added DelSearchContact LD
        }
        private void delSearchContact()
        {
            GV.MODE = Mode.DeleteCustomer;
            btnDelete.Visible = true;
            List <FieldSearchModel> DelsearchTerms = new List<FieldSearchModel>();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox & control.Text != "")
                {
                    FieldSearchModel model = new FieldSearchModel();
                    model.FieldName = control.Tag.ToString();
                    model.FieldValue = control.Text;
                    DelsearchTerms.Add(model);
                    model = null;
                }
            }
            List<CustomerModel> customers = SearchOps.FieldSearchCI<CustomerModel>(DelsearchTerms, "tblCustContact",
                true);
            frmMultiSelect delResultsForm = new frmMultiSelect();
            delResultsForm.CustomerData = customers;
            delResultsForm.CallingForm = this;
            btnDelete.Visible = true;
            delResultsForm.Show();

        }

        /// <summary>
        /// Fills boxes with data from CustomerModel
        /// Sets Mode to Edit
        /// </summary>
        /// <param name="customer"></param>
        public void FillBoxes(CustomerModel customer)
        {
            txtID.Text = customer.ID.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtMSO.Text = customer.MSO;
            txtPhone.Text = customer.Phone;
            txtEMail.Text = customer.EMail;
            txtLocationID.Text = customer.LocID.ToString();

            GV.MODE = Mode.EditCustomer;
            btnSave.Text = "Save";
            btnDelete.Visible = false;

            GV.MODE = Mode.DeleteCustomer;
            btnSave.Text = "Search";
            btnDelete.Visible = true;

           // GV.MODE = Mode.CustomerSearchMDI;
            // btnDelete.Visible = false;


        }

        private CustomerModel loadData()
        {
            CustomerModel customer = new CustomerModel();
            int id = 0;
            int.TryParse(txtID.Text, out id);
            customer.ID = id;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.MSO = txtMSO.Text;
            customer.EMail = txtEMail.Text;
            customer.Phone = txtPhone.Text;
            int LID = 0;
            int.TryParse(txtLocationID.Text, out LID);
            customer.LocID = LID;

            return customer;
        }

        private void clearBoxes()
        {
            foreach (TextBox box in boxes)
            {
                box.Clear();
            }
        }

        private void clearForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
                if (ctl is ComboBox)
                {
                    ComboBox combo = (ComboBox)ctl;
                    combo.SelectedIndex = -1;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerModel customerData = loadData();
            switch (GV.MODE)
            {
                case Mode.AddCustomer:
                    GlobalConfig.Connection.Customer_CRUD(customerData, "Insert");
                    MessageBox.Show(customerData.FullName + " has been added.");
                    GV.MODE = GV.PreviousMode;
                    this.Close();
                    break;
                case Mode.EditCustomer:
                    GlobalConfig.Connection.Customer_CRUD(customerData, "Update");
                    MessageBox.Show(customerData.FullName + " has been updated.");
                    GV.MODE = GV.PreviousMode;
                    this.Close();
                    break;
                case Mode.DeleteCustomer:
                    delSearchContact();
                    break;
                case Mode.CustomerSearchMDI:
                    btnDelete.Visible = false;
                    searchContact();

                    //GV.MODE = Mode.EditCustomer;
                    break;
                default:
                    break;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.DeleteCustomer;
            //changed from FullName to First + Last (added GlobalConfig line)
            //added delete button function and dialog box... how do you display both text boxes
            CustomerModel customerData = loadData();
            GlobalConfig.Connection.Customer_CRUD(customerData, "Delete");
            DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Customer Contact", buttons: MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.No)
            {
                return;
            }
           
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.Edit:
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:
                    btnDelete.Visible = false;
                    break;
                case Mode.CustomerSearchMDI:
                    btnDelete.Visible = false;
                    break;
                case Mode.AddCustomer:
                    btnDelete.Visible = false;
                    break;
                case Mode.EditCustomer:
                    break;
                case Mode.DeleteCustomer:
                    MessageBox.Show(customerData.FirstName + customerData.LastName + " has been deleted.");
                    clearForm();
                    break;
                case Mode.AddCustomerLocation:
                    break;
                case Mode.EditCustomerLocation:
                    break;
                case Mode.DeleteCustomerLocation:
                    break;
                case Mode.LocationSearch:
                    break;
                case Mode.LocationSearchMDI:
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            
            }
        }
    }
}

            
