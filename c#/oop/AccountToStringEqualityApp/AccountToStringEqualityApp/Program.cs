using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountToStringEqualityApp.Model;

namespace AccountToStringEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }
        public static void CaseStudy2()
        {
            Account a = new Account(101, "kunal", 10000);
            Account b = new Account(101, "vipul", 7000);
            
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine("refertial eqality :{0}",a == b);
            Console.WriteLine("value based equality :{0}",a.Equals(b));

        }

        public static void CaseStudy1()
        {
            Account a = new Account(101, "Sagar", 10000);
            Console.WriteLine(a);
            Console.WriteLine(a.ToString());
        }
    }
}
