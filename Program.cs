using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Models;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Product shirt = new Product();
            shirt.SetPrice(1500);
            shirt.SetName("US POLO");
            shirt.SetId(101);
            shirt.SetDiscount(20);

            Product shoes = new Product();
            shoes.SetPrice(2500);
            shoes.SetName("Nike");
            shoes.SetId(201);
            shoes.SetDiscount(15);

            void showDetails(Product name)
            {
                Console.WriteLine("Id: "+name.GetId());
                Console.WriteLine("Discount Applied :"+name.GetDiscount()+" percentage");
                Console.WriteLine("Product name: "+name.GetName());
                Console.WriteLine("Actual Price :"+name.GetPrice());
                Console.WriteLine("Selling price after discount: "+name.SellingPrice());
            }
            Console.WriteLine("Details of Product 1: \n");
            showDetails(shirt);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Details of Product 2: \n");
            showDetails(shoes);
            
        }
    }
}
