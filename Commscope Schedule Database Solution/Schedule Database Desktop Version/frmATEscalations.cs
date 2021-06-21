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
    public partial class FrmATEscalations : Form
    {
        ATEscalationsModel ATEscalation = new ATEscalationsModel();
        List<string> productList = new List<string>();
        List<string> LeadFE = new List<string>();
        private bool dataLoading = false;
        private bool formDirty = false;
        private bool dtpResetting = false;

        public FrmATEscalations()
        {
            InitializeComponent();
            fillComboLists();
            makeProductList();
            makeLeadList();



        }


        private void fillComboLists()
        {
            List<MSO_Model> MSOs = GlobalConfig.Connection.MSO_GetAll();
            cbo_MSO.DataSource = MSOs;
            cbo_MSO.DisplayMember = "MSO";
            cbo_MSO.SelectedIndex = -1;


            cbo_Type.Items.Add("Product");
            cbo_Type.Items.Add("Application");
            cbo_Type.Items.Add("Design");

            cbo_Status.Items.Add("Open");
            cbo_Status.Items.Add("Closed");

        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_DateResolved_ValueChanged(object sender, EventArgs e)
        {
            dtp_DateFormat(sender);
        }
        private void dtp_DateFormat(object sender)
        {
            DateTimePicker Control = (DateTimePicker)sender;
            Control.Format = DateTimePickerFormat.Short;
        }


        private void makeProductList()
        {
            List<ProductModel> products = GlobalConfig.Connection.GenericGetAll<ProductModel>("tblProducts");
            lst_PartNumbers.DataSource = products;
            lst_PartNumbers.DisplayMember = "Product";
        }

        private string collectProducts()
        {
            string xmlString = "";
            if (!dataLoading)
            {
                foreach (var item in lst_PartNumbers.SelectedItems)
                {
                    ProductModel product = (ProductModel)item;
                    productList.Add(product.Product);
                }

                xmlString = Serialization.SerializeToXml<List<string>>(productList);
                //ATEscalation.productList = xmlString;

            }
            return xmlString;
        }

        private void makeLeadList()
        {
            List<FE_Model> lead = GlobalConfig.Connection.FE_GetAll();
            lst_FELead.DataSource = lead;
            lst_FELead.DisplayMember = "FullName";
        }

        private string collectLeads()
        {
            string xmlString = "";
            if (!dataLoading)
            {
                foreach (var item in lst_FELead.SelectedItems)
                {
                    FE_Model lead = (FE_Model)item;
                    LeadFE.Add(lead.FirstName);

                }
                xmlString = Serialization.SerializeToXml<List<string>>(LeadFE);

            }
            return xmlString;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            ATEscalationsModel model = new ATEscalationsModel();
            model.PartNumberXML = collectProducts();
            model.FELeadXML =  collectLeads();

        }
    }
}



