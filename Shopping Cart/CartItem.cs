using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class CartItem
    {
        public Product Product;
        public int Amount;

        public CartItem(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }

        public void AddAdditionalProduct(int newItemAmount, int newItemPrice)
        {
            Product.Price = (Product.Price * Amount + newItemPrice * newItemAmount) / (Amount + newItemAmount);
            Amount += newItemAmount;
        }

        public double CalculateOrderLinePrice()
        {
            double orderLinePrice = Product.Price * Amount;
            Console.WriteLine($"{Amount}stk {Product.Name}, {Product.Price}kr per = {orderLinePrice}kr");
            return orderLinePrice;
        }
    }
}
