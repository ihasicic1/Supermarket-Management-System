using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System.Classes
{
    
    public class Product
    {
        public string type { get; set; }
        public double price { get; set; }

        public Product(string? type, double price)
        {
            this.type = type;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{type},{price.ToString(CultureInfo.InvariantCulture)}";
        }


    }
}
