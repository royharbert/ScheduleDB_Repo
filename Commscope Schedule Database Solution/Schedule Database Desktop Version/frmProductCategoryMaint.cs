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
    public partial class frmProductCategoryMaint : Form
    {
        bool formLoading = true;
        public frmProductCategoryMaint()
        {
            InitializeComponent();
        }

        private void frmProductCategoryMaint_Load(object sender, EventArgs e)
        {
            loadListbox();

            formLoading = false;
        }

        private void loadListbox()
        {
            lbCategories.DataSource = null;
            lbCategories.Items.Clear();
            List<ProductCategoryModel> categories =
                GlobalConfig.Connection.GenericGetAll<ProductCategoryModel>("tblProductCategories", "Category");
            lbCategories.DataSource = categories;
            lbCategories.DisplayMember = "Category";
            lbCategories.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedIndex > -1 && !formLoading)
            {
                ProductCategoryModel model = (ProductCategoryModel)lbCategories.SelectedItem;
                txtCategory.Text = model.Category;
                txtID.Text = model.ID.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.ProductCategoryAdd;
            txtCategory.ReadOnly = false;
            ProductCategoryModel model = new ProductCategoryModel();
            model.Category = txtCategory.Text;
            GlobalConfig.Connection.ProductCategoryAdd(model);
            MessageBox.Show(model.Category + " Added");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = -1;
            int.TryParse(txtID.Text, out id);
            ProductCategoryModel model = new ProductCategoryModel();
            model.ID = id;
            int.TryParse(txtID.Text, out id);
            model.Category = txtCategory.Text;
            model.ID = id;

            switch (GV.MODE)
            {
                case Mode.ProductCategoryAdd:
                    GlobalConfig.Connection.ProductCategoryAdd(model);
                    MessageBox.Show(model.Category + " Added");
                    break;
                case Mode.ProductCategoryEdit:
                    GlobalConfig.Connection.ProductCategoryUpdate(model);
                    MessageBox.Show(model.Category + " Updated");
                    break;
                case Mode.None:
                    break;
                default:
                    break;
            }
            txtCategory.ReadOnly = true;
            loadListbox();
            GV.MODE = Mode.None;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.ProductCategoryEdit;
            txtCategory.ReadOnly = false;
        }
    }
}
