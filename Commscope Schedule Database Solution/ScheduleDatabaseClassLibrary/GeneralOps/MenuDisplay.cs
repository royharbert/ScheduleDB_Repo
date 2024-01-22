using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class MenuDisplay
    {
        public static void DisplaySelectedMenu(Form activeMenu, Form hiddenMenu)
        {
            activeMenu.ShowDialog();
            hiddenMenu.Hide();
        }
    }
}
