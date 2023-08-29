using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int ID { get; set; }

        public string NameEn { get; set; }

        public string NameAr { get; set; }
        public int CategoryID { get; set; }

        public int StockQuantity { get; set; }

        public decimal UnitPrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
