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

namespace Schedule_Database_Desktop_Version
{
    public partial class frmDateRange : Form
    {
        List<FE_Model> GetFEs;
        List<ProductModel> GetProducts;
        string OrderBy = "";
       

        public frmDateRange()
        {
            InitializeComponent();
            GetFEs = GlobalConfig.Connection.FE_GetAll();
            GetProducts = GlobalConfig.Connection.Products_GetAll();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<string> deserializedProducts(string xmlProducts)
        {
            List<string> productList = null;
            List<int> products = ScheduleDatabaseClassLibrary.GeneralOps.Serialization.DeserializeToList<List<int>>(xmlProducts);
            foreach (var item in products)
            {
                foreach (var product in GetProducts)
                {
                    if (item == product.ID)
                    {
                        productList.Add(product.Product);
                    }
                }
            }
            return productList;
        }
        private void btnSearchDateRange_Click(object sender, EventArgs e)
        {
            List<AssignmentModel> Assignmnents = GlobalConfig.Connection.DateRangeSearch_SortBy(dtpStartDateRange.Value, dtpEndDateRange.Value, OrderBy);
            foreach (var assignment in Assignmnents)
            {

                if (assignment.ProductListXML != "")
                {
                    List<string> products = deserializedProducts(assignment.ProductListXML);
                }
            }

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
        //   private List<ProductModel> GetProducts = new List<ProductModel>();
    }
}
