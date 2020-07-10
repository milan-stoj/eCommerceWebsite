using eCommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Product ball = new Product(1001, "Ball", "Sports", 4.99);
            Product keyboard = new Product(1002, "Keyboard", "Electronics", 49.99);
            Product mouse = new Product(1003, "Mouse", "Electronics", 29.99);
            Product speakers = new Product(1004, "Speakers", "Electronics", 39.99);
            Product tent = new Product(1005, "Camping Tent", "Outdoors", 299.99);

            Platform mySite = new Platform();
            Consumer customer = new Consumer();
            mySite.UsePlatform(customer);
        }
    }
}
