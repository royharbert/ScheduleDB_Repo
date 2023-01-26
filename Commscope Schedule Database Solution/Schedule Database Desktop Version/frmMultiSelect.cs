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
    //git test
    public partial class frmMultiSelect : Form
    {
        private List<AssignmentTableModel> retrieveList;
        private List<AssignmentDisplayModel> displayList;
        private List<ATEscalationsDisplayModel> escalationList;
        private List<CustomerModel> customerData;
        private List<LocationModel> locationData;
        private List<ATEscalationsDisplayModel> escalations;
        private List<LabEscModel> labRequests;
        private List<LabEscModel> requests;

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
                displayList = null;
                retrieveList = null;
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
                retrieveList = null;
                locationData = null;
                dgvResults.DataSource = customerData;
                txtCount.Text = customerData.Count.ToString();
            }
        }
        public List<AssignmentTableModel> AssignmentData 
        {
            get 
            {
                return retrieveList;
            } 
            set 
            {
                retrieveList = value;
                displayList = TableToDisplayConverter.ConvertTableToDisplayModel(retrieveList);
                customerData = null;
                locationData = null;
                dgvResults.DataSource = displayList;
                txtCount.Text = displayList.Count.ToString();
                //formatDGV_Assignment();
                setDGV_HeaderText(dgvResults);
            } 
        }

        public List<LabEscModel> LabRequests
        {
            get
            {
                return labRequests;
            }
            set
            {
                labRequests = value;
                customerData = null;
                locationData = null;
                dgvResults.DataSource = labRequests;
                txtCount.Text = labRequests.Count.ToString();
            }
        }
        public List<ATEscalationsDisplayModel> Escalations
        {
            get
            {
                return escalations;
            }
            set
            {
                escalations = value;
                escalationList = escalations;
                customerData = null;
                locationData = null;
                dgvResults.DataSource = escalationList;
                txtCount.Text = escalationList.Count.ToString();
                formatDGV_Escalation();
                setDGV_EscalationHeaderText(dgvResults);
            }
        }


        public List<LabEscModel> Requests
        {
            get
            {
                return requests;
            }
            set
            {
                requests = value;
                customerData=null;
                locationData=null;
                dgvResults.DataSource = requests;
                txtCount.Text=requests.Count.ToString();
            }
        }

        private void setDGV_EscalationHeaderText(DataGridView dgv)
        {
            string[] headers = { "EscID", "MSO", "EndUser", "City", "State", "Country", "Severity", "Requestor", "CTRNum", "EscNum", "IsEsc", "EntryAdmin", "DateOpened", "DateDue", "DateCompleted", "EMail", "Product", "LeadAssigned", "Quantity", "Status", "Comments", "Description", "Resolution", "PSNumber" };

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
                style.Font = new Font(dgv.Font, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[i].HeaderText = headers[i];
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
                case Mode.DateRangeReport:
                    AssignmentDisplayModel assignment = displayList[selectedRow];
                    GV.ASSIGNMENTFORM.Assignment = retrieveList[selectedRow];
                    GV.ASSIGNMENTFORM.BringToFront();
                    break;
                case Mode.Undo:
                    break;
                case Mode.CustomerSearch:                    
                    customer = customerData[selectedRow];
                    GV.ASSIGNMENTFORM.FillCustomerData(customer);
                    GV.MODE = GV.PreviousMode;
                    this.Close();
                    break;
                case Mode.CustomerSearchMDI:
                    customer = customerData[selectedRow];
                    CallingForm.FillBoxes(customer);
                    this.Close();
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
                    this.Close();
                    break;
                case Mode.LabEscSearch:
                    LabEscModel request = requests[selectedRow];
                    frmLabEsc escForm = new frmLabEsc();
                    escForm.Show();
                    //escForm.MdiParent = frmAMDI_Parent;
                    escForm.LabEsc = request;
                    break;
                case Mode.LabEscEdit:                
                    LabEscModel labRequest = labRequests[selectedRow];
                    GV.LABREQUESTFORM.LabRequest = labRequest;
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
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

        private void formatDGV_Escalation()
        {
            int[] widths = { 200, 150, 200, 100, 200, 300, 100, 150, 150, 300, 300, 150, 150, 100 };
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
            switch (GV.MODE)
            {  
                case Mode.LabEscSearch:
                case Mode.LabEscEdit:
                case Mode.LabEscDateRange:
                    ListLooper.ExcelExporter<ATEscalationsDisplayModel> exporter = new ListLooper.ExcelExporter<ATEscalationsDisplayModel>();
                    exporter.List = (List<ATEscalationsDisplayModel>)dgvResults.DataSource;
                    ReportOps.FormatEscalationResultExport(exporter.Wksheet);
                    break;
                default:
                    ListLooper.ExcelExporter<AssignmentDisplayModel> excelExporter = new ListLooper.ExcelExporter<AssignmentDisplayModel>();
                    excelExporter.List = (List<AssignmentDisplayModel>)dgvResults.DataSource;
                    ReportOps.FormatMultiResultExport(excelExporter.Wksheet);
                    break;
            }
           
        }

        private void excelExportFormatLabRequest(Excel.Worksheet wks)
        {
            wks.get_Range("1:1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            wks.Columns[1].Columnwidth = 26;
            wks.Columns[2].Columnwidth = 26;
            wks.Columns[3].Columnwidth = 15;
            wks.Columns[4].Columnwidth = 15;
            wks.Columns[5].Columnwidth = 15;
            wks.Columns[6].Columnwidth = 50;
            wks.Columns[7].Columnwidth = 50;
          
        }
    }
}
