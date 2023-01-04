using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmDateRange : Form
    {
        List<FE_Model> GetFEs;
        List<ProductModel> GetProducts;
        string OrderBy = "StartDate";
       

        public frmDateRange()
        {
            InitializeComponent();
            GetFEs = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE", "LastName");
            GetProducts = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts", "Product");
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<string> deserializedProducts(string xmlProducts)
        {
            List<string> productList = new List<string>();
            List<int> products = Serialization.DeserializeToList<List<int>>(xmlProducts);
            if(products != null) 
            {
                foreach(var item in products)
                {
                    foreach (var product in GetProducts)
                    {
                        if (item == product.ID)
                        {
                            productList.Add(product.Product);
                        }
                    }
                } 
            }
            return productList;
        }
        private void btnSearchDateRange_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDateRange.Value;
            DateTime endDate = dtpEndDateRange.Value;
            //Get all assignments in date range
            List<AssignmentTableModel> Assignments = null;
            List<LabRequestModel> Labs = null;
            List<ATEscalationsDisplayModel> Escalations = null;
            frmMultiSelect DisplayForm = new frmMultiSelect();
            switch (GV.MODE)
                { 
                    case Mode.AssignmentSearchDateRange:
                    Assignments = GlobalConfig.Connection.DateRangeSearch_SortBy(startDate, endDate);
                    DisplayForm.AssignmentData = Assignments;
                    this.Height = 334;
                    break;
                    case Mode.LabRequestDateRange:
                    Labs = GlobalConfig.Connection.DateRangeSearchLab_SortBy(startDate, endDate);
                    DisplayForm.LabRequests = Labs;
                    this.Height = 195;
                    break;
                    case Mode.LabEscDateRange:
                    Escalations = GlobalConfig.Connection.DateRangeSearchEscalations_SortBy(startDate, endDate);
                    DisplayForm.Escalations = Escalations;
                    this.Height = 195;

                    break;

                }
            DisplayForm.Show();
            DisplayForm.BringToFront();
            this.Close();
        }
        private void RadioClick(RadioButton radioButton)
        {
            if (radioButton.Checked)
            {
                OrderBy = radioButton.Tag.ToString();
            }
        }
        private void rdbOrderByStartDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByEndDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByCustReqDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByRegion_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByMSO_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByFE_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByActivity_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByRequestID_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void rdbOrderByProduct_CheckedChanged(object sender, EventArgs e)
        {
            RadioClick(sender as RadioButton);
        }

        private void frmDateRange_Load(object sender, EventArgs e)
        {

        }
        //   private List<ProductModel> GetProducts = new List<ProductModel>();
    }
}
