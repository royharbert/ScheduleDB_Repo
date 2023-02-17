
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
        string[] _labels = null;
        public string[] Labels 
        {
            get
            {
                return Labels;
            }
            set
            {
                _labels = value;
                rdoDocCovid.Text = _labels[0];
                rdoDocCovid.Tag = _labels[0];
                rdoCRM.Text = _labels[1];
                rdoCRM.Tag = _labels[1];
                rdoTripRpt.Text = _labels[2];
                rdoTripRpt.Tag = _labels[2];
                rdoWRE.Text = _labels[3];
                rdoWRE.Tag = _labels[3];
                rdoOther.Text = _labels[5];
                rdoOther.Tag = "Other";
            } 
        }
        string thisType = "";
        public AttachmentModel model { get; set; }
        public event EventHandler<AttachmentModel> TypeReadyEvent;
        public frmAttType(AttachmentModel aModel)
        {
            model = aModel;
            InitializeComponent();
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (thisType == "Other" & txtOther.Text != "")
            {
                thisType = txtOther.Text;
            }
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
                txtOther.Enabled = true;
            }
            else
            {
                txtOther.Enabled = false;
            }
        }

        private void frmAttType_Load(object sender, EventArgs e)
        {
            FC.SetFormPosition(this);
        }
    }
}
