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

        public void ShowProducts(List<Product> inventory)
        {
            Console.Clear();
            Console.WriteLine("ONLINE WEB STORE");
            Console.WriteLine("------------------------------------------");
            foreach (Product item in inventory)
            {
                Console.WriteLine(item.Name());
            }
            Console.WriteLine("These are the products currently in stock. Press enter to return to main menu.");
            Console.ReadLine();
        }

        public string SearchForProduct()
        {
            Console.Clear();
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

        public void ViewShoppingCart()
        {
            shoppingCart.ShowItems();
        }


    }
}
