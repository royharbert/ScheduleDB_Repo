using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.Operations
{
    public static class CommonOps
    {
        public static FE_Model ToggleFE_ActiveStatus(FE_Model model)
        {
            GlobalConfig.Connection.ToggleActiveStatus("tblFE", "Active", model.ID, "ID");
            model.Active = ! model.Active;
            return model;
        }
        public static void ToggleMSO_ActiveStatus(DataGridView dgv)
        {
            int idx = 0;
            int.TryParse(dgv.CurrentRow.Cells[2].Value.ToString(), out idx);
            //bool status =  GlobalConfig.Connection.GetCurrentActivityStatus("tblMSO", "Active", idx, "ID");
            GlobalConfig.Connection.ToggleActiveStatus("tblMSO", "Active", idx, "ID");
            List<MSO_Model> msoList = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
            dgv.DataSource = msoList;
        }
        public static void MakeMSO_StatusList(List<MSO_Model> msoList, DataGridView dgv)
        {
            dgv.DataSource = msoList;
            dgv.Columns[1].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static DateTime dtpReset(DateTimePicker dtp)
        {
            if (dtp.Value <= Globals.nullDate)
            {
                dtp.Value = new DateTime(1900, 1, 1);
                Application.DoEvents();
                dtp.CustomFormat = " ";
                dtp.Format = DateTimePickerFormat.Custom;
            }
            return dtp.Value;
        }

        public static DateTime dtpForcedReset(DateTimePicker dtp)
        {
            
            dtp.Value = new DateTime(1900, 1, 1);
            Application.DoEvents();
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
            
            return dtp.Value;
        }

        public static  void loadComboList<T>(ComboBox cbo)
        {
            string tagString = cbo.Tag.ToString();
            string[] tagArray = tagString.Split('|');
            string tableName = tagArray[0];
            string displayItem = tagArray[1];
            List<T> boxList = GlobalConfig.Connection.GenericGetAll<T>(tableName, displayItem);
        }
    }
}
