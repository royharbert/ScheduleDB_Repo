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
            List<LabEscModel> model  = GlobalConfig.Connection.labEscSearchDateRange(dtpStartDateRange.Value, dtpEndDateRange.Value);
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
                    //GV.MODE = Mode.LabEscEdit;
                    records.Show();
                    break;
            }

        }

        private void frmSearchDateRange_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);
        }

    }
}
