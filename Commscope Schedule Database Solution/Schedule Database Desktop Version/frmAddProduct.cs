﻿using ScheduleDatabaseClassLibrary;
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
    public partial class frmAddProduct : Form
    {
        public string Product { get; set; }
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            List<ProductCategoryModel> categories = GlobalConfig.Connection.GenericGetAll<ProductCategoryModel>("tblProductCategories", "Category");
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Category";
            cboCategory.DataSource = categories;
            txtProduct.Clear();
            cboCategory.SelectedIndex = -1;
            FC.SetFormPosition(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.Product_Add(txtProduct.Text, cboCategory.Text);
            MessageBox.Show(txtProduct.Text + " added,");
            this.Close();
        }
    }
}
