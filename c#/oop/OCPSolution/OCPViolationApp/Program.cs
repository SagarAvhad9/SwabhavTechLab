using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPViolationApp.Model;

namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit("Sagar", 21000, 5, FestivalType.EID);
            Console.WriteLine(fd1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
