using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public static class AttachmentProcs
    {
        /// <summary>
        /// Returns complete model of attachment
        /// Saves attachment to DB
        /// </summary>
        /// <param name="callingForm"></param>
        /// <returns></returns>
        public static List<AttachmentModel> AttachFile(Form callingForm, string PID)
        {
            GV.MODE = Mode.Add_Attachment;
            AttachmentModel model = new AttachmentModel();
            frmAttType frm = new frmAttType(model);
            EventHandler<AttachmentModel> Frm_TypeReadyEvent = null;
            frm.TypeReadyEvent += Frm_TypeReadyEvent;

            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Save Attachment";
            string myDox = Environment.SpecialFolder.MyDocuments.ToString();
            openFD.InitialDirectory = myDox;
            openFD.RestoreDirectory = true;
            openFD.Multiselect = false;
            
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string fullFileName = openFD.FileName;
                string file = Path.GetFileName(fullFileName);
                model.FileToSave = fullFileName;
                model.DisplayText = file;
                model.PID = PID;
                //FC.SetFormPosition(frm);
                callingForm.BringToFront();
                frm.ShowDialog();
            }
            string fileName = GlobalConfig.AttachmentPath + "\\" + model.PID + "\\" + model.DisplayText;
            FileOps.SaveAttFile(model);
            GlobalConfig.Connection.InsertInto_tblAttachments(model);
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(PID);
            return aList;
        }

        private static void Frm_TypeReadyEvent(object sender, AttachmentModel e)
        {
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(e.PID);
            //dgvAttachments.DataSource = null;
            //dgvAttachments.DataSource = aList;
            //formatAttGrid();
        }

        public static void AttachmentsRowHeaderClick(DataGridView dgv)
        {
            List<AttachmentModel> aList = (List<AttachmentModel>)dgv.DataSource;
            int selRow = dgv.CurrentRow.Index;
            AttachmentModel model = aList[selRow];

            string fileName = dgv.CurrentRow.Cells[2].Value.ToString();
            fileName = GlobalConfig.AttachmentPath + "\\" + model.PID + "\\" + fileName;
            ProcessStartInfo sinfo = new ProcessStartInfo(fileName);
            try
            {
                Process.Start(sinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + fileName);
            }
        }
    }
}
