using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer : User

    {
        public int Phone { get; set; }
        public string Address { get; set; }

        public Order? Order { get; set; }
    }
}
