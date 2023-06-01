using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class Product
    {
        public string Name;
        public double Price;

        public Product(string productName, double productPrice)
        {
            Name = productName;
            Price = productPrice;
        }
    }
}
