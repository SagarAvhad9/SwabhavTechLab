using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SingletonPatternApp.Model;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var sv1 = new DataService();
            // var sv2 = new DataService();
            // Part3();
            Part4();
            Console.ReadKey();

        }

        private static void Part3()
        {
            var sv1 = DataService.GetInsatance();
            var sv2 = DataService.GetInsatance();
            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());
            sv1.DoSomething();
            sv2.DoSomething();
        }
        public static void Part4()
        {
            Thread t1 = new Thread(() =>
            {
                DataService.GetInsatance().DoSomething();
            });
            Thread t2 = new Thread(() =>
            {
                DataService.GetInsatance().DoSomething();
            });

            t1.Start();
            t2.Start();
        }

    }
}
