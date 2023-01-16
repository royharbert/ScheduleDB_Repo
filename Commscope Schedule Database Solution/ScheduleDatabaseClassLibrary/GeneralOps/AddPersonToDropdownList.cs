using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class AddPersonToDropdownList
    {
        public static string[] ParsePerson(ComboBox cbo, string nameEntered)
        {
            string[] nameArray = nameEntered.Split(' ');
            string fn = nameArray[0];
            string ln = "";
            for (int i = 1; i < nameArray.Length; i++)
            {
                ln=ln + nameArray[i] + " ";
            }
            ln = ln.Substring(0, ln.Length - 1);
            string[] result = new string[2];
            result[0] = fn;
            result[1] = ln;

            return result;            
        }
    }
}
