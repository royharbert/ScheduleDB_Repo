﻿using ScheduleDatabaseClassLibrary.Models;
using ScheduleDatabaseClassLibrary.Operations;
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
    public partial class frmMSO : Form
    {
        public frmMSO()
        {
            InitializeComponent();
        }

        private void frmMSO_Load(object sender, EventArgs e)
        {
            fillDGV();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            CommonOps.ToggleMSO_ActiveStatus(dgvMSO);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAddMSO = new frmMSO_Add();
            frmAddMSO.ShowDialog();
            fillDGV();
        }

        private void fillDGV()
        {
            List<MSO_Model> msoList = ScheduleDatabaseClassLibrary.GlobalConfig.Connection.GenericGetAll<MSO_Model>("tblMSO", "MSO");
            CommonOps.MakeMSO_StatusList(msoList, dgvMSO);
        }
    }
}
