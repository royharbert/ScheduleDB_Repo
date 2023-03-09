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
            string[] result = new string[4];
            string fn = nameArray[0];
            string ln = "";
            if(nameArray.Length > 1) 
            {
                for (int i = 1; i < nameArray.Length; i++)
                {
                    ln = ln + nameArray[i] + " ";
                }
                ln = ln.Substring(0, ln.Length - 1);
                result = new string[2];
                result[0] = fn;
                result[1] = ln;
            }
            else
            {
                result[0] = fn;
                //result[1] = fn;
            }

            return result;            
        }
    }
}
