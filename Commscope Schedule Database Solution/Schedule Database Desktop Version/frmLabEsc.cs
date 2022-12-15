using System;
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
        public frmLabEsc()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLabEsc_Load(object sender, EventArgs e)
        {
            //create tagObject for combos
            foreach (var ctl in this.Controls)
            {
                if (ctl is ComboBox)
                {
                    ComboBox cbo = (ComboBox)ctl;
                    switch (cbo.Name)
                    {
                        case "cboMSO":
                            CtlTag tag = new CtlTag();
                            tag.TableColumn = "MSO";
                            tag.ObjModel = "MSOModel";
                            tag.InitialLock = false;
                            cbo.Tag= tag;

                            //CommonOps.loadComboList(cbo)
                            CtlTag cTag = (CtlTag)cbo.Tag;

                            T  = CreateInstance<>(); 
                            List<MSO_Model> list = new List<MSO_Model>();
                            list = GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");


                            break;
                    }

                    CommonOps.loadComboList<CtlTag>((ComboBox)ctl);
                }
            }

            //CtlTag tag = new CtlTag();
            //tag.TableColumn = "MSO";
            //tag.ObjModel = "MSOModel";
            //tag.InitialLock = false;
            //cboMSO.Tag= tag;


        }

        private T CreateInstance<T>() where T: new()
        {
            return new T();
        }

    }
}
