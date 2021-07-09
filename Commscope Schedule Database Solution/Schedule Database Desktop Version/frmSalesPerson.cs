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
    public partial class frmSalesPerson : Form
    {
        RequestorModel Requestor = new RequestorModel();
        public frmSalesPerson()
        {
            InitializeComponent();
        }

        private void formatDGV()
        {
            dgvSales.Columns[2].Visible = false;
            dgvSales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void frmSalesPerson_Load(object sender, EventArgs e)
        {
            List<RequestorModel> salesList = 
                GlobalConfig.Connection.GenericOrderedGetAll<RequestorModel>("tblSalespersons", "SalesPerson");
            dgvSales.DataSource = salesList;
            formatDGV();
            enableControls(false);
        }

        private void dgvSales_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GV.MODE = Mode.SalesPerson_Update;
            enableControls(true);
            txtSalesPerson.Focus();
            txtID.Text = dgvSales.CurrentRow.Cells[2].Value.ToString();
            txtSalesPerson.Text = dgvSales.CurrentRow.Cells[0].Value.ToString();
            chkActive.Checked = (bool)dgvSales.CurrentRow.Cells[1].Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearForm();
            GV.MODE = Mode.SalesPerson_Add;
            enableControls(true);
            txtSalesPerson.Focus();
        }

        private void clearForm()
        {
            txtID.Clear();
            txtSalesPerson.Clear();
        }

        private void enableControls(bool enable)
        {
            txtSalesPerson.Enabled = enable;
            btnSave.Enabled = enable;
            btnDelete.Enabled = enable;
        }

        private void saveProcess()
        {
            int id = 0;
            bool success = int.TryParse(txtID.Text, out id);
            Requestor.ID = id;
            Requestor.SalesPerson = txtSalesPerson.Text;
            Requestor.Active = chkActive.Checked;

            switch (GV.MODE)
            {
                case Mode.SalesPerson_Add:
                    GlobalConfig.Connection.Salesperson_CRUD('C', 0, Requestor.SalesPerson, Requestor.Active);
                    break;
                case Mode.SalesPerson_Update:
                    GlobalConfig.Connection.Salesperson_CRUD('U', Requestor.ID, Requestor.SalesPerson, Requestor.Active);
                    break;
                case Mode.SalesPerson_Delete:
                    GlobalConfig.Connection.Salesperson_CRUD('D', Requestor.ID, Requestor.SalesPerson, Requestor.Active);
                    break;
                default:
                    break;
            }
            dgvSales.DataSource = null;
            dgvSales.DataSource =
                GlobalConfig.Connection.GenericOrderedGetAll<RequestorModel>("tblSalespersons", "SalesPerson");
            txtSalesPerson.Clear();
            enableControls(false);
            formatDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProcess();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.SalesPerson_Delete;
            saveProcess();
        }
    }
}
