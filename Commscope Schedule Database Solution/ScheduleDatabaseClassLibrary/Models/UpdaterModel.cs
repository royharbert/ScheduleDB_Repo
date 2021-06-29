using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class UpdaterModel<T>
    {
        public List<T> dataList { get; set; }
    }
}
