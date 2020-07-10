using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Platform
    {
        //member variables
        public List<Product> inventory;

        //constructor
        public Platform()
        {
            inventory = new List<Product>();
            PopulateInventory(CreateProduct(1001, "Tires", "Auto", 129.99));
            PopulateInventory(CreateProduct(1002, "Wipers", "Auto", 12.99));
            PopulateInventory(CreateProduct(1003, "Freshner", "Auto", 2.99));

            PopulateInventory(CreateProduct(2001, "Baseball", "Sports", 9.99));
            PopulateInventory(CreateProduct(2002, "Basketball", "Sports", 12.99));
            PopulateInventory(CreateProduct(2003, "Shoes", "Sports", 89.99));

            PopulateInventory(CreateProduct(3001, "Headphones", "Electronics", 49.99));
            PopulateInventory(CreateProduct(3002, "Mouse", "Electronics", 89.99));
            PopulateInventory(CreateProduct(3003, "Keyboard", "Electronics", 109.99));
        }

        //methods
        private Product CreateProduct(int inventorySku, string name, string category, double price)
        {
            Product product = new Product(inventorySku, name, category, price);
            return product;
        }

        private void PopulateInventory(Product product)
        {
            inventory.Add(product);
        }

        public void UsePlatform(Consumer customer)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Online Web Store --- Welcome Customer {customer.returnFirstName()}");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("[1] Show Products\t[2] View Cart\t[3] Select Product");
                Console.WriteLine("---------------------------------");
                Console.Write("Please enter your selection: ");
                string selection;
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        customer.ShowProducts(inventory);
                        break;
                    case "2":
                        customer.ViewShoppingCart();
                        break;
                    case "3":
                        Product selectedProduct = GetProduct(customer.SearchForProduct());
                        DisplayProduct(selectedProduct, customer);
                        break;
                    default:
                        Console.Write("\nInvalid selection! Please try again: ");
                        break;
                }
            }
        }

        public Product GetProduct(string name)
        {
            while (true)
            {
                foreach (Product item in inventory)
                {
                    if (item.Name() == name)
                    {
                        return item;
                    }
                }
                Console.WriteLine($"{name} is not a valid product. ");
                foreach(Product product in inventory)
                {
                    Console.WriteLine(product.Name());
                }
                Console.Write("\nTry from the list above:");
                name = Console.ReadLine();
            }
        }
        public void DisplayProduct(Product product, Consumer customer)
        {
            Console.Clear();
            Console.WriteLine("SKU\tNAME\t\tPRICE\t\tAVERAGE RATING");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"{product.sku()}\t{product.Name()}\t${product.Price()}\t\t{product.AverageRating()}");
            product.ShowReview();
            
            Console.WriteLine("\n[1] Add to Cart\n[2] Write Review\n[3] Back to Menu");
            Console.Write("Please enter your selection: ");
            string selection;
            selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    customer.AddToCart(product);
                    break;
                case "2":
                    product.AddReview();
                    DisplayProduct(product, customer);
                    break;
                case "3":
                    break;
                default:
                    Console.Write("\nInvalid selection! Please try again: ");
                    DisplayProduct(product, customer);
                    break;
            }
        }
    }
}
