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
            makeMSOList();
          
        }

        private void makeMSOList()
        {
            List<MSO_Model> msolist = ScheduleDatabaseClassLibrary.GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO");
            dgv_MSO.DataSource = msolist;
            dgv_MSO.Columns[2].Visible = false;
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
                    msolist = ScheduleDatabaseClassLibrary.GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO");
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_MSO_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<MSO_Model> MSOs = (List<MSO_Model>)dgv_MSO.DataSource;
            int currentrow = dgv_MSO.CurrentRow.Index;
            MSO_Model MSO = MSOs[currentrow];
            List<MSO_Model> list = new List<MSO_Model>();
            list.Add(MSO);
            ScheduleDatabaseClassLibrary.TableOps.TableGenerator<MSO_Model> tg = new ScheduleDatabaseClassLibrary.TableOps.TableGenerator<MSO_Model>();
            tg.List = list;
            DataTable dt = tg.table;
            ScheduleDatabaseClassLibrary.GlobalConfig.Connection.MSO_Update(dt);

        }
    }
}
