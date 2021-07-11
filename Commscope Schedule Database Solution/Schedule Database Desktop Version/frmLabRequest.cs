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
        bool dataLoading = true;
        bool formDirty = false;
        LabRequestModel labRequest = null;

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
        }

        private void loadComboBoxLists()
        {
            FormControlOps.populateListItems<MSO_Model>(cboMSO, "tblMSO", "MSO");
            FormControlOps.populateListItems<ProductModel>(cboProduct, "tblProducts", "Product");

            dataLoading = false;
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
            dtpEnd.Value = model.EndDate;
            dtpStart.Value = model.StartDate;
            cboMSO.Text = model.MSO;
            cboProduct.Text = model.Product;
            txtID.Text = model.ID.ToString();
        }

        private void frmLabRequest_Load(object sender, EventArgs e)
        {
            switch (GV.MODE)
            {
                case Mode.LabRequestAdd:
                    loadComboBoxLists();
                    clearDTP(dtpStart);
                    clearDTP(dtpEnd);
                    break;
                case Mode.LabRequestEdit:
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
                //formDirty = true;
                if (sender is ComboBox)
                {
                    ComboBox ctl = (ComboBox)sender;

                    if (ctl.Name == "cboMSO")
                    {
                        txtRequestID.Text = PID_Generator.GenerateEID((MSO_Model)cboMSO.SelectedItem, "LAB_");
                        cboMSO.Enabled = false;
                    }
                }
            }
        }

        private void cboProduct_Leave(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex < 0)
            {
                frmAddProduct ProductForm = new frmAddProduct();
                ProductForm.Product = cboProduct.Text;
                ProductForm.ShowDialog();
                FormControlOps.populateListItems<ProductModel>(cboProduct, "tblProducts", "Product");
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
            //GV.MODE = Mode.Edit;
            dataLoading = true;
            //clearControls();
            //lockControls(false, "");
            frmInput frmInput = new frmInput();
            frmInput.InputDataReady += FrmInput_InputDataReady;
            frmInput.Show();
        }

        private void FrmInput_InputDataReady(object sender, InputDataReadyEventArgs e)
        {
            string searchTerm = e.SearchString;
            List<LabRequestModel> models = GlobalConfig.Connection.SearchLabRequests(searchTerm.ToUpper());
            this.Show();
            switch (models.Count)
            {
                case 0:
                    MessageBox.Show("No matching records found.");
                    break;
                case 1:
                    LabRequestModel model = models[0]; ;
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
    }

}
