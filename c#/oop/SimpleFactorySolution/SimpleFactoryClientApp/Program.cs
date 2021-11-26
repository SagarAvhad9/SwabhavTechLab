using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Factory;

namespace SimpleFactoryClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Part1();
            Part2();
            Console.ReadKey();
        }

        private static void Part1()
        {
            var factory = new AutoMobileFactory();
            var auto = factory.Make(AutoType.TESLA);
            auto.Start();
            auto.Stop();
        }
        private static void Part2()
        {
            var factory1 =AutoMobileFactory.GetInstance();
            var auto1 = factory1.Make(AutoType.TESLA);
            auto1.Start();
            auto1.Stop();
            Console.WriteLine(factory1.GetHashCode());

            var factory2 = AutoMobileFactory.GetInstance();
            var auto2 = factory2.Make(AutoType.AUDI);
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(factory2.GetHashCode());
        }
    }
}
