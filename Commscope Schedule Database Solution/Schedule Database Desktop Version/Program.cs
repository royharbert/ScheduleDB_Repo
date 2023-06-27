using ScheduleDatabaseClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.DatabaseMode == 1)
            {
                GlobalConfig.SetDatabaseMode(DatabaseType.Live);
            }
            else
            {
                GlobalConfig.SetDatabaseMode(DatabaseType.Sandbox);
            }
            Application.Run(new frmAMDI_Parent());
            //Application.Run(new frmLink());
        }
    }
}
