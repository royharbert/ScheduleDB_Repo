using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        bool formDirty = false;
        bool formLoading = false;
        LabEscModel labEsc;

        DateTime emptyDate = new DateTime(1900, 1, 1);
        DateTime nullDate = new DateTime(0001, 1, 1);
        LabEscModel model = new LabEscModel();
        frmInput inputForm = new frmInput();

        string dtpCustomFormat = " ";

        public LabEscModel LabEsc
        {

            get
            {
                return labEsc;
            }
            set
            {
                labEsc = value;
                btnSave.Text = "Save";
                GV.MODE = Mode.LabEscEdit;
                loadBoxes(labEsc);
                getAttachments(labEsc.EscID);
                this.BringToFront();
            }
        }

        public frmLabEsc()
        {
            InitializeComponent();
        }
        private void frmLabEsc_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
            FC.SetFormPosition(this);
            dtpClosedDate.CustomFormat = dtpCustomFormat;
            dtpDueDate.CustomFormat = dtpCustomFormat;
            dtpStartDate.CustomFormat = dtpCustomFormat;

            switch (GV.MODE)
            {
                case Mode.LabEscAdd:
                    txtRecordID.Clear();
                    cboRecType.Enabled = true;
                    cboMSO.Enabled = true;
                    CommonOps.lockControls(true, this, "cboRecType");
                    model = new LabEscModel();
                    dtpClosedDate.Format = DateTimePickerFormat.Custom;
                    txtEntryAdmin.Text = GV.USERMODEL.FullName;
                    btnSave.Text = "Save";
                    formLoading = false;
                    cboStatus.SelectedIndex = 1;
                    break;
                case Mode.LabEscEdit:
                    getAttachments(model.EscID);
                    btnSave.Text = "Save";
                    break;
                case Mode.LabEscDelete:
                    CommonOps.lockControls(true, this, "");
                    btnSave.Text = "Delete";
                    getAttachments(model.EscID);

                    break;
                case Mode.LabEscSearch:
                    CommonOps.lockControls(false, this, "");
                    txtRecordID.Focus();
                    dtpClosedDate.Format = DateTimePickerFormat.Custom;
                    dtpDueDate.Format = DateTimePickerFormat.Custom;
                    dtpStartDate.Format = DateTimePickerFormat.Custom;
                    dtpStartDate.Enabled = false;
                    dtpDueDate.Enabled = false;
                    dtpClosedDate.Enabled = false;
                    btnSave.Text = "Search";
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
                //changes status back to open if date completed is cleared LMD 2-21-23
                if (dtpClosedDate.Value == emptyDate)
                {
                    cboStatus.SelectedIndex = 1;
                }
            }
        }

        private void saveData()
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
                                cboRecType.Enabled = false;
                                cboMSO.Enabled = false;
                                break;
                            case Mode.LabEscEdit:
                                GlobalConfig.Connection.LabEsc_CRUD(model, 'U');
                                break;
                            case Mode.LabEscDelete:
                                model = GlobalConfig.Connection.LabEsc_CRUD(model, 'D');
                                break;

                        }

                        MessageBox.Show(txtRecordID.Text + " has been saved");
                        formDirty = false;
                        GV.MODE = Mode.LabEscEdit;
                    }
                    else
                    {
                        errorList = errorList + "\r\n\r\n Project not saved.";
                        MessageBox.Show(errorList);
                    }
                    break;

                case Mode.LabEscSearch:
                    //List<FieldSearchModel> models = collectData();
                    //string whereClause = "where ";
                    //foreach (var model in models)
                    //{
                    //    if (model.FieldName == "Comments" | model.FieldName == "Description" | model.FieldName == "PSNumber" | model.FieldName == "Resolution"
                    //        | model.FieldName == "CTRNum" | model.FieldName == "EscNum" | model.FieldName == "EscID")
                    //    {
                    //        whereClause = whereClause + model.FieldName + " like '%" + model.FieldValue + "%' and ";
                    //    }
                    //    else
                    //    {
                    //        whereClause = whereClause + model.FieldName + " = '" + model.FieldValue + "' and ";
                    //    }
                    //}
                    //whereClause = whereClause.Substring(0, whereClause.Length - 5);
                    //List<LabEscModel> requests = GlobalConfig.Connection.LabEscSearchGen(whereClause);
                    //displayResults(requests);
                    //formDirty = false;
                    //this.Close();

                    //break;

                    List<FieldSearchModel> models = collectData();
                    string whereClause = "where ";
                    foreach (var model in models)
                    {
                        if (model.FieldName == "Comments" | model.FieldName == "Description" | model.FieldName == "PSNumber" | model.FieldName == "Resolution"
                            | model.FieldName == "CTRNum" | model.FieldName == "EscNum" | model.FieldName == "EscID")
                        {
                            whereClause = whereClause + " upper(" + model.FieldName + ") like  upper('%" + model.FieldValue + "%') and ";
                        }
                        else if(model.FieldName == "Products")
                        {
                            whereClause = whereClause + " upper(" + model.FieldName + ") like  upper('%" + lstProducts.SelectedItem.ToString() + "%') and ";
                        }
                        else
                        {
                            whereClause = whereClause + " upper(" + model.FieldName + ") like  upper('%" + model.FieldValue + "%') and ";
                        }
                    }
                    whereClause = whereClause.Substring(0, whereClause.Length - 5);                    
                    List<LabEscModel> requests = GlobalConfig.Connection.LabEscSearchGen(whereClause);
                    displayResults(requests);
                    formDirty = false;
                    this.Close();

                    break;
                default:
                    break;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();            
        }

        public void setBtnSaveText(string text)
        {
            btnSave.Text = text;
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
            string escNum = txtEscNum.Text;
            string ctrNum = txtCTRNum.Text;
            string entryAdmin = txtEntryAdmin.Text;
            string product = lstProducts.Text;
            string leadAssigned = cboLead.Text;
            int quantity = 0;
            int.TryParse(txtQty.Text, out quantity);
            string status = cboStatus.Text;
            string comments = rtxComments.Text;
            string description = rtxDescription.Text;
            string resolution = cboResolution.Text;
            string recordType = cboRecType.Text;
            string escId = txtRecordID.Text;

            FieldSearchModel fsm = new FieldSearchModel();
            if (txtRecordID.Text != "")
            {
                fsm = makeFSM(txtRecordID);
                fsmList.Add(fsm);
            }

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
            if (escNum != "")
            {
                fsm = makeFSM(txtEscNum);
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
            if (recordType != "")
            {
                fsm = makeFSM(cboRecType);
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
                    escForm.setBtnSaveText("Save");
                    cboMSO.Focus();
                    escForm.BringToFront();
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
            formLoading = true;
            fillComboList<MSO_Model>(cboMSO, "tblMSO", "MSO", "MSO");
            fillComboList<CityModel>(cboCity, "tblCities", "City", "City");
            fillComboList<StateModel>(cboState, "tblStates", "State", "State");
            fillComboList<CountriesModel>(cboCountry, "tblCountries", "Country", "ID");
            fillListList<ProductModel>(lstProducts, "tblProducts", "Product", "Product");
            fillComboList<PriorityModel>(cboSeverity, "tblPriorities", "Priority", "Priority");
            fillComboList<PersonModel>(cboRequestor, "tblEscRequestors", "FullName", "LastName");
            fillComboList<StatusModel>(cboStatus, "tblStatus", "Status", "Status");
            fillComboList<PersonModel>(cboLead, "tblEscLeads", "FullName", "LastName");
            fillComboList<ResolutionModel>(cboResolution, "tblResolutions", "ResolutionType", "ResolutionType");

            cboRecType.Items.Add("AT Escalation");
            cboRecType.Items.Add("Lab Request");

        }

        private void fillComboList<T>(ComboBox cbo, string table, string displayField, string orderByCol)
        {
            List<T> data = GlobalConfig.Connection.GenericGetAll<T>(table, orderByCol);
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


        private void fillListList<T>(System.Windows.Forms.ListBox cbo, string table, string displayField, string orderByField)
        {
            List<T> data = GlobalConfig.Connection.GenericGetAll<T>(table, orderByField);
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
            int quantity = 0;
            int.TryParse(txtQty.Text, out quantity);
            model.Quantity = quantity;
            model.Requestor = cboRequestor.Text;
            model.CTRNum = txtCTRNum.Text;
            model.EscNum = txtEscNum.Text;
            if (GV.MODE == Mode.LabEscAdd | GV.MODE == Mode.LabEscEdit) 
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
            model.PSNumber = txtPSNum.Text;
            model.LeadAssigned = cboLead.Text;
            model.Status = cboStatus.Text;
            model.Comments = rtxComments.Text;
            model.Description = rtxDescription.Text;
            model.Resolution = cboResolution.Text;
            model.RecordType = cboRecType.Text;

            if (lstProducts.SelectedIndex > -1)
            {
                ProductModel product = (ProductModel)lstProducts.SelectedItems[0];
                model.Product = product.Product; 
            }

            return model;

        }
        /// <summary>
        /// Sets formLoading flag to true, populates boxes with data and sets formloading back to false when done
        /// </summary>
        /// <param name="model"></param>
        public void loadBoxes(LabEscModel model)
        {
            formLoading = true;
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
            if (model.DateDue != emptyDate)
            {
                dtpDueDate.Format = DateTimePickerFormat.Long;
                dtpDueDate.Value = model.DateDue; 
            }
            //fixes date closed note populating in report 2-21-23 LMD
            if (model.DateCompleted == emptyDate | model.DateCompleted == nullDate)
            {
                dtpClosedDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtpClosedDate.Format = DateTimePickerFormat.Long;
                dtpClosedDate.Value= model.DateCompleted;
            }
            txtEntryAdmin.Text = model.EntryAdmin;
            cboLead.Text = model.LeadAssigned;
            txtQty.Text = model.Quantity.ToString(); 
            cboStatus.Text = model.Status;
            rtxComments.Text = model.Comments;
            rtxDescription.Text = model.Description;
            cboRecType.Text = model.RecordType;
            cboResolution.Text = model.Resolution;
            txtPSNum.Text = model.PSNumber;
            txtID.Text = model.ID.ToString();
            txtEntryAdmin.Text = model.EntryAdmin;

            //highlight product
            int idx = highlightProductList(model.Product);
            lstProducts.SelectedIndex = idx;

            //display attachments
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(model.EscID);
            dgvAttachments.DataSource = null;
            dgvAttachments.DataSource = aList;
            formatAttGrid();
            GV.MODE = Mode.LabEscEdit;
            formLoading = false;
            formDirty = false;
        }
        private int highlightProductList(string selectedProduct)
        {
            int idx = -1;
            foreach (var model in lstProducts.Items)
            {
                idx++;
                ProductModel product = model as ProductModel;
                if (product != null) 
                {
                    if (selectedProduct == product.Product)
                    {
                        break;
                    }
                }

            }
            return idx;
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
            if (GV.MODE == Mode.LabEscAdd && cboMSO.SelectedIndex > -1 && cboRecType.Text != "" && txtRecordID.Text == "")
            {
                MSO_Model model = ((MSO_Model)cboMSO.SelectedItem);
                formDirty = true;
                string PID = PID_Generator.GeneratePID(model, cboRecType.Text);
                txtRecordID.Text = PID;
                CommonOps.lockControls(false, this, "");
                //txtRecordID.Enabled = false;
                cboRecType.Enabled = false;
                cboMSO.Enabled= false;
                GV.MODE = Mode.LabEscAdd;
            }
        }

        private void setCustomFormat(DateTimePicker dtp)
        {
            DateTime newDate = CommonOps.dtpForcedReset(dtp);
        }

        private void dtpCommon_ValueChanfedEvent(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            if (dtp.Value == emptyDate | dtp.Value == null)
            {
                dtp.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtp.Format = DateTimePickerFormat.Long;
            }
        }

        private void controlTextChangedSharedEvent(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                formDirty = true;
            }
        }

        private void cboRequestor_Leave(object sender, EventArgs e)
        {
            updatePersonTable(cboRequestor, "tblEscRequestors");
        }

        private void addPerson(ComboBox cbo, string tableName)
        {
            string[] nameArray = AddPersonToDropdownList.ParsePerson(cbo, cbo.Text);
            string fullName = nameArray[0] + " " + nameArray[1];
            int idx = cbo.FindString(fullName);
            if (idx == -1)
            {
                frmAddPerson personForm = new frmAddPerson();
                personForm.FirstName = nameArray[0];
                personForm.LastName = nameArray[1];
                personForm.ActiveTable = tableName;
                personForm.ShowDialog();
            }
        }

        private void updatePersonTable(ComboBox cbo, string tableName)
        {
            // break entry into fname and lname
            string name = cbo.Text;
            int curIdx = cbo.SelectedIndex;
            if (name != "" && cbo.SelectedIndex == -1)
            {
                PersonModel model = new PersonModel();
                
                addPerson(cbo, tableName);
                fillComboList<PersonModel>(cbo, tableName, "FullName", "LastName");
            }
            if (cbo.SelectedIndex != -1)
            {
                cbo.SelectedIndex = curIdx;
            }
            else
            {
                cbo.Text = name;
            }
        }

        private void cboLead_Leave(object sender, EventArgs e)
        {
            updatePersonTable(cboLead, "tblEscLeads");
        }

        private void Frm_TypeReadyEvent(object sender, AttachmentModel e)
        {
            string fileName = GlobalConfig.AttachmentPath + "\\" + e.PID + "\\" + e.DisplayText;
            FileOps.SaveAttFile(e);
            GlobalConfig.Connection.InsertInto_tblAttachments(e);
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(e.PID);
            dgvAttachments.DataSource = null;
            dgvAttachments.DataSource = aList;
            btnSave.Text = "Save";
            formatAttGrid();
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

        private List<AttachmentModel> getAttachments(string pid)
        {
            List<AttachmentModel> att = GlobalConfig.Connection.GetAttachments(pid);
            dgvAttachments.DataSource = att;
            formatAttGrid();
            return att;
        }

        private void btnAddAttach_Click(object sender, EventArgs e)
        {
            var origMode = GV.MODE;
            GV.MODE = Mode.Add_Attachment;
            AttachmentModel model = new AttachmentModel();
            frmAttType frm = new frmAttType(model);
            frm.TypeReadyEvent += Frm_TypeReadyEvent;

            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Save Attachment";
            string myDox = Environment.SpecialFolder.MyDocuments.ToString();
            openFD.InitialDirectory = myDox;
            openFD.RestoreDirectory = true;
            openFD.Multiselect = false;

            model.ID = 0;
            model.PID = txtRecordID.Text;

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
            GV.MODE= origMode;
            frm.TypeReadyEvent -= Frm_TypeReadyEvent;
        }

        private void btnRemoveAttach_Click(object sender, EventArgs e)
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

        private void dgvAttachments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AttachmentProcs.AttachmentsRowHeaderClick(dgvAttachments);
        }

        private void cboRecType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtRecordID.Text != "")
            {
                string EID = txtRecordID.Text;
                if (EID.Substring(0,3) == "LAB" & !formLoading)
                {
                    txtRecordID.Text = EID.Replace("LAB", "ESC");
                    model.RecordType = "AT Escalation";
                }
                else
                {
                    txtRecordID.Text = EID.Replace("ESC", "LAB");
                    model.RecordType = "Lab Request";
                }
            }
        }

        private void frmLabEsc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formDirty)
            {
                DialogResult reply = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
                if (reply == DialogResult.Yes)
                {
                    saveData();
                }
                
            }
        }

        private void calculateDateDue()
        {
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            DateTime dueDate = emptyDate;
            if (cboSeverity.Text != "" & dtpStartDate.Text != "" & !formLoading)
            {
                dueDate = CommonOps.CalculateDateDue(dtpStartDate.Value, cboSeverity.Text);
                dtpDueDate.Format = DateTimePickerFormat.Long;
            }
            dtpDueDate.Value = dueDate;
        }

        private void cboSeverity_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateDateDue();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            calculateDateDue();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct npForm= new frmAddProduct();
            npForm.StartPosition = FormStartPosition.CenterScreen;
            npForm.ShowDialog();
            List<ProductModel> products = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts", "Product");
            lstProducts.DataSource = products;
            lstProducts.DisplayMember = "Product";
        }

        private void dtpClosedDate_ValueChanged(object sender, EventArgs e)
        {
            //changes status apporopriately with closed date change
            if (model.DateCompleted == emptyDate)
            {
                dtpClosedDate.Format = DateTimePickerFormat.Custom;
                cboStatus.SelectedIndex = 1;
            }
            else
            {
                dtpClosedDate.Format = DateTimePickerFormat.Long;
                cboStatus.SelectedIndex = 0;
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRecordID_TextChanged(object sender, EventArgs e)
        {
            if (! formLoading)
            {
                //GV.MODE = Mode.LabEscEdit;
                formDirty = true;
            }
        }

        private void cboRecType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboMSO.Enabled= true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
