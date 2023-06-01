using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class ShoppingCart
    {
        public List<CartItem> CartItems;
        public void CreateCart()
        {
            CartItems = new List<CartItem>();
            BuyProduct("Banana", 10, 5);
            BuyProduct("Banana", 15, 5);
            BuyProduct("Fluespray", 5, 20);
            BuyProduct("Kremflaske", 15, 10);
        }

        private void BuyProduct(string name, int price, int amount)
        {
            CartItem reoccurringItem = CartItems.FirstOrDefault(x => x.Product.Name == name);
            if (reoccurringItem == null)
                AddNewProduct(name, price, amount);
            else
                AddExistingProduct(price, amount, reoccurringItem);
        }

        private void AddNewProduct(string name, int price, int amount)
        {
            var product = new Product(name, price);
            var cartItem = new CartItem(product, amount);
            CartItems.Add(cartItem);
            Console.WriteLine($"Du kjøpte {cartItem.Amount} stk. {cartItem.Product.Name}");
        }

        private void AddExistingProduct(int price, int amount, CartItem reoccurringItem)
        {
            var product = reoccurringItem.Product;
            CartItems.Remove(reoccurringItem);
            reoccurringItem.AddAdditionalProduct(amount, price);
            CartItems.Add(reoccurringItem);
            Console.WriteLine($"Du kjøpte {amount} flere stk. {product.Name}");
        }
    }
}
