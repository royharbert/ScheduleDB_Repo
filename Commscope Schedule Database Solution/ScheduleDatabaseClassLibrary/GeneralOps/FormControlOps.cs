using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class FormControlOps
    {
        public static void markListBoxes(ListBox lb, string items)
        {
            string[] itemArray = items.Split(',');
            string matchString = "";
            foreach (var item in itemArray)
            {
                matchString = item.Trim();
                int match = lb.FindString(matchString);
                if (match > -1)
                {
                    lb.SetSelected(match, true);
                }
            }
        }
        public static void populateListItems<T>(ComboBox cbo, string tableName, string displayItem)
        {
            List<T> boxList = GlobalConfig.Connection.GenericGetAll<T>(tableName);
            cbo.DataSource = boxList;
            cbo.DisplayMember = displayItem;
            cbo.SelectedIndex = -1;
        }

        public static void populateListItems<T>(ListBox cbo, string tableName)
        {
            List<T> boxList = GlobalConfig.Connection.GenericGetAll<T>(tableName);
            cbo.DataSource = boxList;
            cbo.SelectedIndex = -1;
        }
    }

}
