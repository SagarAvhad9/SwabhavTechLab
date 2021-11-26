using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Model;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.WriteLine("total occurances {0}",Product.Occurances);
            Console.ReadLine();
        }
        public static void CaseStudy1()
        {
            Product p1 = new Product(101, "head first java", 200);
            Product p2 = new Product(101, "head first java", 500,0.6f);
            PrintDetails(p1);
            PrintDetails(p2);     
        }
        public static void CaseStudy2()
        {
            Product p1 = new Product(101, "Head first Java", 200);
            Console.WriteLine("Count : {0}", p1.Count);
            Product p2 = new Product(102, "Head first C#", 300, 0.2f);
            Console.WriteLine("Count : {0}", p2.Count);
            Product p3 = new Product(103, "Head first", 700, 0.4f);
            Console.WriteLine("Count : {0}", p3.Count);
        }
        public static void PrintDetails(Product p)
        {
            Console.WriteLine("id {0} name {1} price {2} discountpercent {3} DicountPrice {4}",p.ID,p.Name,p.Price,p.DiscountPercent,p.Discount);
        }
    }
}
