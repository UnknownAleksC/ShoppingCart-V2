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
        private int _price;

        public Product(string productName, int productPrice)
        {
            Name = productName;
            _price = productPrice;
        }

        public int CalculateOrderLinePrice(int amount)
        {
            int orderLinePrice = _price * amount;
            Console.WriteLine($"{amount}stk {Name}, {_price}kr per = {orderLinePrice}kr");
            return orderLinePrice;
        }
    }
}
