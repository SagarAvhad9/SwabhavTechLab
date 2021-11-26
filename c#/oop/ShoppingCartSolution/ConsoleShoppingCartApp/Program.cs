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
            Customer customer = new Customer(101, "Sagar");

            Order order1 = new Order(1001, new DateTime(2021, 01, 1));
            order1.AddItem(new LineItem(1, new Product(401, "Cadbury", 20, 50), 4));
            order1.AddItem(new LineItem(2, new Product(401, "Cadbury", 20, 50), 10));

            Order order2 = new Order(1002, new DateTime(2021, 05, 18));
            order2.AddItem(new LineItem(1, new Product(603, "Laptop", 56000, 50), 1));
            order2.AddItem(new LineItem(2, new Product(106, "scale", 10, 50), 10));
            order2.AddItem(new LineItem(3, new Product(108, "Alexa", 1224, 50), 2));


            customer.AddOrder(order1);
            customer.AddOrder(order2);


            PrintDetails(customer);
            Console.ReadLine();
        }

        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine($"Customer : {customer.Name}");
            Console.WriteLine($"Number of orders : {customer.OrderCount}");

            foreach (var orderitems in customer.Order)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Order Number : {orderitems.Id}");
                Console.WriteLine($"Order Date : {orderitems.Date}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Order Details:");
                Console.WriteLine($"Number of Lineitems  : {orderitems.ItemCount}");
                foreach (var items in orderitems.Items)
                {
                    Console.WriteLine($"\n-LineItem id : {items.Id}");
                    Console.WriteLine($"-->Product id : {items.Product.Id}");
                    Console.WriteLine($"--Product Name : {items.Product.Name}");
                    Console.WriteLine($"--Product Price : {items.Product.Price}");
                    Console.WriteLine($"--Discounted Price : {items.Product.DiscountAmount}");
                    Console.WriteLine($"--Quentity : {items.Quantity}");
                    Console.WriteLine($"LineItem total price : {items.Calculate()}");
                }
                Console.WriteLine($"Order Total : {orderitems.GetOrderTotal()}");
            }
          //  Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total of customer {customer.Name} is {customer.CustomerTotal()}");
           // Console.WriteLine("---------------------------------------");
        }
    }
}
