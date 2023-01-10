using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Operations;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmLabEsc : Form
    {
        bool isEscalation = false;
        bool formDirty = false;

        DateTime emptyDate = new DateTime(1900, 1, 1);
        LabEscModel model = new LabEscModel();
        frmInput inputForm = new frmInput();

        public frmLabEsc()
        {
            InitializeComponent();
            fillComboBoxes();
            dtpDueDate.CustomFormat = " ";
            dtpClosedDate.CustomFormat = " ";
            dtpStartDate.CustomFormat = " ";

            switch (GV.MODE)
            {
                case Mode.LabEscAdd:
                    CommonOps.lockControls(true, this, "cboMSO"); //moved this into Add mode so that fields not locked in search mode etc. LMD
                    model = new LabEscModel();
                    dtpDueDate.Format = DateTimePickerFormat.Custom;
                    dtpClosedDate.Format = DateTimePickerFormat.Custom;
                    //dtpClosedDate.Value = emptyDate;
                    //dtpDueDate.Value = emptyDate;

                   
                    break;
                case Mode.LabEscEdit:
                    break;
                case Mode.LabEscDelete:
                    break;
                case Mode.LabEscSearch:
                    btnSave.Text = "Search";
                    dtpDueDate.Format = DateTimePickerFormat.Custom;
                    dtpClosedDate.Format = DateTimePickerFormat.Custom;
                    dtpStartDate.Format = DateTimePickerFormat.Custom;

                    break;
                default:
                    break;
            }
        }
        //private void InputForm_InputDataReady(object sender, InputDataReadyEventArgs, e)
        //{
        //    string searchTerm = e.SearchString;
        //    List<LabEscModel> requests = GlobalConfig.Connection.SearchEscalations(searchTerm.ToUpper());
        //    switch (requests.Count)
        //    {
        //        case 0:
        //            MessageBox.Show("No matching records found");
        //            this.Close();
        //            break;
        //        case 1:
        //            LabEscDisplayModel displayModel = new LabEscModel
        //            break;
        //    }
        //}
        //???NOT SURE IF I NEED THIS OR NOT LMD

        private void clearDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    DateTime newDate = CommonOps.dtpForcedReset(sourceControl as DateTimePicker);
                    DateTimePicker dtp = (DateTimePicker)sourceControl;
                    dtp.Value = newDate;
                }                
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (GV.MODE)
            {
                case Mode.LabEscAdd:
                    //TODO Audit form
                    loadModel(model);
                    GlobalConfig.Connection.LabEsc_CRUD(model, 'C');
                    MessageBox.Show(txtRecordID.Text + " has been saved");
                    break;
                case Mode.LabEscSearch:
                    //loadModel(model);
                    //GlobalConfig.Connection.LabEsc_CRUD(model, 'U');
                    List<FieldSearchModel> models = collectData();
                    string whereClause = "where ";
                    foreach (var model in models)
                    {
                        if(model.FieldName == "Comments"| model.FieldName == "Description")
                        {
                            whereClause = whereClause + model.FieldName + " like '%" + model.FieldValue + "%' and ";
                        }
                        else
                        {
                            whereClause = whereClause + model.FieldName + " = '" + model.FieldValue + "' and ";
                        }
                    }
                    whereClause = whereClause.Substring(0, whereClause.Length - 5);
                    List<LabEscModel> requests = GlobalConfig.Connection.LabEscSearchGen(whereClause);
                    displayResults(requests);
                    break;
                case Mode.LabEscEdit:

                default:
                    break;
            }
        }

        private List<FieldSearchModel> collectData()
        {
            List<FieldSearchModel> fsmList = new List<FieldSearchModel>();
            string mso = cboMSO.Text;
            string endUser = txtEndUser.Text;
            string city = cboCity.Text;
            string state = cboState.Text;
            string country = cboCountry.Text;
            string severity = cboSeverity.Text;
            string requestor = cboRequestor.Text;
            string psNum = txtPSNum.Text;
            string ctrNum = txtCTRNum.Text;
            //bool isEsc = rdoATEsc.;
            //bool isLab = rdoLabReq.;
            string entryAdmin = cboEntryAdmin.Text;
            //DateTime dateOpened = dtpStartDate.Value;
            //DateTime dateDue = dtpDueDate.Value;
            //DateTime dateClosed = dtpClosedDate.Value;
            string eMail = txtEmail.Text;
            string product = lstProducts.Text;
            string leadAssigned = cboLead.Text;
            //int quantity = 000000000000000000000000000000;
            string status = cboStatus.Text;
            string comments = rtxComments.Text;
            string description = rtxDescription.Text;
            string resolution = cboResolution.Text;

            FieldSearchModel fsm = new FieldSearchModel();

            if (mso != "")
            {

                fsm = makeFSM(cboMSO);
                fsmList.Add(fsm);
            }
            if (endUser != "")
            {
                fsm = makeFSM(txtEndUser);
                fsmList.Add(fsm);
            }

            if (city != "")
            {
                fsm = makeFSM(cboCity);
                fsmList.Add(fsm);
            }
            if (state != "")
            {
                fsm = makeFSM(cboState);
                fsmList.Add(fsm);
            }
            if (country != "")
            {
                fsm = makeFSM(cboCountry);
                fsmList.Add(fsm);
            }
            if (severity != "")
            {
                fsm = makeFSM(cboSeverity);
                fsmList.Add(fsm);
            }
            if (requestor != "")
            {
                fsm = makeFSM(cboRequestor);
                fsmList.Add(fsm);
            }
            if (ctrNum != "")
            {
                fsm = makeFSM(txtCTRNum);
                fsmList.Add(fsm);
            }
            if (psNum != "")
            {
                fsm = makeFSM(txtPSNum);
                fsmList.Add(fsm);
            }
            if (entryAdmin != "")
            {
                fsm = makeFSM(cboEntryAdmin);
                fsmList.Add(fsm);
            }
            if (eMail != "")
            {
                fsm = makeFSM(txtEmail);
                fsmList.Add(fsm);
            }
            if (product != "")
            {
                fsm = makeFSM(lstProducts);
                fsmList.Add(fsm);
            }
            if (leadAssigned != "")
            {
                fsm = makeFSM(cboLead);
                fsmList.Add(fsm);
            }
            if (status != "")
            {
                fsm = makeFSM(cboStatus);
                fsmList.Add(fsm);
            }
            if (comments != "")
            {
                fsm = makeFSM(rtxComments);
                fsmList.Add(fsm);
            }
            if (description != "")
            {
                fsm = makeFSM(rtxDescription);
                fsmList.Add(fsm);
            }
            if (resolution != "")
            {
                fsm = makeFSM(cboResolution);
                fsmList.Add(fsm);
            }
            return fsmList;
        }
        private FieldSearchModel makeFSM(Control ctl)
        {
            FieldSearchModel fsm = new FieldSearchModel();
            fsm.FieldName = extractField(ctl.Tag);
            fsm.FieldValue = ctl.Text;
            return fsm;
        }
        private string extractField(object ctlTag)
        {
            string[] tagArray = ctlTag.ToString().Split('|');
            return tagArray[1];
        }
        private void displayResults(List<LabEscModel> models)
        {
            switch (models.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found");
                    break;
                case 1:
                    LabEscModel model = models[0];
                    loadBoxes(model);
                    cboMSO.Focus();
                  //displayAttachments();
                    break;
                default:
                    frmMultiSelect displayForm = new frmMultiSelect();
                    displayForm.Requests = models;
                    displayForm.Show();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillComboBoxes()
        {
            fillComboList<MSO_Model>(cboMSO, "tblMSO", "MSO");
            fillComboList<CityModel>(cboCity, "tblCities", "City");
            fillComboList<StateModel>(cboState, "tblStates", "State");
            fillComboList<CountriesModel>(cboCountry, "tblCountries", "Country");
            fillListList<ProductModel>(lstProducts, "tblProducts", "Product");
            fillComboList<PriorityModel>(cboSeverity, "tblPriorities", "Priority");
            fillComboList<RequestorModel>(cboRequestor, "tblSalespersons", "SalesPerson");
            fillComboList<StatusModel>(cboStatus, "tblStatus", "Status");
            fillComboList<FE_Model>(cboLead, "tblFE", "LastName");
        }

        private void fillComboList<T>(ComboBox cbo, string table, string displayField)
        {
            List<T> data = GlobalConfig.Connection.GenericGetAll<T>(table, displayField);
            cbo.DataSource = data;
            if (displayField != "LastName")
            {
                cbo.DisplayMember = displayField; 
            }
            else
            {
                cbo.DisplayMember = "FullName";
            }
            cbo.SelectedIndex = -1;
        }


        private void fillListList<T>(System.Windows.Forms.ListBox cbo, string table, string displayField)
        {
            List<T> data = GlobalConfig.Connection.GenericGetAll<T>(table, displayField);
            cbo.DataSource = data;
            if (displayField != "LastName")
            {
                cbo.DisplayMember = displayField;
            }
            else
            {
                cbo.DisplayMember = "FullName";
            }
            cbo.SelectedIndex = -1;
        }
        private LabEscModel loadModel(LabEscModel model)
        {
            //LabEscModel model = new LabEscModel();
            //int id = 0;
            //int.TryParse(txtRecordID.Text, out id);
            //model.ID = id;
            model.EscID = txtRecordID.Text;
            model.MSO = cboMSO.Text;
            model.EndUser = txtEndUser.Text;
            model.City = cboCity.Text;
            model.State = cboState.Text;
            model.Country = cboCountry.Text;
            model.Severity = cboSeverity.Text;
            model.Requestor = cboRequestor.Text;
            model.CTRNum = txtCTRNum.Text;
            model.EscNum = txtEscNum.Text;
            model.IsEsc = isEscalation;
            model.EntryAdmin = cboEntryAdmin.Text;
            model.DateOpened = dtpStartDate.Value;
            model.DateDue = dtpDueDate.Value;
            model.DateCompleted = dtpClosedDate.Value;
            model.EMail = txtEmail.Text;
            model.LeadAssigned = cboLead.Text;
            model.Status = cboStatus.Text;
            model.Comments = rtxComments.Text;
            model.Description = rtxDescription.Text;

            if (lstProducts.SelectedIndex > -1)
            {
                ProductModel product = (ProductModel)lstProducts.SelectedItems[0];
                model.Product = product.Product; 
            }

            return model;

        }
        public void loadBoxes(LabEscModel model)
        {
            txtRecordID.Text = model.EscID;
            cboMSO.Text = model.MSO;
            txtEndUser.Text = model.EndUser;
            cboCity.Text = model.City;
            cboState.Text = model.State;
            cboCountry.Text = model.Country;
            cboSeverity.Text = model.Severity;
            cboRequestor.Text = model.Requestor;
            txtCTRNum.Text = model.CTRNum;
            txtEscNum.Text = model.EscNum;
            cboEntryAdmin.Text = model.EntryAdmin;
            dtpStartDate.Value = model.DateOpened;
            dtpDueDate.Value = model.DateDue;
            dtpClosedDate.Value = model.DateCompleted;
            txtEmail.Text = model.EMail;
            //product
            //if (model.product != null)
            //{
            //    FormControlOps.markListBoxes(lstProducts, model.Product)
            //}
            cboLead.Text = model.LeadAssigned;
           // txtQty.Text = model.Quantity; (int)
            cboStatus.Text = model.Status;
            rtxComments.Text = model.Comments;
            rtxDescription.Text = model.Description;
            if (model.IsEsc)
            {
                rdoATEsc.Checked = true;
            }
            else
            {
                rdoLabReq.Checked = true;
            }
            //
            txtPSNum.Text = model.PSNumber;
            //displayAttachments();

        }
        private void makeProductList()
        {

        }
        private void frmLabEsc_Load(object sender, EventArgs e)
        {

        }
        private string serializeProducts(List<ProductModel> products)
        {
            string xmlString;
            List<string> ProductList = new List<string>();
            foreach (var product in lstProducts.SelectedItems)
            {
                ProductModel prod = product as ProductModel;
                ProductList.Add(prod.Product);
            }
            xmlString = Serialization.SerializeToXml<List<string>>(ProductList);
            //assignment.ProductListXML = xmlString;
            return xmlString;
        }
        //private void frmLabEsc_Load(object sender, EventArgs e)            
        //{
        //    // determine type
        //    RadioButton[] buttons = { rdoATEsc, rdoLabReq };
        //    for (int i = 0; i < buttons.Length - 1; i++)
        //    {
        //        if (true)
        //        {
        //            switch (i)
        //            {
        //                case 0:
        //                    isEscalation = true;
        //                    break;
        //                case 1:
        //                    isEscalation = false;
        //                    break;
                    
        //            }
        //        }
        //    }

        //    //load combo lists
        //    List<MSO_Model> models = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
        //    populateCBOList<MSO_Model>(cboMSO, models, "MSO");

        //    List<CityModel> cities = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities", "City");
        //    populateCBOList<CityModel>(cboCity, cities, "City");

        //    List<StateModel> states = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates", "State");
        //    populateCBOList<StateModel>(cboState, states, "State");

        //    List<CountriesModel> countries = GlobalConfig.Connection.GenericGetAll<CountriesModel>("tblCountries", "Country");
        //    populateCBOList<CountriesModel>(cboCountry, countries, "Country");

        //    List<PriorityModel> priorities = GlobalConfig.Connection.GenericGetAll<PriorityModel>("tblPriorities", "Priority");
        //    populateCBOList<PriorityModel>(cboSeverity, priorities, "Priority");

        //    List<RequestorModel> salesPersons = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons", "SalesPerson");
        //    populateCBOList<RequestorModel>(cboRequestor, salesPersons, "Salesperson");

        //    List<AdminModel> admins = GlobalConfig.Connection.GenericGetAll<AdminModel>("tblAdmins", "FullName");
        //    populateCBOList<AdminModel>(cboEntryAdmin, admins, "FullName");

        //    List<FE_Model> FEs = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE", "Last" +
        //        "Name");
        //    populateCBOList<FE_Model>(cboEntryAdmin, FEs, "FullName");
        //}

        private void populateCBOList<T>(ComboBox cbo, List<T> models, string displayMember)
        {
            cbo.DataSource = models;
            cbo.DisplayMember = displayMember;
            cbo.SelectedIndex = -1;
        }

        private void cboMSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GV.MODE == Mode.LabEscAdd && cboMSO.SelectedIndex > 0)
            {
                MSO_Model model = ((MSO_Model)cboMSO.SelectedItem);
                //assignment.MSO_ID = model.ID;
                formDirty = true;
                string PID = PID_Generator.GeneratePID(model);
                txtRecordID.Text = PID;
                CommonOps.lockControls(false, this, "");
                //setLstFe_Enable();

            }
        }

        private void rdoATEsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoATEsc.Checked)
            {
                isEscalation = true;
            }

            else
            {
                isEscalation = false;
            }
        }

        private void rdoLabReq_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLabReq.Checked)
            {
                isEscalation = false;
            }

            else
            {
                isEscalation = true;
            }
        }
        private void setCustomFormat(DateTimePicker dtp)
        {
            DateTime newDate = CommonOps.dtpForcedReset(dtp);
        }
        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            //if (GV.MODE == Mode.LabEscAdd)
            //{
            //    setCustomFormat(dtpDueDate);
            //}
            //else
            //{
                dtpDueDate.Format = DateTimePickerFormat.Long;
            //}
        }

        private void dtpClosedDate_ValueChanged(object sender, EventArgs e)
        {
            //if (GV.MODE == Mode.LabEscAdd)
            //{
            //    setCustomFormat(dtpClosedDate);
            //}
            //else
            //{
                dtpClosedDate.Format = DateTimePickerFormat.Long;
            //}
        }
    }
}
