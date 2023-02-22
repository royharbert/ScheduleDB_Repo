using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmAltMainMenu : Form
    {
        public frmAltMainMenu()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DateTime Start = DateTime.Parse("Apr 1, 2020");
            DateTime End = DateTime.Parse("Apr 28, 2021");
            //List<string> RIDs = getRIDs(Start, End);
            //RemoveAssignedFEs(RIDs);
        }

        private void frmAltMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
