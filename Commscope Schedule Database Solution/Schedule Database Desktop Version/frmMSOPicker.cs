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
    public partial class frmMSOPicker : Form
    {
        public frmMSOPicker()
        {
            InitializeComponent();
        }
        private void frmMSOPicker_Load(object sender, EventArgs e)
        {
            List<MSO_Model> MSO_List = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
            cboMSOSelector.DataSource = MSO_List;
            cboMSOSelector.DisplayMember = "MSO";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MSO_Model MSO = (MSO_Model)cboMSOSelector.SelectedItem;
            int MSO_ID = MSO.ID;
            List<AssignmentTableModel> assignmentTableModels = GlobalConfig.Connection.GetItemByColumn<AssignmentTableModel>("tblAssignments", "MSO_ID", "", MSO_ID);
            frmMultiSelect resultForm = new frmMultiSelect();
            resultForm.AssignmentData = assignmentTableModels;
            this.Close();
            resultForm.Show();
        }
    }
}
