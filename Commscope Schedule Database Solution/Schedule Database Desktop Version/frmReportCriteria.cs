﻿using System;
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
    public partial class frmReportCriteria : Form
    {
        public string ReturnValue { get; set; }


        public frmReportCriteria()
        {
            InitializeComponent();
        }

        private void frmReportCriteria_Load(object sender, EventArgs e)
        {
            ReturnValue = "Cancel";
        }
    }
}
