using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }

        public decimal TotalPrice { get; set; }
        public Status Status { get; set; }
        public int CustomerID { get; set; } 
        public Customer Customer { get; set; } = null!;
    }
    public enum Status
    {
        pending,
        Approved,
        Declined,
        Shipped,
        Delivered
    }
}
