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
    public partial class FrmATEscalations : Form
    {
        public FrmATEscalations()
        {
            InitializeComponent();
            fillComboLists();
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

            cbo_FELead.Items.Add("Brad Riggan");
            cbo_FELead.Items.Add("Walter Sharp");
            cbo_FELead.Items.Add("Shaun Mondoro");
            cbo_FELead.Items.Add("Roy Harbert");
            cbo_FELead.Items.Add("Jim Morton");
            cbo_FELead.Items.Add("Mark Ehemann");

        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
