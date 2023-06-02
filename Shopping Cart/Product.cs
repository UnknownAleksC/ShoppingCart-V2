using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class Product
    {
        private string _name;
        private int _price;

        public Product(string productName, int productPrice)
        {
            _name = productName;
            _price = productPrice;
        }

        public void CalculateOrderLinePrice(int amount)
        {
            var orderLinePrice = _price * amount;
            Console.WriteLine($"{amount}stk {_name}, {_price}kr per = {orderLinePrice}kr");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
