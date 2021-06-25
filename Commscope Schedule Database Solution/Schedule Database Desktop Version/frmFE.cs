using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleDatabaseClassLibrary.GeneralOps;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmFE : Form
    {
        bool formloading = true;
        FE_Model model = null;
        List<FE_Model> feList = new List<FE_Model>();


        string connectionString;

        public frmFE()
        {
            model = new FE_Model();
            InitializeComponent();
            makeFEList();
            formloading = false;
            bool active = true;
            bool inactive = false;

            string active1 = active.ToString();
            string inactive1 = inactive.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Sandbox"].ConnectionString;
        }

        private void makeFEList()
        {
            List<FE_Model> feList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
            lst_FieldEngineer.DataSource = feList;
            lst_FieldEngineer.DisplayMember = "FullName";
            lst_FieldEngineer.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //GlobalConfig.Connection.FE_GetAllActive();
            MessageBox.Show("Field Engineer Information Updated");
        }

        private void chk_viewActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_viewActive.Checked == true)
            {
                feList = GlobalConfig.Connection.GetItemByColumn<FE_Model>("tblFE", "Active","",1);
            }
            else
            {
                feList = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE");
            }
            
                lst_FieldEngineer.DataSource = feList;
                lst_FieldEngineer.DisplayMember = "FullName"; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_FieldEngineer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (! formloading)
            {
                model = (FE_Model)lst_FieldEngineer.SelectedItem;
                txtFE_FirstName.Text = model.FirstName;
                txtFE_LastName.Text = model.LastName;
                txtFE_ManagerID.Text = model.ManagerID;
                txtFE_Phone.Text = model.Phone;
                txtFE_Region.Text = model.Phone;
                txtFE_Email.Text = model.EMail;
                txtFE_Active.Text = model.Active.ToString();
            }
           
        }
        private FE_Model loadModel()
        {
            model.FirstName = txtFE_FirstName.Text;
            model.LastName = txtFE_LastName.Text;
            model.ManagerID = txtFE_ManagerID.Text;
            model.Region = txtFE_Region.Text;
            model.Phone = txtFE_Phone.Text;
            model.EMail = txtFE_Email.Text;
            model.Active = bool.Parse(txtFE_Active.Text);

            return model;

        }
        private void btn_markActive_Click(object sender, EventArgs e)
        {
            model.Active = true;
            MessageBox.Show("This Field Engineer has been marked active");
        }

        private void btn_markInactive_Click(object sender, EventArgs e)
        {
            model.Active = false;
            MessageBox.Show("This Field Engineer has been marked inactive");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to delete this record?");

        }

        private void btn_ClearFields_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
        }

        private void btnFE_Save_Click(object sender, EventArgs e)
      {
        //    //FE_Model model = new FE_Model();
            //model.FirstName = txtFE_FirstName.Text;
            //model.LastName = txtFE_LastName.Text;
            //model.ManagerID = txtFE_ManagerID.Text;
            //model.Region = txtFE_Region.Text;
            //model.Phone = txtFE_Phone.Text;
            //model.EMail = txtFE_Email.Text;
            //model.Active = bool.Parse(txtFE_Active.Text);

            //ScheduleDatabaseClassLibrary.TableOps.TableGenerator<FE_Model> dt =
            //    new ScheduleDatabaseClassLibrary.TableOps.TableGenerator<FE_Model>();
            //List<FE_Model> fieldengineers = new List<FE_Model>();
            //fieldengineers.Add(model);
            //dt.List = fieldengineers;
            //GlobalConfig.Connection.FE_Update(dt.table);

            //MessageBox.Show("Field Engineer has been updated");

        }

        private void btnFE_Add_Click(object sender, EventArgs e)
        {
        //    FE_Model model = new FE_Model();
        //    model.FirstName = txtFE_FirstName.Text;
        //    model.LastName = txtFE_LastName.Text;
        //    model.ManagerID = txtFE_ManagerID.Text;
        //    model.Region = txtFE_Region.Text;
        //    model.Phone = txtFE_Phone.Text;
        //    model.EMail = txtFE_Email.Text;
        //    model.Active = bool.Parse(txtFE_Active.Text);

            //ScheduleDatabaseClassLibrary.TableOps.TableGenerator<FE_Model> dt=
            //    new ScheduleDatabaseClassLibrary.TableOps.TableGenerator<FE_Model>();
            //List<FE_Model> escalations = new List<FE_Model>();
            ////escalations.Add(model);
            ////dt.List = FieldEngineers;
            ////GlobalConfig.Connection.FE_Add(dt.table);
            //MessageBox.Show("Field Engineer has been added");
        }

        //private void btnFE_Save_Click(object sender, EventArgs e)
        //{
        //    model = loadModel();

        //    GlobalConfig.Connection.UpdateFE("Update", model.ID, model.FirstName, model.LastName, model.ManagerID,
        //        model.Region, model.Phone, model.EMail, model.Active);
        //}
    }
}
