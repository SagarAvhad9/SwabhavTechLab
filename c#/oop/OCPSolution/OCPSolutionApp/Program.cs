using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Lib;
using OCPSolutionApp.Client;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("sagar",10000,5,new DiwaliFestivalPolicy());
            Console.WriteLine("Simple Interest:{0}",fd1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
