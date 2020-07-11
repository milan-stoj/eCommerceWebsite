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
            Platform mySite = new Platform();
            mySite.PrintHeader();
            Consumer customer = new Consumer();
            mySite.UsePlatform(customer, mySite);
        }
    }
}
