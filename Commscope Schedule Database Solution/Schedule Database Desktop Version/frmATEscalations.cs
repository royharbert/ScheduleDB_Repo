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

        public FrmATEscalations()
        {
            formDirty = false;

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

        private void loadBoxes(ATEscalationsModel model)
        {
            txtID.Text = model.ID.ToString();
            txt_Comments.Text = model.Comments;
            txt_CTRNumber.Text = model.Comments;
            txt_Description.Text = model.ATEDescription;
            txt_PSNumber.Text = model.PeopleSoftNumber;
            txt_Qty.Text = model.Quantity.ToString();
            txt_Resolution.Text = model.Resolution;
            cbo_MSO.Text = model.MSO;
            cbo_Status.Text = model.ATEStatus;
            cbo_Type.Text = model.ATEType;
            dtp_DateReported.Value = model.DateReported;
            dtp_DateResolved.Value = model.ResolvedDate;
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
                ATEscalation.PartNumberXML = xmlString;

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
            model.ATEDescription = txt_Description.Text;
            model.ATEStatus = cbo_Status.Text;
            model.ATEType = cbo_Type.Text;
            model.Comments = txt_Comments.Text;
            model.CTRNumber = txt_CTRNumber.Text;
            model.DateReported = dtp_DateReported.Value;
            model.ResolvedDate = dtp_DateResolved.Value;
            model.ID = int.Parse(txtID.Text);
            ScheduleDatabaseClassLibrary.TableOps.TableGenerator<ATEscalationsModel> dt =
                new ScheduleDatabaseClassLibrary.TableOps.TableGenerator<ATEscalationsModel>();
            List<ATEscalationsModel> escalations = new List<ATEscalationsModel>();
            escalations.Add(model);
            dt.List = escalations;
            GlobalConfig.Connection.Escalations_Add(dt.table);
        }

        private void cbo_MSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            formDirty = true;
        }
    }
}



