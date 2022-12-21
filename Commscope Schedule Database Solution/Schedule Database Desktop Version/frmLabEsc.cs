﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Operations;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmLabEsc : Form
    {
        bool isEscalation = false;
        public frmLabEsc()
        {
            InitializeComponent();
            fillComboBoxes();

            switch (GV.MODE)
            {
                case Mode.LabEscAdd:
                    break;
                case Mode.LabEscEdit:
                    break;
                case Mode.LabEscDelete:
                    break;
                case Mode.LabEscSearch:
                    break;
                default:
                    break;
            }
        }

        private void clearDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    DateTime newDate = CommonOps.dtpForcedReset(sourceControl as DateTimePicker);
                    DateTimePicker dtp = (DateTimePicker)sourceControl;
                    dtp.Value = newDate;
                }                
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //LabEscModel model = loadModel();
            //switch (switch_on)
            //{
            //    default:
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillComboBoxes()
        {
            fillComboList<MSO_Model>(cboMSO, "tblMSO", "MSO");
            fillComboList<CityModel>(cboCity, "tblCities", "City");
            fillComboList<StateModel>(cboState, "tblStates", "State");
            fillComboList<CountriesModel>(cboCountry, "tblCountries", "Country");

            fillComboList<PriorityModel>(cboSeverity, "tblPriorities", "Priority");
            fillComboList<RequestorModel>(cboRequestor, "tblSalespersons", "SalesPerson");
            fillComboList<StatusModel>(cboStatus, "tblStatus", "Status");
            fillComboList<FE_Model>(cboLead, "tblFE", "LastName");
        }

        private void fillComboList<T>(ComboBox cbo, string table, string displayField)
        {
            List<T> data = GlobalConfig.Connection.GenericGetAll<T>(table, displayField);
            cbo.DataSource = data;
            if (displayField != "LastName")
            {
                cbo.DisplayMember = displayField; 
            }
            else
            {
                cbo.DisplayMember = "FullName";
            }
            cbo.SelectedIndex = -1;
        }
        private LabEscModel loadModel()
        {
            LabEscModel model = new LabEscModel();
            //int id = 0;
            //int.TryParse(txtRecordID.Text, out id);
            //model.ID = id;
            model.EscID = txtRecordID.Text;
            model.MSO = cboMSO.Text;
            model.EndUser = txtEndUser.Text;
            model.City = cboCity.Text;
            model.State = cboState.Text;
            model.Country = cboCountry.Text;
            model.Severity = cboSeverity.Text;
            model.Requestor = cboRequestor.Text;
            model.CTRNum = txtCTRNum.Text;
            model.EscNum = txtEscNum.Text;
            //model.IsEsc = rdoATEsc.Checked;
            //model.IsEsc = rdoLabReq.Checked;
            model.EntryAdmin = cboEntryAdmin.Text;
            model.DateOpened = dtpStartDate.Value;
            model.DateDue = dtpDueDate.Value;
            model.DateCompleted = dtpClosedDate.Value;
            model.EMail = txtEmail.Text;
            model.LeadAssigned = cboLead.Text;
            model.Status = cboStatus.Text;
            model.Comments = rtxComments.Text;
            model.Description = rtxDescription.Text;

            return model;

        }
        private void loadboxes(LabEscModel model)
        {
            txtRecordID.Text = model.EscID;
            cboMSO.Text = model.MSO;
            txtEndUser.Text = model.EndUser;
            cboCity.Text = model.City;
            cboState.Text = model.State;
            cboCountry.Text = model.Country;
            cboSeverity.Text = model.Severity;
            cboRequestor.Text = model.Requestor;
            txtCTRNum.Text = model.CTRNum;
            txtEscNum.Text = model.EscNum;
            //rdoATEsc.Checked = model.IsEsc;
            //rdoLabReq.Checked = model.IsEsc;
            cboEntryAdmin.Text = model.EntryAdmin;
            dtpStartDate.Value = model.DateOpened;
            dtpDueDate.Value = model.DateDue;
            dtpClosedDate.Value = model.DateCompleted;
            txtEmail.Text = model.EMail;
            //product
            //if (model.product != null)
            //{
            //    FormControlOps.markListBoxes(lstProducts, model.Product)
            //}
            cboLead.Text = model.LeadAssigned;
           // txtQty.Text = model.Quantity; (int)
            cboStatus.Text = model.Status;
            rtxComments.Text = model.Comments;
            rtxDescription.Text = model.Description;
            //
            txtPSNum.Text = model.PSNumber;
            //displayAttachments();

        }
        private void makeProductList()
        {

        }
        private void frmLabEsc_Load(object sender, EventArgs e)
        {

        }
        private string serializeProducts(List<ProductModel> products)
        {
            string xmlString;
            List<string> ProductList = new List<string>();
            foreach (var product in lstProducts.SelectedItems)
            {
                ProductModel prod = product as ProductModel;
                ProductList.Add(prod.Product);
            }
            xmlString = Serialization.SerializeToXml<List<string>>(ProductList);
            //assignment.ProductListXML = xmlString;
            return xmlString;
        }
        //private void frmLabEsc_Load(object sender, EventArgs e)            
        //{
        //    // determine type
        //    RadioButton[] buttons = { rdoATEsc, rdoLabReq };
        //    for (int i = 0; i < buttons.Length - 1; i++)
        //    {
        //        if (true)
        //        {
        //            switch (i)
        //            {
        //                case 0:
        //                    isEscalation = true;
        //                    break;
        //                case 1:
        //                    isEscalation = false;
        //                    break;
                    
        //            }
        //        }
        //    }

        //    //load combo lists
        //    List<MSO_Model> models = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
        //    populateCBOList<MSO_Model>(cboMSO, models, "MSO");

        //    List<CityModel> cities = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities", "City");
        //    populateCBOList<CityModel>(cboCity, cities, "City");

        //    List<StateModel> states = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates", "State");
        //    populateCBOList<StateModel>(cboState, states, "State");

        //    List<CountriesModel> countries = GlobalConfig.Connection.GenericGetAll<CountriesModel>("tblCountries", "Country");
        //    populateCBOList<CountriesModel>(cboCountry, countries, "Country");

        //    List<PriorityModel> priorities = GlobalConfig.Connection.GenericGetAll<PriorityModel>("tblPriorities", "Priority");
        //    populateCBOList<PriorityModel>(cboSeverity, priorities, "Priority");

        //    List<RequestorModel> salesPersons = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons", "SalesPerson");
        //    populateCBOList<RequestorModel>(cboRequestor, salesPersons, "Salesperson");

        //    List<AdminModel> admins = GlobalConfig.Connection.GenericGetAll<AdminModel>("tblAdmins", "FullName");
        //    populateCBOList<AdminModel>(cboEntryAdmin, admins, "FullName");

        //    List<FE_Model> FEs = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE", "Last" +
        //        "Name");
        //    populateCBOList<FE_Model>(cboEntryAdmin, FEs, "FullName");
        //}

        private void populateCBOList<T>(ComboBox cbo, List<T> models, string displayMember)
        {
            cbo.DataSource = models;
            cbo.DisplayMember = displayMember;
            cbo.SelectedIndex = -1;
        }
       
    }
}
