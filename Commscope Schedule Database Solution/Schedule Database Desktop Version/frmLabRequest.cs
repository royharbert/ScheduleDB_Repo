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
    public partial class frmLabRequest : Form
    {
        DateTime emptyDate = new DateTime(1900, 1, 1);
        bool dataLoading = true;
        bool formDirty = false;
        LabRequestModel labRequest = null;
        frmInput inputForm = new frmInput();
        public LabRequestModel LabRequest
        {
            get
            {
                return labRequest;
            }
            set
            {
                labRequest = value;
                loadBoxes(labRequest);
                cboMSO.Focus();
                displayAttachments();
                this.BringToFront();
            }
        }

        public frmLabRequest()
        {
            InitializeComponent();
            GV.LABREQUESTFORM = this;
            //added this switch statement 4-21-22 LMD
            switch (GV.MODE)
            {
                case Mode.LabRequestAdd:
                    //dataLoading = false;
                    enableBoxes(false, true);
                    //cboMSO.Enabled = true;
                    btnSave.Enabled = true;
                    break;
                case Mode.LabRequestEdit:
                    inputForm.InputDataReady += FrmInput_InputDataReady;
                    inputForm.Show();
                    //took this switch statement from the ATEscalation form
                    enableBoxes(true, false);
                    break;
                case Mode.DeleteEscalation:
                    break;
                default:
                    break;

            }
        }

        private void loadComboBoxLists()
        {
            dataLoading = true;
            List< MSO_Model > MSOs = GlobalConfig.Connection.GenericConditionalGetAll<MSO_Model>("tblMSO", "Active", "1", "MSO");
            cboMSO.DataSource = MSOs;
            cboMSO.DisplayMember = "MSO";
            cboMSO.SelectedIndex = -1;
            FormControlOps.populateListItems<ProductModel>(cboProduct, "tblProducts", "Product");

            dataLoading = false;
        }

        private void clearDate(DateTimePicker dtp)
        {
            dtp.Value = emptyDate;
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
        }
        private LabRequestModel loadModel()
        {
            LabRequestModel model = new LabRequestModel();
            int id = 0;
            int.TryParse(txtID.Text, out id);
            model.ID = id;
            model.Description = txtDescription.Text;
            model.EndDate = dtpEnd.Value;
            model.LRID = txtRequestID.Text;
            model.MSO = cboMSO.Text;
            model.Product = cboProduct.Text;
            model.Remarks = txtRemarks.Text;
            model.StartDate = dtpStart.Value;

            return model;
        }

        private void loadBoxes(LabRequestModel model)
        {
            txtDescription.Text = model.Description;
            txtRemarks.Text = model.Remarks;
            txtRequestID.Text = model.LRID;
            if (model.EndDate == emptyDate)
            {
                clearDTP(dtpEnd);
            }
            else
            { 
                dtpEnd.Value = model.EndDate;

            }            
            dtpStart.Value = model.StartDate;
            cboMSO.Text = model.MSO;
            cboProduct.Text = model.Product;
            txtID.Text = model.ID.ToString();
        }
        private void enableBoxes(bool enabled, bool cboMSOenabled)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    TextBox textBox = (TextBox)ctl;
                    if (textBox.Tag.ToString() == "L")
                    {
                        textBox.Enabled = enabled;
                    }
                }
                if (ctl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctl;
                    if (comboBox.Tag.ToString().Equals("L"))
                    {
                        comboBox.Enabled = enabled;
                    }
                }
                if (ctl is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)ctl;
                    if (datePicker.Tag.ToString().Equals("L"))
                    {
                        datePicker.Enabled = enabled;
                    }

                }
            }
                cboMSO.Enabled = cboMSOenabled;
        }

        private void frmLabRequest_Load(object sender, EventArgs e)
        {
            switch (GV.MODE)
            {
                case Mode.LabRequestAdd:
                    cboMSO.SelectedIndex = -1;
                    loadComboBoxLists();
                    clearDTP(dtpStart);
                    clearDTP(dtpEnd);
                    break;
                case Mode.LabRequestEdit:
                    loadComboBoxLists();

                    break;
                case Mode.LabRequestDelete:
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
        }

        private void cboMSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dataLoading)
            {
                MSO_Model model = ((MSO_Model)cboMSO.SelectedItem);
                formDirty = true;
                if(cboMSO.SelectedIndex > -1)
                {
                    enableBoxes(true,false);
                    txtRequestID.Text = PID_Generator.GenerateEID((MSO_Model)cboMSO.SelectedItem, "LAB_", dataLoading);
                }
                else
                {
                    enableBoxes(false,true);
                }
            }

        }

        private void cboProduct_Leave(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex < 0)
            {
                string newProduct = cboProduct.Text.ToUpper();
                frmAddProduct ProductForm = new frmAddProduct();
                ProductForm.Product = cboProduct.Text;
                ProductForm.ShowDialog();
                FormControlOps.populateListItems<ProductModel>(cboProduct, "tblProducts", "Product");
                cboProduct.Text = newProduct;
            }
        }

        private void clearDTP(DateTimePicker dtp)
        {
            dtp.Value = new DateTime(1900,1,1);
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)cmsDTP.SourceControl; 
            clearDTP(dtp);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.Format = DateTimePickerFormat.Short;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.Format = DateTimePickerFormat.Short;
        }

        private void dtpStart_Enter(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now;
        }

        private void dtpEnd_Enter(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
        }
        private void displayAttachments()
        {
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(txtRequestID.Text);
            dgvAttachments.DataSource = null;
            dgvAttachments.DataSource = aList;
            if (aList.Count > 0)
            {
                formatAttGrid();
            }
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

       

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
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

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
              string[] labels = { "Design Drawing", "E-Mail Chain", "Equipment List", "Lab Report", "Data Log", "Other" };
            List<AttachmentModel> models = AttachmentProcs.AttachFile(this, txtRequestID.Text, labels);
            displayAttachments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAttachments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AttachmentProcs.AttachmentsRowHeaderClick(dgvAttachments);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LabRequestModel model = loadModel();
            switch (GV.MODE)
            {
                case Mode.LabRequestAdd:
                    GlobalConfig.Connection.LabRequests_CRUD(model, 'C');
                    MessageBox.Show(model.LRID + " saved.");
                    break;
                case Mode.LabRequestEdit:
                    GlobalConfig.Connection.LabRequests_CRUD(model, 'U');
                    MessageBox.Show(model.LRID + " saved.");
                    break;
                case Mode.LabRequestDelete:
                    GlobalConfig.Connection.LabRequests_CRUD(model, 'D');
                    break;                
                default:
                    break;
            }
        }

        public void getAssignmentSearchData()
        {
            frmInput frmInput = new frmInput();
            //GV.MODE = Mode.Edit;
            dataLoading = true;
            //clearControls();
            //lockControls(false, "");
            frmInput.InputDataReady += FrmInput_InputDataReady;
            frmInput.Show();
        }

        private void FrmInput_InputDataReady(object sender, InputDataReadyEventArgs e)
        {      
            inputForm.Hide();
            string searchTerm = e.SearchString;
            List<LabRequestModel> models = GlobalConfig.Connection.SearchLabRequests(searchTerm.ToUpper());
            this.Show();
            switch (models.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found.");
                    break;
                case 1:
                    LabRequestModel model = models[0]; 
                    loadBoxes(model);
                    cboMSO.Focus();
                    displayAttachments();
                    break;
                default:
                    frmMultiSelect displayForm = new frmMultiSelect();

                    displayForm.LabRequests = models;
                    displayForm.Show();
                    break;
            }
        }

        private void clearDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)contextMenuStripClearDate.SourceControl;
            clearDate(dtp);
        }
    }

}
