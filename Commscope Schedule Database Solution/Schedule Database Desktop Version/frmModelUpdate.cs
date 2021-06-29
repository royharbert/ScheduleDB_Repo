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
    public partial class frmModelUpdate : Form
    {
        public frmModelUpdate()
        {
            InitializeComponent();
        }

        private void frmModelUpdate_Load(object sender, EventArgs e)
        {
            UpdaterModel<FE_Model> model = new UpdaterModel<FE_Model>();
        }

        private void rdoFE_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            string senderName = button.Name;
            //setDataModel(senderName);
        }

        //private UpdaterModel<T> setDataModel(string senderName)
        //{
        //    List<UpdaterModel<FE_Model>> modelList = new List<UpdaterModel<FE_Model>>();
        //    switch (senderName)
        //    {                
        //        case "rdoFE":
        //            modelList = GlobalConfig.Connection.GenericGetAll<UpdaterModel<FE_Model>>("tblFE");
        //            break;
        //        case "rdoUser":
        //            UpdaterModel < UserModel > = new UpdaterModel<UpdaterModel>();
        //            (UserModel)modelList = GlobalConfig.Connection.GenericGetAll<UpdaterModel<UserModel>>("tblUsers");
        //            break;
        //        default:
        //            break;
        //    }

        //    return modelList;
        //}
    }
}
