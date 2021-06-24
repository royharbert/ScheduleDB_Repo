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
    }
}
