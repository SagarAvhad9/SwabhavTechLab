using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.HighLevelModule;
using DIPSolutionApp.LowLevelModule;

namespace DIPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new TaxCalculator(new DBLogger());
            Console.WriteLine(cal.Calculte(25,2));
            Console.WriteLine(cal.Calculte(30,0));
            Console.ReadKey();
        }
    }
}
