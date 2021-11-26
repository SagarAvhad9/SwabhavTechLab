using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CollectionApp.Model;
namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //CaseStudy1();
            CaseStudy2();

            Console.ReadLine();
        }

        private static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("Bag", 500, 3));
            basket.Add(new LineItem("Pen", 100, 1));
            basket.Add(new LineItem("Choclate", 400, 4));
            basket.Add("Hello AurionPro");

            double FinalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("ProductName :{0} Price :{1} Quantity :{2}",item.ProductName,item.Price,item.Quantity);
                Console.WriteLine("TotalPrice :{0}",item.TotalPrice());
                FinalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Price :{0}", FinalPrice);
        }
        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("Bag", 500, 3));
            basket.Add(new LineItem("Pen", 100, 1));
            basket.Add(new LineItem("Choclate", 400, 4));
            

            double FinalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("ProductName :{0} Price :{1} Quantity :{2}", item.ProductName, item.Price, item.Quantity);
                Console.WriteLine("TotalPrice :{0}", item.TotalPrice());
                FinalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Price :{0}", FinalPrice);
        }
    }
}
