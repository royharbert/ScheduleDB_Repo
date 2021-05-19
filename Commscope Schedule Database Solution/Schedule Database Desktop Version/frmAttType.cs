
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

    public partial class frmAttType : Form
    {
        string thisType = "";
        //AttachmentModel model = null;
        public AttachmentModel model { get; set; }
        public event EventHandler<AttachmentModel> TypeReadyEvent;
        public frmAttType(AttachmentModel aModel)
        {
            model = aModel;
            InitializeComponent();
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {           
            model.ItemType = thisType;

            TypeReadyEvent?.Invoke(this, model);
            this.Close();
        }

        private void rdoDocCovid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                thisType = rb.Tag.ToString();
            }
        }

        private void rdoCRM_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                thisType = rb.Tag.ToString();
            }
        }

        private void rdoTripRpt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                thisType = rb.Tag.ToString();
            }
        }

        private void rdoWRE_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                thisType = rb.Tag.ToString();
            }
        }

        private void rdoRoster_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                thisType = rb.Tag.ToString();
            }
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                thisType = rb.Tag.ToString();
            }
        }
    }
}
