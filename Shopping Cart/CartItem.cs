using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class CartItem
    {
        public Product Product { get; }
        private int _amount;

        public CartItem(Product product, int amount)
        {
            Product = product;
            _amount = amount;
        }

        public void AddAmount(int amount)
        {
            _amount += amount;
        }

        public int ShowOrderLinePrice()
        {
            return Product.CalculateOrderLinePrice(_amount);
        }
    }
}
