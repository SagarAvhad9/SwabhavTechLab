using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPVoilationApp.HighLevelModule;

namespace DIPVoilationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new TaxCalculator(LogPolicyType.DB);
            Console.WriteLine(cal.Calculte(25,5));
            Console.WriteLine(cal.Calculte(30,0));
            Console.ReadKey();
        }
    }
}
