using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartLib.Model;

namespace ConsoleShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(100, "Sagar");
            Order order = new Order(101, DateTime.Today);
            order.AddItem(new LineItem(1, new Product(101, "tv", 500, 0.5f), 1));

            PrintDetails(customer);
            Console.ReadKey();
        }
        public static void PrintDetails(Customer c1)
        {
            Console.WriteLine("Customer ID:{0}", c1.Id);
            Console.WriteLine("Customer Name:{0}", c1.Nmae);
            Console.WriteLine("Orders :");
            foreach (var orderitems in c1.Order)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Order Number : {orderitems.Id}");
                Console.WriteLine($"Order Date : {orderitems.Date}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Order Details:");
                Console.WriteLine($"Number of Lineitems  : {orderitems.ItemCount}");

            }
        }
    }
}
