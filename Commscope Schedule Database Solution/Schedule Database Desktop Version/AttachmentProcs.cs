using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
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
        public static AttachmentModel GetAttachmentType(Form callingForm, string PID)
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

            //List<string> fileNames = new List<string>();
            //fileNames.Add(model.FileToSave);
            //fileNames.Add(model.DisplayText);
            string fileName = GlobalConfig.AttachmentPath + "\\" + model.PID + "\\" + model.DisplayText;
            FileOps.SaveAttFile(model);
            GlobalConfig.Connection.InsertInto_tblAttachments(model);

            return model;
        }

        private static void Frm_TypeReadyEvent(object sender, AttachmentModel e)
        {
            List<AttachmentModel> aList = GlobalConfig.Connection.GetAttachments(e.PID);
            //dgvAttachments.DataSource = null;
            //dgvAttachments.DataSource = aList;
            //formatAttGrid();
        }
    }
}
