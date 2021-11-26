using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorApp.Model;

namespace HatDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IHat hat = new RibbonedHat(new GoldenHat(new StandardHat()));
            Console.WriteLine(hat.GetName());
            Console.WriteLine(hat.GetDescription());
            Console.WriteLine(hat.GetPrice());
            Console.ReadKey();
        }
    }
}
