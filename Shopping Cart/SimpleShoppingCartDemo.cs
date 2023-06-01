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
            _shoppingCart.ShowCart();
        }
    }
}
