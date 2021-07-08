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
        public frmLabRequest()
        {
            InitializeComponent();
        }

        private void loadComboBoxLists()
        {
            populateListItems<MSO_Model>(cboMSO, "tblMSO", "MSO");


            dataLoading = false;
        }

        private void populateListItems<T>(ComboBox cbo, string tableName, string displayItem)
        {
            List<T> boxList = GlobalConfig.Connection.GenericGetAll<T>(tableName);
            cbo.DataSource = boxList;
            cbo.DisplayMember = displayItem;
            cbo.SelectedIndex = -1;
        }

        private void frmLabRequest_Load(object sender, EventArgs e)
        {
            loadComboBoxLists();
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
    }

}
