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
    public partial class FrmATEscalations : Form
    {
        DateTime emptyDate = new DateTime(1900, 1, 1);
        ATEscalationsModel ATEscalation = new ATEscalationsModel();
        List<string> productList = new List<string>();
        List<string> LeadFE = new List<string>();
        private bool dataLoading = false;
        private bool formDirty = false;
        frmInput inputForm = new frmInput();

        public FrmATEscalations()
        {
            formDirty = false;
            dataLoading = true;
            InitializeComponent();
            GV.ESCALATIONFORM = this;
            fillComboLists();
            makeLeadList();
            makeProductList();
            enableBoxes(false);
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.AddEscalation:
                    dataLoading = false;
                    cbo_MSO.Enabled = true;
                    btn_Save.Enabled = false;
                    break;
                case Mode.SearchEscalation:
                    inputForm.InputDataReady += InputForm_InputDataReady;
                    inputForm.Show();  
                    enableBoxes(true);
                    break;
                case Mode.DeleteEscalation:
                    break;
                default:
                    break;
            }
            dataLoading = false;
        }
        private void enableBoxes(bool enabled)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    TextBox box = (TextBox)ctl;
                    if (box.Tag.ToString() == "L")
                    {
                        ctl.Enabled = enabled;
                    }
                }
                if (ctl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctl;
                    if (comboBox.Tag.ToString() == "L")
                    {
                        comboBox.Enabled = enabled;
                    }
                }
                if (ctl is ListBox)
                {
                    ListBox listBox = (ListBox)ctl;
                    if (listBox.Tag.ToString() == "L")
                    {
                        listBox.Enabled = enabled;
                    }
                }
                if (ctl is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)ctl;
                    if (datePicker.Tag.ToString() == "L")
                    {
                        datePicker.Enabled = enabled;
                    }
                }
                if (ctl is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)ctl;
                    if (groupBox.Tag.ToString() == "L")
                    {
                        groupBox.Enabled = enabled;
                    }
                }
            }

        }
          


        //added 12-13-21 LMD
        //clear controls
        //resettextandcomboboxesandDTP
        //clear list box
        private void clearControls()
        {
            dataLoading = true;
        }
        private void resetDTP_CustomFormat(DateTimePicker picker)
        {
            picker.CustomFormat = "  ";
            picker.Format = DateTimePickerFormat.Custom;
            picker.Text = "";
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
        private void clearDate(DateTimePicker dtp)
        {
            dtp.Value = new DateTime(1900,1,1);
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
        }
        private void InputForm_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            string searchTerm = e.SearchString;
            List<ATEscalationsModel> escalations = GlobalConfig.Connection.SearchEscalations(searchTerm.ToUpper());
            switch (escalations.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found.");
                    this.Close();
                    break;
                case 1:
                    ATEscalationsDisplayModel displayModel = new ATEscalationsDisplayModel(escalations[0]);
                    dataLoading = true;
                    loadBoxes(displayModel);
                    break;
                default:
                    frmMultiSelect displayForm = new frmMultiSelect();
                    List<ATEscalationsDisplayModel> displayModels = convertToDisplayList(escalations);
                    displayForm.Escalations = displayModels;
                    displayForm.Show();
                    break;
            }
        }

        private List<ATEscalationsDisplayModel> convertToDisplayList(List<ATEscalationsModel> lst)
        {
            List<ATEscalationsDisplayModel> returnList = new List<ATEscalationsDisplayModel>();
            foreach (var escalation in lst)
            {
                returnList.Add( new ATEscalationsDisplayModel(escalation));
            }
            return returnList;
        }

        private void fillComboLists()
        {
            List<MSO_Model> MSOs = GlobalConfig.Connection.GenericConditionalGetAll<MSO_Model>("tblMSO", "Active","1", "MSO");
            cbo_MSO.DataSource = MSOs;
            cbo_MSO.DisplayMember = "MSO";
            cbo_MSO.SelectedIndex = -1;

            cbo_Type.Items.Add("Product");
            cbo_Type.Items.Add("Application");
            cbo_Type.Items.Add("Design");

            cbo_Status.Items.Add("Open");
            cbo_Status.Items.Add("Closed");
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadBoxes(ATEscalationsDisplayModel model)
        {
            txtEID.Text = model.EscalationID;       
            txt_Comments.Text = model.Comments;
            txt_CTRNumber.Text = model.CTRNumber;
            txt_Description.Text = model.ATEDescription;
            txt_PSNumber.Text = model.PeopleSoftNumber;
            txt_Qty.Text = model.Quantity.ToString();
            txt_Resolution.Text = model.Resolution;
            cbo_MSO.Text = model.MSO;
            cbo_Status.Text = model.ATEStatus;
            cbo_Type.Text = model.ATEType;
            txtEndUser.Text = model.EndUser;
            if (model.Product != null)
            {
                FormControlOps.markListBoxes(lst_PartNumber, model.Product); 
            }
            dtp_DateReported.Value = model.DateReported;
            dtp_DateResolved.Value = model.ResolvedDate;
            if(model.FELead != null)

            {
                FormControlOps.markListBoxes(lst_FELead, model.FELead); 
            }
            displayAttachments();
        }

        public void makeProductList()
        {
            List<ProductModel> products = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts", "Product");
            lst_PartNumber.DataSource = products;
            lst_PartNumber.DisplayMember = "Product";
            lst_PartNumber.SelectedIndex = -1;
        }

        private void makeLeadList()
        {
            List<FE_Model> lead = GlobalConfig.Connection.GetItemByColumn<FE_Model>("tblFE",
                "Active", "", 1);
            lst_FELead.DataSource = lead;
            lst_FELead.DisplayMember = "FullName";
            lst_FELead.SelectedIndex = -1;
        }


        private string collectLeads()
        {
            string xmlString = "";
            if (!dataLoading)
            {
                foreach (var item in lst_FELead.SelectedItems)
                {
                    FE_Model lead = (FE_Model)item;
                    LeadFE.Add(lead.FirstName);

                }
                xmlString = Serialization.SerializeToXml<List<string>>(LeadFE);

            }
            return xmlString;
        }
        private string collectProducts()
        {
            string xmlString = "";
            if (!dataLoading)
            {
                foreach (var item in lst_PartNumber.SelectedItems)
                {
                    ProductModel product = (ProductModel)item;
                    productList.Add(product.Product);
                }
                xmlString = Serialization.SerializeToXml<List<string>>(productList);
            }
            return xmlString;
        }
        private bool auditSuccess()
        {
            bool success = true;
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString().ToUpper().Contains("REQUIRED"))
                {
                    if (control.Text == "")
                    {
                        success = false;
                        MessageBox.Show("Please enter data in all required fields");
                        break;
                    }
                }
            }
            return success;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (auditSuccess())
            {
                ATEscalationsModel model = new ATEscalationsModel();
                model.EscalationID = txtEID.Text;
                model.Product = collectProducts();
                model.FELeadXML = collectLeads();
                model.ATEDescription = txt_Description.Text;
                model.ATEStatus = cbo_Status.Text;
                model.ATEType = cbo_Type.Text;
                model.Comments = txt_Comments.Text;
                model.CTRNumber = txt_CTRNumber.Text;
                model.DateReported = dtp_DateReported.Value;
                if (GV.MODE == Mode.AddEscalation)
                {
                    model.ResolvedDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
                }
                else
                {
                    model.ResolvedDate = dtp_DateResolved.Value; 

                }
                model.MSO = cbo_MSO.Text;
                model.Quantity = txt_Qty.Text;
                model.Resolution = txt_Resolution.Text;
                model.PeopleSoftNumber = txt_PSNumber.Text;
                ScheduleDatabaseClassLibrary.TableOps.TableGenerator<ATEscalationsModel> dt =
                    new ScheduleDatabaseClassLibrary.TableOps.TableGenerator<ATEscalationsModel>();
                model.EndUser = txtEndUser.Text;
                List<ATEscalationsModel> escalations = new List<ATEscalationsModel>();
                escalations.Add(model);
                dt.List = escalations;
                int success = 0;
                switch(GV.MODE)
                {
                    case Mode.AddEscalation:
                        success = GlobalConfig.Connection.Escalations_Add(dt.table);

                        break;
                    case Mode.SearchEscalation:
                        success = GlobalConfig.Connection.Escalation_Update(dt.table);
                        break;

                }
                if (success > 0)
                {
                    MessageBox.Show(model.EscalationID + " saved.");
                    btn_Save.Enabled = false;
                } 
            }
        }

        private void cbo_MSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dataLoading)
            {

                MSO_Model model = ((MSO_Model)cbo_MSO.SelectedItem);
               formDirty = true;
                enableBoxes(true);
                if (sender is ComboBox)
                {
                    ComboBox ctl = (ComboBox)sender;

                    if (ctl.Name == "cbo_MSO")
                    {
                        txtEID.Text = PID_Generator.GenerateEID((MSO_Model)cbo_MSO.SelectedItem, "ESC_", dataLoading);
                        cbo_MSO.Enabled = false;
                    }

                }
            }
        }

        private void dtp_DateResolved_ValueChanged_1(object sender, EventArgs e)
        {
            if(dtp_DateResolved.Value == emptyDate)
            {
                clearDate((DateTimePicker)sender);
               
            }
            else 
            { 
              dtp_DateResolved.Format = DateTimePickerFormat.Short;
            }
        }

        private void txtEID_TextChanged(object sender, EventArgs e)
        {
            if (txtEID.Text.Length > 0)
            {
                btn_Save.Enabled = true;
            }
        }

        private void FrmATEscalations_Shown(object sender, EventArgs e)
        {
            if (GV.MODE == Mode.SearchEscalation)
            {
                inputForm.BringToFront();
            }
        }

        private void displayAttachments()
        {
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(txtEID.Text);
            dgvAttachments.DataSource = null;
            dgvAttachments.DataSource = aList;
            if(aList.Count > 0)
            {
                formatAttGrid();
            }
        }

        private void btn_AddAttachment_Click(object sender, EventArgs e)
        {
            string[] labels = { "Design Drawing", "E-Mail Chain", "Equipment List", "Lab Report", "Data Log", "Other" };
            List<AttachmentModel> models = AttachmentProcs.AttachFile(this, txtEID.Text, labels);
            displayAttachments();
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

        private void btn_RemoveAttachment_Click(object sender, EventArgs e)
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

        private void FrmATEscalations_Activated(object sender, EventArgs e)
        {
            switch (GV.MODE)
            {
                case Mode.New:
                    clearControls();
                    //lockControls(true, "cboMSO");
                    break;
                case Mode.Edit:
                    break;
                case Mode.Undo:
                case Mode.None:
                    break;
                default:
                    break;
            }
        }

        private void lst_PartNumber_Leave(object sender, EventArgs e)
        {
            if (lst_PartNumber.SelectedIndex < 0)
            {
                string newProduct = lst_PartNumber.Text.ToUpper();
                frmAddProduct ProductForm = new frmAddProduct();
                ProductForm.Product = lst_PartNumber.Text;
                ProductForm.ShowDialog();
                lst_PartNumber.Text = newProduct;
            }
        }

        private void clearDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)contextMenuStrip1.SourceControl;
            clearDate(dtp);
        }

        private void FrmATEscalations_Load(object sender, EventArgs e)
        {

        }
    }
}



