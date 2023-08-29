using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        public int UnitPrice { get; set; }
        public int OrderedCount { get; set; }
        public Product Product { get; set; }

        public Order Order { get; set; }    
    }
}
