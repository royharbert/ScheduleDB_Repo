using ScheduleDatabaseClassLibrary.GeneralOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class ProductModel : IHaveID
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public string ProductClass { get; set; }
        public override string ToString()
        {
            return this.Product;
        }
    }

}
