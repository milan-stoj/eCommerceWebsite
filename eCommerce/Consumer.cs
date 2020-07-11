using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Consumer
    {
        string firstName;
        string lastName;
        ShoppingCart shoppingCart;


        //constructor
        public Consumer()
        {
            firstName = SetFirstName();
            lastName = SetLastName();
            shoppingCart = new ShoppingCart();
        }


        //methods
        public string SetFirstName()
        {
            
            Console.Write("Please enter your first name: ");
            return Console.ReadLine();
        }

        public string returnFirstName()
        {
            return firstName;
        }

        public string SetLastName()
        {
            Console.Write("Please enter your last name: ");
            return Console.ReadLine();
        }

        public void ShowProducts(List<Product> inventory, Platform platform)
        {
            Console.Clear();
            platform.PrintHeader();

            foreach (Product item in inventory)
            {
                Console.WriteLine(item.Name());
            }
            Console.WriteLine("\nThese are the products currently in stock. Press enter to return to main menu.\n");
            Console.ReadLine();
        }

        public string SearchForProduct(Platform platform)
        {
            platform.PrintHeader();
            Console.Write("Enter Product Name: ");
            return Console.ReadLine();
        }

        public void ProductSelections()
        {

        }

        public void AddToCart(Product product)
        {

            shoppingCart.AddToCart(product);
        }

        public void ViewShoppingCart(Platform platform)
        {
            platform.PrintHeader();
            shoppingCart.ShowItems();
        }


    }
}
