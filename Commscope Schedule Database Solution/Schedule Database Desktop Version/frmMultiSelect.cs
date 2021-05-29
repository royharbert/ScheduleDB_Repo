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
using Excel = Microsoft.Office.Interop.Excel;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmMultiSelect : Form
    {
        private List<AssignmentRetrieveModel> dataSource;
        private List<CustomerModel> customerData;
        private List<LocationModel> locationData;

        public frmCustomerContact CallingForm { get; set; }

        public List<LocationModel> LocationData  
        {
            get
            {
                return LocationData;
            } 
            
            set
            {
                locationData = value;
                dataSource = null;
                customerData = null;
                dgvResults.DataSource = locationData;
                txtCount.Text = locationData.Count.ToString();
                formatDGV_Location();
            }
        }

        public List<CustomerModel> CustomerData
        {
            get
            {
                return customerData;
            }
            set 
            {
                customerData = value;
                dataSource = null;
                locationData = null;
                dgvResults.DataSource = customerData;
                txtCount.Text = customerData.Count.ToString();
            }
        }
        public List<AssignmentRetrieveModel> AssignmentData 
        {
            get 
            {
                return dataSource;
            } 
            set 
            {
                dataSource = value;
                customerData = null;
                locationData = null;
                dgvResults.DataSource = dataSource;
                txtCount.Text = dataSource.Count.ToString();
                formatDGV_Assignment();
                setDGV_HeaderText(dgvResults);
            } 
        }

        private static void setDGV_HeaderText(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {                
                DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
                style.Font = new Font(dgv.Font, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public frmMultiSelect()
        {
            InitializeComponent();
        }

        private void dgvResults_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = dgvResults.CurrentRow.Index;
            CustomerModel customer;
            switch (GV.MODE)
            {
                case Mode.New:
                    break;
                case Mode.Edit:
                    AssignmentRetrieveModel assignment = dataSource[selectedRow];
                    GV.ASSIGNMENTFORM.Assignment = assignment;
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:                    
                    customer = customerData[selectedRow];
                    GV.ASSIGNMENTFORM.FillCustomerData(customer);
                    GV.MODE = GV.PreviousMode;
                    break;
                case Mode.CustomerSearchMDI:
                    customer = customerData[selectedRow];
                    CallingForm.FillBoxes(customer);
                    break;
                // added this LD not sure....
                case Mode.DeleteCustomer:
                    customer = customerData[selectedRow];
                    CallingForm.FillBoxes(customer);
                    this.Close();
                    break;
                case Mode.LocationSearch:
                    LocationModel location = locationData[selectedRow];
                    GV.ASSIGNMENTFORM.FillLocationData(location);
                    GV.MODE = GV.PreviousMode;
                    break;
                case Mode.DateRangeReport:

                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
            GV.MAINMENU.BringToFront();
            this.Close();
        }

        private void formatDGV_Assignment()
        {
            int[] widths = {    200,150,150,150,150,150,150,150,150,150,150,
                                150,150,150,150,150,150,150,150,150,150,150,
                                150,150,150,150,150,150,150,150,150,150,150,
                                150,150,150,150,150,150,150,150,150,150 };
            for (int i = 0; i < widths.Length; i++)
            {
                dgvResults.Columns[i].Width = widths[i];
            }
        }

        private void formatDGV_Location()
        {
            int[] widths = {    20,150,150,150,150,150,150,150,150,150 };
            for (int i = 0; i < widths.Length; i++)
            {
                dgvResults.Columns[i].Width = widths[i];
            }
            dgvResults.Columns[0].Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

                ListLooper.ExcelExporter<AssignmentRetrieveModel> exporter = new ListLooper.ExcelExporter<AssignmentRetrieveModel>();
                exporter.List = (List<AssignmentRetrieveModel>)dgvResults.DataSource;
                ReportOps.FormatMultiResultExport(exporter.Wksheet);

        }
    }
}
