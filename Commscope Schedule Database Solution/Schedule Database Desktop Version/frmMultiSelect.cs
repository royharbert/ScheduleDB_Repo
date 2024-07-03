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
using Excel = Microsoft.Office.Interop.Excel;

namespace Schedule_Database_Desktop_Version
{
    //git test
    public partial class frmMultiSelect : Form
    {
        private List<ATEscalationsDisplayModel> escalationList;
        private List<CustomerModel> customerData;
        private List<LocationModel> locationData;
        private List<ATEscalationsDisplayModel> escalations;
        private List<LabEscModel> labRequests;
        private List<LabEscModel> requests;

              
        public List<LabEscModel> LabRequests
        {
            get
            {
                return labRequests;
            }
            set
            {
                
                labRequests = value;
                requests = value;
                customerData = null;
                locationData = null;
                dgvResults.DataSource = labRequests;

                foreach (DataGridViewRow row in dgvResults.Rows)
                {
                    removeEmptyDate(row, "DateDue");
                    removeEmptyDate(row, "DateCompleted");
                }
                formatDGV_Escalations();

                txtCount.Text = labRequests.Count.ToString();
            }
        }
        private void removeEmptyDate(DataGridViewRow row, string colHeader)
        {
            string emptyDate = "1/1/1900";
            string test = (row.Cells[colHeader].Value.ToString());
            test = test.Substring(0, test.IndexOf(" "));
            if (test == emptyDate)
            {
                row.Cells[colHeader].Value = "";
            }
        }

        private void formatDGV_Escalations()
        {
            dgvResults.Columns[0].Visible= false;
            foreach (DataGridViewColumn col in dgvResults.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            string[] headers = {"Escalation ID", "MSO", "End User", "City", "State", "Country", "Severity", "Requestor", "CTR Number", "Escalation Number", "Entry Admin", "Date Opened",
                                "Date Due", "Date Completed", "E-Mail","Product", "Lead Assigned", "Quantity", "Status", "Comments", "Description", "Resolution", "MS 365 Number",
                                "Record Type"};
            int[] widths = {145, 140, 150, 125, 120, 125, 60, 140, 115, 115, 115, 100, 100, 100, 180, 90, 115, 60, 125, 150, 150, 130, 100, 100};
            for (int i = 0; i < headers.Length - 1; i++)
            {
                dgvResults.Columns[i + 1].HeaderText = headers[i];
                dgvResults.Columns[i + 1].Width = widths[i];
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
            string[] headers = { "EscID", "MSO", "EndUser", "City", "State", "Country", "Severity", "Requestor", "CTRNum", "EscNum", "IsEsc", "EntryAdmin", "DateOpened", "DateDue", "DateCompleted", "Product", "LeadAssigned", "Quantity", "Status", "Comments", "Description", "Resolution", "PSNumber" };

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
                case Mode.OpenEscByDate:
                    ListLooper.ExcelExporter<LabEscModel> exporter = new ListLooper.ExcelExporter<LabEscModel>();
                    exporter.List = (List<LabEscModel>)dgvResults.DataSource;
                     ReportOps.FormatEscalationResultExport(exporter.Wksheet);
                    break;
                default:
                    ListLooper.ExcelExporter<LabEscModel> excelExporter = new ListLooper.ExcelExporter<LabEscModel>();
                    excelExporter.List = (List<LabEscModel>)dgvResults.DataSource;
                    ReportOps.FormatMultiResultExport(excelExporter.Wksheet);
                    break;
            }
           
        }

        private void frmMultiSelect_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);
        }

        private void dgvResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgvResults.CurrentRow.Index;
            switch (GV.MODE)
            {
                case Mode.LabEscSearch:
                case Mode.LabEscEdit:
                case Mode.OpenEscByDate:
                case Mode.LabEscReport:
                case Mode.LabEscDelete:
                    List<LabEscModel> requests = (List<LabEscModel>)dgvResults.DataSource;
                    GV.EscForm.Show();
                    LabEscModel request = requests[selectedRow];
                    requests = GlobalConfig.Connection.LabEscGetByPID(request.EscID, false);
                    GV.EscForm.LabEsc = requests[0];
                    GV.EscForm.PrepFormForDisplay(true);
                    break;
                case Mode.Dashboard:
                    GV.MODE = Mode.LabEscEdit;
                    GV.MODE = Mode.LabEscEdit;
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
            //this.Close();
            GV.EscForm.BringToFront();
        }
    }
}
