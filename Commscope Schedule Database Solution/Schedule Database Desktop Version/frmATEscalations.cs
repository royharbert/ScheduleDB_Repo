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
            fillComboLists();
            makeProductList();
            makeLeadList();
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
                    
                    break;
                case Mode.DeleteEscalation:
                    break;
                case Mode.DateRangeReport:
                    break;
                case Mode.Edit:
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
                case Mode.Add_Attachment:
                    break;
                case Mode.Delete_Attachment:
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }

        private void InputForm_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            string searchTerm = e.SearchString;
            List<ATEscalationsModel> escalations = GlobalConfig.Connection.SearchEscalations(searchTerm.ToUpper());
            switch (escalations.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found.");
                    break;
                case 1:
                    ATEscalationsDisplayModel displayModel = new ATEscalationsDisplayModel(escalations[0]);
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
            List<MSO_Model> MSOs = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO");
            cbo_MSO.DataSource = MSOs;
            cbo_MSO.DisplayMember = "MSO";
            cbo_MSO.SelectedIndex = -1;

            List<ProductModel> products = GlobalConfig.Connection.GenericOrderedGetAll<ProductModel>("tblProducts", "Product");
            cboProduct.DataSource = products;
            cboProduct.DisplayMember = "Product";
            cboProduct.SelectedIndex = -1;

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
            cboProduct.Text = model.Product;
            dtp_DateReported.Value = model.DateReported;
            dtp_DateResolved.Value = model.ResolvedDate;
            FormControlOps.markListBoxes(lst_FELead, model.FELead);
            displayAttachments();
        }

        private void makeProductList()
        {
            List<ProductModel> products = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
            cboProduct.DataSource = products;
            cboProduct.DisplayMember = "Product";
            cboProduct.SelectedIndex = -1;
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            ATEscalationsModel model = new ATEscalationsModel();
            model.EscalationID = txtEID.Text;
            model.Product = cboProduct.Text;
            model.FELeadXML = collectLeads();
            model.ATEDescription = txt_Description.Text;
            model.ATEStatus = cbo_Status.Text;
            model.ATEType = cbo_Type.Text;
            model.Comments = txt_Comments.Text;
            model.CTRNumber = txt_CTRNumber.Text;
            model.DateReported = dtp_DateReported.Value;
            model.ResolvedDate = dtp_DateResolved.Value;
            model.MSO = cbo_MSO.Text;
            model.Quantity = txt_Qty.Text;
            model.Resolution = txt_Resolution.Text;
            model.PeopleSoftNumber = txt_PSNumber.Text;
            ScheduleDatabaseClassLibrary.TableOps.TableGenerator<ATEscalationsModel> dt =
                new ScheduleDatabaseClassLibrary.TableOps.TableGenerator<ATEscalationsModel>();
            List<ATEscalationsModel> escalations = new List<ATEscalationsModel>();
            escalations.Add(model);
            dt.List = escalations;
            int success = GlobalConfig.Connection.Escalations_Add(dt.table);
            if (success > 0)
            {
                MessageBox.Show(model.EscalationID + " saved.");
                btn_Save.Enabled = false;
            }
        }

        private void cbo_MSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dataLoading)
            {
                formDirty = true;
                if (sender is ComboBox)
                {
                    ComboBox ctl = (ComboBox)sender;

                    if (ctl.Name == "cbo_MSO")
                    {
                        txtEID.Text = PID_Generator.GenerateEID((MSO_Model)cbo_MSO.SelectedItem);
                        cbo_MSO.Enabled = false;
                    }
                }
            }
        }

        private void dtp_DateResolved_ValueChanged_1(object sender, EventArgs e)
        {
            dtp_DateResolved.Format = DateTimePickerFormat.Short;
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

        private void cboProduct_Leave(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex < 0)
            {
                frmAddProduct ProductForm = new frmAddProduct();
                ProductForm.Product = cboProduct.Text;
                ProductForm.ShowDialog();
            }
        }
    }
}



