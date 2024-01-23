using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;

namespace Schedule_Database_Desktop_Version
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void RefreshDashboard()
        {
            int thisYear = DateTime.Now.Year;
            DateTime newYearsDay = new DateTime(thisYear, 1, 1);
            DateTime today = DateTime.Now;
            List<LabEscModel> labEscModelYTD = GlobalConfig.Connection.GetDashboardData(newYearsDay, today, "DateOpened"
                )
        }
    }
}
