using ScheduleDatabaseClassLibrary;
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
    public partial class frmAddProduct : Form
    {
        public string Product { get; set; }
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            txtProduct.Text = Product.ToUpper();
            cboCategory.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (cboCategory.SelectedIndex > -1)
            {
                int success = GlobalConfig.Connection.Product_Add(txtProduct.Text, cboCategory.Text);

                MessageBox.Show(txtProduct.Text + " added.");
                
                this.Close();

            }
            else
            {
                MessageBox.Show("Please select a category for this product");
            }             
        }
    }   

}
