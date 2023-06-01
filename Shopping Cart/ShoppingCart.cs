using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class ShoppingCart
    {
        private List<CartItem> _cartItems;
        public void CreateCart()
        {
            _cartItems = new List<CartItem>();
            BuyProduct("Banana", 10, 5);
            BuyProduct("Banana", 10, 5);
            BuyProduct("Fluespray", 5, 20);
            BuyProduct("Kremflaske", 15, 10);
        }

        private void BuyProduct(string name, int price, int amount)
        {
            CartItem reoccurringItem = _cartItems.Find(x => x.GetProductName() == name);
            if (reoccurringItem == null)
                AddNewProduct(name, price, amount);
            else
            {
                reoccurringItem.AddAmount(amount);
                Console.WriteLine($"Du kjøpte {amount} flere stk. {name}");
            }
        }

        private void AddNewProduct(string name, int price, int amount)
        {
            var product = new Product(name, price);
            var cartItem = new CartItem(product, amount);
            _cartItems.Add(cartItem);
            Console.WriteLine($"Du kjøpte {amount} stk. {name}");
        }

        public void ShowCart()
        {
            if (_cartItems.Count == 0)
                Console.WriteLine("Handlekurven er tom.");
            else
            {
                Console.WriteLine("Handlekurv:");
                double totalPrice = 0;
                foreach (CartItem item in _cartItems)
                {
                    totalPrice += item.GetOrderLinePrice();
                }
                Console.WriteLine($"Totalpris: {totalPrice}kr");
            }
        }
    }
}
