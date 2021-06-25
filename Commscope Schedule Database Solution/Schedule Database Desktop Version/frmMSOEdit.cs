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
    public partial class frmMSOEdit : Form
    {
        //bool formloading = true;
        MSO_Model model = null;
        List<MSO_Model> msolist = new List<MSO_Model>();

        public frmMSOEdit()
        {
            InitializeComponent();
            
          
        }

        private void makeMSOList()
        {
            List<MSO_Model> msolist = ScheduleDatabaseClassLibrary.GlobalConfig.Connection.MSO_GetAll();
            lst_MSOs.DataSource = msolist;
            lst_MSOs.DisplayMember = "Abbreviation";
            lst_MSOs.SelectedIndex = -1;
        }
        private void btn_markInactive_Click(object sender, EventArgs e)
        {
            model.Active = false;
            MessageBox.Show("This Field Engineer has been marked inactive");
        }

        private void btn_markActive_Click(object sender, EventArgs e)
        {
            model.Active = true;
            MessageBox.Show("This Field Engineer has been marked active");
        }

        private void chk_showActive_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_showActive.Checked == true)
                {
                    msolist = ScheduleDatabaseClassLibrary.GlobalConfig.Connection.GetItemByColumn<MSO_Model>("tblMSO", "Active", "", 1);
                }
                else
                {
                    msolist = ScheduleDatabaseClassLibrary.GlobalConfig.Connection.MSO_GetAll();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
