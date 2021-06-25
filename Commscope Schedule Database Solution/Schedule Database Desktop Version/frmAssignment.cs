using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.AssignmentsProcesses;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmAssignment : Form
    {

        //class scope variables
        AssignmentTableModel assignment = new AssignmentTableModel();
        List<ProductModel> productList = new List<ProductModel>();
        private bool dataLoading = false;
        private bool formDirty = false;
        private bool dtpResetting = false;

        public AssignmentTableModel Assignment
        {
            get
            {
                return assignment;
            }
            set
            {
                assignment = null;
                assignment = value;
                List<AssignmentTableModel> retrieveList = new List<AssignmentTableModel>();
                retrieveList.Add(assignment);
                //assignment = new AssignmentTableModel();
                this.Show();
                fillData(Assignment);
                dataLoading = false;
            }
        }

        public void FillCustomerData(CustomerModel customer)
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtEMail.Text = customer.EMail;
            txtPhone.Text = customer.Phone;
            txtCustID.Text = customer.ID.ToString();
        }

        public void FillLocationData(LocationModel location)
        {
            txtLocID.Text = location.ID.ToString();
            txtSiteName.Text = location.SiteName;
            txtAddress.Text = location.Address;
            cboCity.Text = location.City;
            cboState.Text = location.State;
            cboCountry.Text = location.Country;
            txtPostalCode.Text = location.PostalCode;
            cboRegion.Text = location.Region;
        }

        private enum ComboList
        {
            MSO = 0,
            Activity,
            FE,
            City,
            State,
            Country,
            Region,
            Requestor,
            Products
        }

        public frmAssignment()
        {
            InitializeComponent();
            pnlCompletion.Visible = false;
            GV.ASSIGNMENTFORM = this;
            dataLoading = true;

            switch (GV.MODE)
            {
                case Mode.New:
                    assignment = new AssignmentTableModel();
                    break;

                default:
                    break;
            }
        }

        private void frmAssignment_Load(object sender, EventArgs e)
        {
            dataLoading = true;
            ComboBoxListMaker listMaker = new ComboBoxListMaker();
            List<object> fullList = listMaker.FullList;

            cboMSO.DataSource = (List<MSO_Model>)fullList[(int)ComboList.MSO];
            cboMSO.DisplayMember = "MSO";
            cboMSO.SelectedIndex = -1;

            cboActivity.DataSource = (List<ActivityModel>)fullList[(int)ComboList.Activity];
            cboActivity.DisplayMember = "Purpose";
            cboActivity.SelectedIndex = -1;

            cboCity.DataSource = (List<CityModel>)fullList[(int)ComboList.City];
            cboCity.DisplayMember = "City";
            cboCity.SelectedIndex = -1;

            cboState.DataSource = (List<StateModel>)fullList[(int)ComboList.State];
            cboState.DisplayMember = "State";
            cboState.SelectedIndex = -1;

            cboCountry.DataSource = (List<CountriesModel>)fullList[(int)ComboList.Country];
            cboCountry.DisplayMember = "Country";
            cboCountry.SelectedIndex = -1;

            cboRegion.DataSource = (List<RegionsModel>)fullList[(int)ComboList.Region];
            cboRegion.DisplayMember = "Region";
            cboRegion.SelectedIndex = -1;

            cboRequestor.DataSource = (List<RequestorModel>)fullList[(int)ComboList.Requestor];
            cboRequestor.DisplayMember = "SalesPerson";
            cboRequestor.SelectedIndex = -1;

            lstTopics.DataSource = (List<ProductModel>)fullList[(int)ComboList.Products];
            lstTopics.DisplayMember = "Product";

            

            resetDTP_CustomFormat(dtpStartDate);
            resetDTP_CustomFormat(dtpEndDate);

            pnlCompletion.Visible = false;
            dataLoading = false;
            formDirty = false;
        }

        #region Form setup
        private List<FE_Model> populateFEList()
        {
            List<FE_Model> availableFEs = ScheduleOps.GetAvailability(dtpStartDate.Value, dtpEndDate.Value);
            lstFE.DataSource = availableFEs;
            lstFE.DisplayMember = "FullName";
            return availableFEs;
        }
        /// <summary>
        /// clears text from textboxes and richtextboxes, sets combobox selected index to -1
        /// and deselects all from listbox
        /// </summary>
        private void clearControls()
        {
            dataLoading = true;
            resetTextAndComboBoxesAndDTP(this.Controls);
            resetTextAndComboBoxesAndDTP(pnlCustomer.Controls);
            resetTextAndComboBoxesAndDTP(pnlLocation.Controls);
            resetTextAndComboBoxesAndDTP(pnlCompletion.Controls);

            dgvAttachments.DataSource = null;
            clearListBox(lstTopics);
            clearListBox(lstFE);
            dataLoading = false;
            formDirty = false;
        }

        private void resetTextAndComboBoxesAndDTP(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DateTimePicker)
                {
                    resetDTP_CustomFormat(control as DateTimePicker);
                }

                if (control is TextBox | control is RichTextBox)
                {
                    control.Text = "";
                }

                if (control is ComboBox)
                {
                    control.Text = "";
                    (control as ComboBox).SelectedItem = -1;
                }
            }
        }
        
        private void clearListBox(ListBox lbx)
        {
            lbx.SelectedItems.Clear();
        }

        /// <summary>
        /// locks or unlocks all textboxes, comboboxes, richtext boxes and list boxes
        /// unless they are in the comma separated skipList(no spaces)
        /// </summary>
        /// <param name="lockControl"> bool to indicate whether to lock or unlock</param>
        /// <param name="skipList">Comma separated list of control names to skip over</param>
        private void lockControls(bool lockControl, string skipList)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox | control is ComboBox | control is RichTextBox | control is ListBox
                     | control is DateTimePicker)                   
                {
                    int idx = skipList.IndexOf(control.Name);
                    if (idx == -1)
                    {
                        control.Enabled = !lockControl;
                    }
                }
            }
        }
        private void resetDTP_CustomFormat(DateTimePicker picker)
        {
            picker.CustomFormat = "  ";
            picker.Format = DateTimePickerFormat.Custom;
            picker.Text = "";
        }
        private void frmAssignment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formDirty)
            {
                DialogResult reply = MessageBox.Show("Save Changes?",
                    "Schedule Database", MessageBoxButtons.YesNo);
                if (reply == DialogResult.Yes)
                {
                    //TODO -- Write Save routine
                }
            }
        }
        private void setdtpFormat(DateTimePicker dtp)
        {
            if (!dataLoading && GV.MODE != Mode.Undo)
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
        }

        # endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #region control changed events
        private void cboMSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dataLoading)
            {
                MSO_Model model = ((MSO_Model)cboMSO.SelectedItem);
                //TODO use assignment save
                //assignment.MSO_ID = model.ID;
                formDirty = true;
                string PID = PID_Generator.GeneratePID(model);
                txtPID.Text = PID;
                lockControls(false, "");
                setLstFe_Enable();
            }
        }

        private AssignmentSaveModel assignmentToSave()
        {
            AssignmentSaveModel saveInfo = new AssignmentSaveModel();
            int LID = 0;
            int.TryParse(txtLocID.Text, out LID);
            saveInfo.LocationID = LID;
            saveInfo.CRMNumber = txtCRM.Text;
            MSO_Model mso = cboMSO.SelectedItem as MSO_Model;
            saveInfo.MSO_ID = mso.ID;
            saveInfo.StartDate = dtpStartDate.Value;
            saveInfo.EndDate = dtpEndDate.Value;
            saveInfo.Activity = cboActivity.Text;
            //UserControl AssignmentSaveModel;
            //saveInfo.ProductList = assignment.ProductList;
            saveInfo.FE1ID = 0;
            saveInfo.FE2ID = 0;
            saveInfo.FE3ID = 0;
            saveInfo.RequestID = txtPID.Text;
            saveInfo.Comments = rtbComments.Text;
            int CID = 0;
            int.TryParse(txtCustID.Text, out CID);
            saveInfo.ContactID = CID;
            saveInfo.DocCovid = assignment.DocCovid;
            saveInfo.DocCrm = assignment.DocCrm;
            saveInfo.DocTripRpt = assignment.DocTripRpt;
            saveInfo.DocWRE = assignment.DocWRE;
            saveInfo.DocRoster = assignment.DocRoster;
            int parseVal = 0;
            int.TryParse(txtHrsOnSite.Text, out parseVal);
            saveInfo.HrsOnSite = parseVal;
            RequestorModel requestor = cboRequestor.SelectedItem as RequestorModel;
            if (requestor != null)
            {
                saveInfo.Requestor = requestor.ID;
            }
            int.TryParse(txtNumTechs.Text, out parseVal);
            saveInfo.NumTechs = parseVal;
            saveInfo.DateCompleted = assignment.DateCompleted;
            saveInfo.ProductListXML = serializeProducts(productList);
            saveInfo.FE_ListXML = serializeFE();
            ActivityModel activity =(ActivityModel)cboActivity.SelectedItem;
            saveInfo.Activity_ID = activity.ID;
            saveInfo.LocationID = assignment.LocationID;
            saveInfo.ContactID = assignment.ContactID;

            return saveInfo;
        }

        private void UnAssign(AssignmentSaveModel assignment)
        {
            ScheduleOps.UnMakeAssignments(assignment.StartDate, assignment.EndDate, assignment.RequestID, 
                assignment.FE_ListXML);
        }

        private DataTable CheckForChangedFE_Assignment(AssignmentSaveModel assignment)
        {
            string RID = assignment.RequestID;
            string feXML = assignment.FE_ListXML;
            List<int> dbAssignment = Serialization.DeserializeToList<List<int>>(feXML);
            List<int> assignedFEs = ScheduleOps.CheckForExistingAssignments(RID);
            if (assignedFEs.Count > 0)
            {
                List<int> currentList = Serialization.DeserializeToList<List<int>>(feXML);
                IEnumerable <int> assignedFEsNotDBAssignment = assignedFEs.Except(dbAssignment);
                IEnumerable <int>DBAssignmentNotAssignedFEs = dbAssignment.Except(assignedFEs);
                if (assignedFEsNotDBAssignment.Count() > 0 | DBAssignmentNotAssignedFEs.Count() > 0)
                {
                    DialogResult reply = MessageBox.Show("Existing FE assignment. Unschedule them?", "", 
                        MessageBoxButtons.YesNo);
                    if (reply == DialogResult.Yes)
                    {
                        UnAssign(assignment);
                        ScheduleOps.MakeAssignments(assignment.StartDate, assignment.EndDate,
                            assignment.RequestID,feXML);
                    }
                    else
                    {
                        assignment.FE_ListXML = Serialization.SerializeToXml(currentList);
                    }
                }
            }
            List<AssignmentSaveModel> assignments = new List<AssignmentSaveModel>();
            assignments.Add(assignmentToSave());
            AssignmentSaver saver = new AssignmentSaver();
            saver.Request = assignments;
            DataTable dt = new DataTable();
            dt = saver.Table;
            return dt;
        }

        private void saveEdit()
        {
            List<AssignmentSaveModel> assignments = new List<AssignmentSaveModel>();
            assignments.Add(assignmentToSave());
            DataTable dy = new DataTable();
            AssignmentSaver saver = new AssignmentSaver();
            saver.Request = assignments;
            DataTable dt = new DataTable();
            dt = CheckForChangedFE_Assignment(assignments[0]);
            GlobalConfig.Connection.Assignment_CRUD('U', assignment.RequestID, dt);
            formDirty = false;
            MessageBox.Show(txtPID.Text + " saved.","",buttons:MessageBoxButtons.YesNo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<AssignmentSaveModel> assignments = new List<AssignmentSaveModel>();
            assignments.Add(assignmentToSave());
            switch (GV.MODE)
            { 
                case Mode.New:
            
                    AssignmentSaver saver = new AssignmentSaver();
                    saver.Request = assignments;
                    DataTable dt = new DataTable();
                    dt = saver.Table;
                    GlobalConfig.Connection.Assignment_CRUD('I', "", dt);
                    ScheduleOps.MakeAssignments(assignments[0].StartDate, assignments[0].EndDate,
                        assignments[0].RequestID, assignments[0].FE_ListXML);
                    GV.MODE = Mode.Edit;
                    formDirty = false;
                    break;
                case Mode.Edit:
                    saveEdit();
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:
                    break;
                case Mode.CustomerSearchMDI:
                    break;
                case Mode.AddCustomer:
                    break;
                case Mode.EditCustomer:
                    break;
                case Mode.DeleteCustomer:
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
            formDirty = false;
            MessageBox.Show(txtPID.Text + " saved.");
        }

        private void cboActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dataLoading)
            {
                ActivityModel activity = (ActivityModel)cboActivity.SelectedItem;
                assignment.Activity = activity.Purpose;
                formDirty = true;
            }
            setRadioButtons();
        }

        private void txtCRM_TextChanged(object sender, EventArgs e)
        {
            assignment.CRMNumber = txtCRM.Text;
            formDirty = true;
        }

        //TODO  -- Use assignmentSaveModel
        //private void cboRequestor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!dataLoading)
        //    {
        //        RequestorModel requestor = (RequestorModel)cboRequestor.SelectedItem;
        //        assignment.sa = requestor.ID;
        //        formDirty = true;
        //    }
        //}

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (! dataLoading & !dtpResetting)
            {
                DateTimePicker picker = (DateTimePicker)sender;
                setdtpFormat(sender as DateTimePicker);
                assignment.StartDate = picker.Value;
                formDirty = true;
            }
            setLstFe_Enable();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (! dataLoading & !dtpResetting)
            {
                DateTimePicker picker = (DateTimePicker)sender;
                if (dtpEndDate.Value < dtpStartDate.Value)
                {
                    MessageBox.Show("End date must be later than Start Date");
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
                }
                setdtpFormat(sender as DateTimePicker);
                assignment.EndDate = picker.Value;
                formDirty = true;
                if (dtpStartDate.Format != DateTimePickerFormat.Custom & dtpEndDate.Format != DateTimePickerFormat.Custom)
                {
                    List<FE_Model> availableFEs = ScheduleOps.GetAvailability(dtpStartDate.Value, dtpEndDate.Value);
                    lstFE.DataSource = availableFEs;
                    lstFE.DisplayMember = "FullName";
                    lstFE.Enabled = true;
                    lstFE.SelectedIndex = -1;
                }
            }
        }

        private void rtbComments_TextChanged(object sender, EventArgs e)
        {
            assignment.Comments = rtbComments.Text;
        }
        #endregion

        private string collectProducts()
        {
            string xmlString = "";
            if (!dataLoading)
            {
                foreach (var item in lstTopics.SelectedItems)
                {
                    productList.Add((ProductModel)item);
                }

                xmlString = Serialization.SerializeToXml<List<ProductModel>>(productList);
                assignment.ProductListXML = xmlString;
            }
            return xmlString;
        }

        private void loadProductsInListbox(string xmlList)
        {
            if (xmlList != null & xmlList != "")
            {
                List<int> productList = Serialization.DeserializeToList<List<int>>(xmlList);

                //make list of product models from ID's
                List<ProductModel> productModelList = new List<ProductModel>();
                if (productList.Count > 0)
                {
                    for (int j = 0; j < productList.Count; j++)
                    {                       
                        List<ProductModel> products = GlobalConfig.Connection.GetItemByColumn<ProductModel>
                            ("tblProducts", "ID", "", productList[j]);
                        if (products.Count > 0)
                        {
                            productModelList.Add(products[0]);
                        }
                    }
                }

                for (int j = 0; j < productModelList.Count; j++)
                {
                    string product = productModelList[j].Product;
                    for (int i = 0; i < lstTopics.Items.Count; i++)
                    {
                        ProductModel productModel = (ProductModel)lstTopics.Items[i];
                        if (productModel.Product == product)
                        {
                            lstTopics.SetSelected(i, true);
                        }
                    }
                }
            }
        }

        private List<int> assignedFElist(string xmlFE)
        {
            List<int> feList = Serialization.DeserializeToList<List<int>>(xmlFE);
            return feList;
        }

        private string serializeFE()
        {
            string xmlString;
            List<int> feID_List = new List<int>();
            foreach (var fE in lstFE.SelectedItems)
            {
                FE_Model fe = fE as FE_Model;
                feID_List.Add(fe.ID);
            }
            xmlString = Serialization.SerializeToXml<List<int>>(feID_List);
            assignment.FE_ListXML = xmlString;
            return xmlString;
        }

        private string serializeProducts(List<ProductModel> products)
        {
            string xmlString;
            List<int> ProductList = new List<int>();
            foreach (var product in lstTopics.SelectedItems)
            {
                ProductModel prod = product as ProductModel;
                ProductList.Add(prod.ID);
            }
            xmlString = Serialization.SerializeToXml<List<int>>(ProductList);
            assignment.ProductListXML = xmlString;
            return xmlString;
        }

        private void lstTopics_Leave(object sender, EventArgs e)
        {
            collectProducts();
        }

        private void setLstFe_Enable()
        {
            //lock lbFE if either start or end dates are not assigned
            if (dtpStartDate.Format == DateTimePickerFormat.Custom | dtpEndDate.Format == DateTimePickerFormat.Custom)
            {
                lstFE.Enabled = false;
            }
            else
            {
                lstFE.Enabled = true;
            }
        }

        /// <summary>
        /// Gets FE_Model list of available active FE's
        /// Adds and highlights FE's assigned to this request
        /// </summary>
        private void populate_lstFE_WithAvailableAndAssigned()
        {
            List<FE_Model> availableFEs = ScheduleOps.GetAvailability(dtpStartDate.Value, dtpEndDate.Value);
            List<int> assignedFEs = ScheduleOps.CheckForExistingAssignments(txtPID.Text);
            try
            {
                foreach (int FE in assignedFEs)
                {
                    List<FE_Model> fe = GlobalConfig.Connection.GetItemByColumn<FE_Model>("tblFE", "ID","",FE);
                    availableFEs.Add(fe[0]);
                }
                lstFE.DataSource = availableFEs;
                lstFE.DisplayMember = "FullName";
                highlightAssigned(assignedFEs);
            }
            catch (Exception)
            {

               
            }
        }

        private void highlightAssigned(List<int> assigned)
        {
            lstFE.SelectedIndex = -1;
            for (int i = 0; i < lstFE.Items.Count; i++)
            {
                FE_Model currentItem = (FE_Model)lstFE.Items[i];
                if (assigned.Contains(currentItem.ID))
                {
                    lstFE.SetSelected(i, true);
                }
            }
        }

        private void frmAssignment_Activated(object sender, EventArgs e)
        {
            switch (GV.MODE)
            {
                case Mode.New:
                    clearControls();
                    lockControls(true, "cboMSO"); 
                    break;
                case Mode.Edit:                    
                    break;
                case Mode.Undo:
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        } 
        
        public void getAssignmentSearchData()
        {
            GV.MODE = Mode.Edit;
            dataLoading = true;
            clearControls();
            lockControls(false, "");
            frmInput frmInput = new frmInput();
            frmInput.InputDataReady += FrmInput_InputDataReady;
            frmInput.Show();
        }

        /// <summary>
        /// Populates all boxes on page from data in AssignmentModel input parameter
        /// </summary>
        /// <param name="assignment"></param>
        private void fillData(AssignmentTableModel assignment)
        {
            List<AssignmentTableModel> assignmentList = new List<AssignmentTableModel>();
            assignmentList.Add(assignment);
            List<AssignmentDisplayModel> displayModel = TableToDisplayConverter.ConvertTableToDisplayModel(assignmentList);
            AssignmentDisplayModel D = displayModel[0];
            dataLoading = true;
            loadProductsInListbox(assignment.ProductListXML);
            txtPID.Text = D.RequestID;
            cboMSO.Text = D.MSO;
            setActivityCombo(D.Activity);
            txtCRM.Text = D.CRMNumber;
            cboRequestor.Text = D.SalesPerson;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Value = D.EndDate;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Value = D.StartDate;
            dtpCompleted.Format = DateTimePickerFormat.Short;
            try
            {
                dtpCompleted.Value = D.DateCompleted;
                Application.DoEvents();
            }
            catch (Exception)
            {

            }
            txtHrsOnSite.Text = D.HrsOnSite.ToString();
            txtNumTechs.Text = D.NumTechs.ToString();
            rtbComments.Text = D.Comments;
            txtSiteName.Text =  D.SiteName;
            txtAddress.Text = D.LocAddress;
            cboCity.Text = D.LocCity;
            cboState.Text = D.LocState;
            cboCountry.Text = D.LocCountry;
            txtPostalCode.Text = D.LocPostalCode;
            cboRegion.Text = D.LocRegion;
            txtFirstName.Text = assignment.CustFirstName;
            txtLastName.Text = assignment.CustLastName;
            txtEMail.Text = D.CustEMail;
            txtPhone.Text = D.CustPhone;
            txtLocID.Text = D.LocationID.ToString();
            txtCustID.Text = D.CustomerID.ToString();
            dgvAttachments.DataSource = getAttachments(txtPID.Text);
            populate_lstFE_WithAvailableAndAssigned();

            dataLoading = false;
        }

        private void setActivityCombo(string purpose)
        {
            bool match = false;
            int idx = 0;            
            while(!match & idx < cboActivity.Items.Count)
            {
                ActivityModel activity = (ActivityModel)cboActivity.Items[idx];
                if (activity.Purpose == purpose)
                {
                    cboActivity.SelectedIndex = idx;
                    match = true;
                }
                else
                {
                    idx++;
                }
            }
        }

        private void FrmInput_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            List<AssignmentTableModel> requests = new List<AssignmentTableModel>();
            //List<AssignmentDisplayModel> displayModels = RetrieveToDisplayModel.ConvertRetrieveToDisplay(requests);
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.Edit:
                    requests = GlobalConfig.Connection.AssignmentSearch(e.SearchString);
                    switch (requests.Count)
                    {
                        case 0:
                            MessageBox.Show("No matching records found.");
                            break;
                        case 1:
                            fillData(requests[0]);
                            break;
                        default:
                            frmMultiSelect MultiForm = new frmMultiSelect();
                            MultiForm.Show();
                            MultiForm.AssignmentData = requests;
                            break;
                    }
                    break;
                case Mode.Undo:
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearchContacts_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.CustomerSearch;
            List<FieldSearchModel> searchTerms = new List<FieldSearchModel>();
            foreach (Control control in pnlCustomer.Controls)
            {
                if (control is TextBox & control.Text != "" & 
                    control.Name != "txtCustID" & control.Name != "txtLocID")
                {
                    FieldSearchModel model = new FieldSearchModel();
                    model.FieldName = control.Tag.ToString();
                    model.FieldValue = control.Text;
                    searchTerms.Add(model);
                    model = null;
                }
            }
            if (searchTerms.Count > 0)
            {
                List<CustomerModel> customers = SearchOps.FieldSearchCI<CustomerModel>(searchTerms, "tblCustContact",
                    true);
                frmMultiSelect MultiForm = new frmMultiSelect();
                MultiForm.CustomerData = customers;
                MultiForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter at least one search term");
            }
        }

        private void btnSearchLocations_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LocationSearch;
            List<FieldSearchModel> searchTerms = new List<FieldSearchModel>();
            foreach (Control control in pnlLocation.Controls)
            {
                if ((control is TextBox | control is ComboBox) & control.Text != "")
                {
                    FieldSearchModel model = new FieldSearchModel();
                    model.FieldName = control.Tag.ToString();
                    if (control.Name == "cboState")
                    {
                        ComboBox stateCombo = (ComboBox)control;
                        StateModel stateModel = (StateModel)stateCombo.SelectedItem;
                        model.FieldValue = stateModel.Abbreviation;
                    }
                    else
                    {
                        model.FieldValue = control.Text;
                    }
                    searchTerms.Add(model);
                    model = null;
                }
            }
            List<LocationModel> locations = SearchOps.FieldSearchCI<LocationModel>(searchTerms, "tblCustomerLocations",
                true);
            frmMultiSelect MultiForm = new frmMultiSelect();
            MultiForm.LocationData  = locations;
            MultiForm.Show();
        }

        private void btnCompletionDone_Click(object sender, EventArgs e)
        {
            pnlCompletion.Visible = false;
        }

        private void btnCloseout_Click(object sender, EventArgs e)
        {
            dataLoading = true;
            pnlCompletion.Visible = true;
            pnlCompletion.BringToFront();
            if (assignment.DateCompleted < DateTime.Parse("1/1/1900"))
            {
                dtpCompleted.Format = DateTimePickerFormat.Custom;
                dtpCompleted.Text = "";
            }
            else
            {
                dtpCompleted.Format = DateTimePickerFormat.Short;
                dtpCompleted.Value = assignment.DateCompleted;
                dtpCompleted.Text = dtpCompleted.Value.ToString();
            }
            dataLoading = false;
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            addAttachment();
        }

        private void addAttachment()
        {
            GV.MODE = Mode.Add_Attachment;
            AttachmentModel model = new AttachmentModel();
            frmAttType frm = new frmAttType(model);
            string[] labels = { "Covid Release", "CRM Entry", "Trip Report Entry", "Weekly Report Entry", "Roster", "Other" };
            frm.Labels = labels;
            frm.TypeReadyEvent += Frm_TypeReadyEvent;

            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Save Attachment";
            string myDox = Environment.SpecialFolder.MyDocuments.ToString();
            openFD.InitialDirectory = myDox;
            openFD.RestoreDirectory = true;
            openFD.Multiselect = false;

            model.ID = 0;
            model.PID = txtPID.Text;
                        
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string fullFileName = openFD.FileName;
            string fileName = Path.GetFileName(fullFileName);
            model.FileToSave = fullFileName;
            model.DisplayText = fileName;
            //FC.SetFormPosition(frm);
            this.BringToFront();
            frm.ShowDialog();
            }

            frm.TypeReadyEvent -= Frm_TypeReadyEvent;
            //prepForButtonLogEntry(model.DisplayText);
        }

        private void Frm_TypeReadyEvent(object sender, AttachmentModel e)
        {
            string fileName = GlobalConfig.AttachmentPath + "\\" + e.PID + "\\" + e.DisplayText;
            FileOps.SaveAttFile(e);
            GlobalConfig.Connection.InsertInto_tblAttachments(e);
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(e.PID);
            dgvAttachments.DataSource = null;
            dgvAttachments.DataSource = aList;
            formatAttGrid();
        }

        private List<AttachmentModel> getAttachments(string pid)
        {
            List<AttachmentModel> att = GlobalConfig.Connection.GetAttachments(pid);
            dgvAttachments.DataSource = att;
            formatAttGrid();
            return att;
        }

        private void formatAttGrid()
        {

            dgvAttachments.Columns[0].Visible = false;
            dgvAttachments.Columns[1].Visible = false;
            dgvAttachments.Columns[4].Visible = false;

            dgvAttachments.Columns[2].HeaderText = "File Name";
            dgvAttachments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAttachments.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;

            dgvAttachments.Columns[3].HeaderText = "Item Type";
            dgvAttachments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAttachments.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
            if (txtPID.Text != "")
            {
                getAttachments(txtPID.Text);
            }
        }

        private void dgvAttachments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AttachmentProcs.AttachmentsRowHeaderClick(dgvAttachments);
            
        }

        private void btnAttachItem_Click(object sender, EventArgs e)
        {
            addAttachment();
        }

        private void btnRemoveAttachment_Click(object sender, EventArgs e)
        {
            removeAttachment();
        }

        private void removeAttachment()
        {
            //use class to accomplish
            //make attachment model and pass to class
            GV.MODE = Mode.Delete_Attachment;
            if (dgvAttachments.CurrentRow != null)
            {
                int sel = dgvAttachments.CurrentRow.Index;
                List<AttachmentModel> aList = (List<AttachmentModel>)dgvAttachments.DataSource;
                AttachmentModel model = aList[sel];
                List<AttachmentModel> newList = AttachmentOps.DeleteAttachment(model);
                dgvAttachments.DataSource = null;
                dgvAttachments.DataSource = newList;
                formatAttGrid();
                //prepForButtonLogEntry(model.DisplayText);
            }
            else
            {
                MessageBox.Show("No row selected for deletion. \nPlease click left margin of desired row");
            }
        }

        private void btnRemoveAtt_Click(object sender, EventArgs e)
        {
            removeAttachment();
        }

        private void setRadioButtons()
        {
            //if (!dataLoading)
            //{
                switch (assignment.Activity)
                {
                    case "Training":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = false;
                        chkRoster.Checked = true;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = true;
                        break;

                    case "Deployment Support":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = true;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = true;
                        chkWRE.Checked = false;
                        break;

                    case "Troubleshooting":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = true;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = true;
                        chkWRE.Checked = true;
                        break;

                    case "SCTE Presentation":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = false;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = true;
                        break;

                    case "Internal Lab Work":
                        chkCOVID.Checked = false;
                        chkCRM.Checked = false;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = true;
                        break;

                    case "Customer Meeting":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = false;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = true;
                        chkWRE.Checked = true;
                        break;

                    case "Recall/Rework":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = true;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = true;
                        break;

                    case "Remote Training":
                        chkCOVID.Checked = true;
                        chkCRM.Checked = false;
                        chkRoster.Checked = true;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = false;
                        break;

                    case "Remote Tech Support":
                        chkCOVID.Checked = false;
                        chkCRM.Checked = true;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = false;
                        break;

                    case "Training Development":
                        chkCOVID.Checked = false;
                        chkCRM.Checked = false;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = true;
                        break;

                    case "Internal Training":
                        chkCOVID.Checked = false;
                        chkCRM.Checked = false;
                        chkRoster.Checked = false;
                        chkTripRpt.Checked = false;
                        chkWRE.Checked = true;
                        break;
                    default:
                        break;
                }
            //}
        }

        private void clearDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpResetting = true;
            Control sourceControl = null;
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            if (owner != null)
            {
                // Get the control that is displaying this context menu
                sourceControl = owner.SourceControl;
            }
            DateTimePicker dtp = (DateTimePicker)sourceControl;
            resetDTP_CustomFormat(dtp);
            dtpResetting = false;
        }

        private void lstFE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpCompleted_ValueChanged(object sender, EventArgs e)
        {
            if (!dataLoading & !dtpResetting)
            {
                DateTimePicker picker = (DateTimePicker)sender;
                setdtpFormat(sender as DateTimePicker);
                assignment.DateCompleted = picker.Value;
                formDirty = true;
            }
        }

        private void btnSaveCompletion_Click(object sender, EventArgs e)
        {
            saveEdit();
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchContacts;
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtSiteName_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchLocations;
        }

        private void txtSiteName_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }
    }
}