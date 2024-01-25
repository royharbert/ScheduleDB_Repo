using ScheduleDatabaseClassLibrary;
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
    public partial class frmSearchDateRange : Form
    {
        private string recordType = "";
        private string searchTerm = "";
        public frmSearchDateRange()
        {
            InitializeComponent();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchDateRange_Click(object sender, EventArgs e)
        {
            List<LabEscModel> model  = GlobalConfig.Connection.DateRangeSearch(dtpStartDateRange.Value, dtpEndDateRange.Value, 
                searchTerm, recordType);
            switch (model.Count)
            {
                case 0:
                    MessageBox.Show("No records found");
                    break;
                case 1:
                    frmLabEsc record = new frmLabEsc();
                    record.LabEsc = model[0];
                    record.Show();
                    break;

                default:
                    frmMultiSelect records = new frmMultiSelect();
                    records.LabRequests = model;
                    GV.MODE = Mode.LabEscEdit;
                    records.Show();
                    break;
            }

        }

        private void getSearchTerm()
        {
            if (rdoDateCreated.Checked)
            {
                searchTerm = "DateOpened";
            }
            else
            if (rdoDateDue.Checked)
            {
                searchTerm = "DateDue";
            }
            else
            {
                searchTerm = "DateCompleted";
            }
        }

        private void frmSearchDateRange_Load(object sender, EventArgs e)
        {
            rdoDateCreated.Checked = true;
            FC.SetFormPosition(this);
        }

        private void rdoDateCreated_CheckedChanged(object sender, EventArgs e)
        {
            getSearchTerm();
        }

        private void rdoDateDue_CheckedChanged(object sender, EventArgs e)
        {
            getSearchTerm();
        }

        private void rdoDateClosed_CheckedChanged(object sender, EventArgs e)
        {
            getSearchTerm();
        }

        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoEscalation_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            recordType = radioButton.Tag.ToString();
        }
    }
}
