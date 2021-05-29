using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class DB_TableToHashTable
    {
        public static Hashtable dbTableToHashTable<T>(List<T> myList) where T : IHaveID
        {            
            Hashtable table = new Hashtable();
            foreach (var item in myList)
            {
                table.Add(item.ID, item);
            }

            return table;
        }
    }
}
