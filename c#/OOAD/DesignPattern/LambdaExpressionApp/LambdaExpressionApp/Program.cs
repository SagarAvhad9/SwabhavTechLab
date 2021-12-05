using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> PrintHowdy = (n) => Console.WriteLine("Howdy Says "+n);
            PrintHowdy("Sagar");
            Action<string, string> PrintFullName = (fn, ln) => Console.WriteLine("First Name is {0} Last Name is {1}",fn,ln);
            PrintFullName("Sagar", "Avhad");
            Func<int, int, long> calArea = (w, h) => w * h;
            Console.WriteLine("Result of Area Calculate "+calArea(5,6));
            Predicate<string> isLongName = (name) => name.Length > 8;
            Console.WriteLine(isLongName("abc"));
            string userName = "SwabahvTechLabs";
            Console.WriteLine("Is {0} a long name ? {1}",userName,isLongName(userName));
            Console.ReadKey();
        }
    }
}
