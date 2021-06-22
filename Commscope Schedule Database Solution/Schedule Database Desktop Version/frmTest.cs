
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
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.TableOps;


namespace Schedule_Database_Desktop_Version
{
    public partial class frmTest : Form
    {
        List<FE_Model> _Models = new List<FE_Model>();
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initList();
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            string output = Serialization.SerializeToXml<List<FE_Model>>(_Models);
            txtData.Text = "";
            txtData.Text = output;
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            List<FE_Model> result = Serialization.DeserializeToList<List<FE_Model>>(txtData.Text);
            foreach (var FE in result)
            {
                txtResult.Text += FE.FirstName + " " + FE.LastName;
            }
        }

        private void initList()
        {
            var FE1 = new FE_Model() { FirstName = "Skip", LastName = "Dougherty" };
            var FE2 = new FE_Model() { FirstName = "Chris", LastName = "Combs" };
            _Models.Add(FE1);
            _Models.Add(FE2);            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //List<UserModel> list = GlobalConfig.Connection.GetUsers_All();
            //TableGenerator<UserModel> tg = new TableGenerator<UserModel>() { List = list };
            //DataTable table = tg.table;


            //FEListConverterToXML.ConvertFEListToXML();
            AssignmentModel assignment = GlobalConfig.Connection.Assignment_GetByID(4885)[0];
            string feList = assignment.FE_ListXML;
            
            List<FE_Model> result = Serialization.DeserializeToList<List<FE_Model>>(feList);

            txtFE1.Text = result[0].FirstName + " " + result[0].LastName;
            txtFE2.Text = result[1].FirstName + " " + result[1].LastName;
            txtFE3.Text = result[2].FirstName + " " + result[2].LastName;
        }
    }
}
