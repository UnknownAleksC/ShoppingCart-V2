using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class Simple_shoppingCartDemo
    {
        private static ShoppingCart _shoppingCart;

        public static void Run()
        {
            _shoppingCart = new ShoppingCart();
            _shoppingCart.CreateCart();
            ShowCart();
        }

        private static void ShowCart()
        {
            if (_shoppingCart.CartItems.Count == 0)
                Console.WriteLine("Handlekurven er tom.");
            else
            {
                Console.WriteLine("Handlekurv:");
                double totalPrice = 0;
                foreach (CartItem item in _shoppingCart.CartItems)
                {
                    totalPrice += item.CalculateOrderLinePrice();
                }

                Console.WriteLine($"Totalpris: {totalPrice}kr");
            }
        }
    }
}
