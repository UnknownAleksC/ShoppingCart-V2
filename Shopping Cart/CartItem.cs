using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class CartItem
    {
        private Product _product;
        private int _amount;

        public CartItem(Product product, int amount)
        {
            _product = product;
            _amount = amount;
        }

        public void AddAmount(int amount)
        {
            _amount += amount;
        }

        public void GetOrderLinePrice()
        {
            _product.CalculateOrderLinePrice(_amount);
        }

        public string GetProductName()
        {
            return _product.GetName();
        }
    }
}
