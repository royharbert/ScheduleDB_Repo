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

        string dtpCustomFormat = " ";
        
        public frmLabEsc()
        {
            InitializeComponent();
        }
        private void frmLabEsc_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
            dtpClosedDate.CustomFormat = dtpCustomFormat;
            dtpDueDate.CustomFormat = dtpCustomFormat;

            switch (GV.MODE)
            {
                case Mode.LabEscAdd:
                    CommonOps.lockControls(true, this, "cboMSO");
                    model = new LabEscModel();
                    dtpClosedDate.Format = DateTimePickerFormat.Custom;
                    break;
                case Mode.LabEscEdit:
                    break;
                case Mode.LabEscDelete:
                    break;
                case Mode.LabEscSearch:
                    CommonOps.lockControls(false, this, "cboMSO");
                    break;
                default:
                    break;
            }
        }
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
            string errorList = "";
            loadModel(model);
            errorList = auditData();
            switch (GV.MODE)
            {
                case Mode.LabEscAdd:
                case Mode.LabEscEdit:

                    if (errorList.Length == 0)
                    {
                        switch (GV.MODE)
                        {
                            case Mode.LabEscAdd:
                                model = GlobalConfig.Connection.LabEsc_CRUD(model, 'C');
                                loadBoxes(model);
                                txtID.Text = model.ID.ToString();
                                break;
                            case Mode.LabEscEdit:
                                GlobalConfig.Connection.LabEsc_CRUD(model, 'U');
                                break;

                        }

                        MessageBox.Show(txtRecordID.Text + " has been saved");
                        GV.MODE = Mode.LabEscEdit;
                    }
                    else
                    {
                        errorList = errorList + "\r\n\r\n Project not saved.";
                        MessageBox.Show(errorList);
                    }
                    break;

                case Mode.LabEscSearch:
                    //loadModel(model);
                    //GlobalConfig.Connection.LabEsc_CRUD(model, 'U');
                    List<FieldSearchModel> models = collectData();
                    string whereClause = "where ";
                    foreach (var model in models)
                    {
                        if(model.FieldName == "Comments"| model.FieldName == "Description") //add all textbox
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
            string entryAdmin = txtEntryAdmin.Text;
            //DateTime dateOpened = dtpStartDate.Value;
            //DateTime dateDue = dtpDueDate.Value;
            //DateTime dateClosed = dtpClosedDate.Value;
            string product = lstProducts.Text;
            string leadAssigned = cboLead.Text;
            int quantity = 0;
            int.TryParse(txtQty.Text, out quantity);
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
                fsm = makeFSM(txtEntryAdmin);
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
            return tagArray[0];
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
                    frmLabEsc escForm = new frmLabEsc();
                    escForm.Show();
                    escForm.loadBoxes(model);
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

        private string auditData()
        {
            string errorList = "";

            if (!rdoATEsc.Checked && !rdoLabReq.Checked)
            {
                errorList = errorList + "Esclation/Lab Request not selected" + Environment.NewLine;
            }
            if (model.EscID == "")
            {
                errorList = errorList + "Request number not assigned" + Environment.NewLine;
            }
            if (model.Requestor == "")
            {
                errorList = errorList + "Requestor name not assigned" + Environment.NewLine;
            }
            if (model.Product == "")
            {
                errorList = errorList + "Product not selected" + Environment.NewLine;
            }
            if (model.Severity == "")
            {
                errorList = errorList + "Severity not assigned" + Environment.NewLine;
            }


            return errorList;
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
            int id = -1;
            int.TryParse(txtID.Text, out id);
            txtID.Text = id.ToString();
            model.ID = id;
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
            if (GV.MODE == Mode.LabEscAdd)
            {
                model.EntryAdmin = GV.USERMODEL.FullName;
                model.DateOpened = dtpStartDate.Value;
                model.DateDue = dtpDueDate.Value;
                model.DateCompleted = emptyDate;
            }
            else
            {
                model.DateOpened = dtpStartDate.Value;
                model.DateDue = dtpDueDate.Value;
                if (dtpClosedDate.Format == DateTimePickerFormat.Custom)
                {
                    model.DateCompleted = emptyDate;
                }
                else
                { 
                    model.DateCompleted = dtpClosedDate.Value; 

                }
            }
           
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
            txtEntryAdmin.Text = model.EntryAdmin;
            dtpStartDate.Value = model.DateOpened;
            dtpDueDate.Value = model.DateDue;
            dtpClosedDate.Value = model.DateCompleted;
            txtEntryAdmin.Text = model.EntryAdmin;
            cboLead.Text = model.LeadAssigned;
            txtQty.Text = model.Quantity.ToString(); 
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
            txtID.Text = model.ID.ToString();
            //displayAttachments();

        }
        private void makeProductList()
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
                formDirty = true;
                string PID = PID_Generator.GeneratePID(model);
                txtRecordID.Text = PID;
                CommonOps.lockControls(false, this, "");
            }
        }

        private void rdoATEsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoATEsc.Checked)
            {
                isEscalation = true;
                txtEscNum.Enabled = false;
            }

            else
            {
                isEscalation = false;
                txtEscNum.Enabled = true;
            }
        }

        private void rdoLabReq_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLabReq.Checked)
            {
                isEscalation = false;
                txtEscNum.Enabled = true;
            }

            else
            {
                isEscalation = true;
                txtEscNum.Enabled= false;
            }
        }

        private void dtpClosedDate_ValueChanged(object sender, EventArgs e)
        {
            if (GV.MODE == Mode.LabEscAdd)
            {
                dtpClosedDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtpClosedDate.Format = DateTimePickerFormat.Long;
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
    }
}
