using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class ShoppingCart
    {
        List<Product> products;
        double totalCostProducts;

        //constructor
        public ShoppingCart()
        {
            products = new List<Product>();
            totalCostProducts = 0;
        }

        //methods
        public void AddToCart(Product product)
        {
            products.Add(product);
        }

        public void RemoveFromCart(Product product)
        {
            products.Remove(product);
        }

        public void ShowItems()
        {
            Console.Clear();
            if (products.Count() == 0)
            {
                Console.WriteLine("The cart is empty. Press enter to return to the main menu.");
                Console.ReadLine();
            }
            else
            {
                double cartTotal = 0;
                foreach (Product item in products)
                {
                    cartTotal += item.Price();
                    Console.WriteLine($"{item.Name()} ---- ${item.Price()}");
                }
                Console.WriteLine($"Cart Total: ${cartTotal}");
                Console.WriteLine($"Press enter to return to main menu.");
                Console.ReadLine();
            }
        }
    }
}
