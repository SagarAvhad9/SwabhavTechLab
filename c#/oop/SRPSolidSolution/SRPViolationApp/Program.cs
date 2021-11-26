using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPViolationApp.Model;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Bank Invoice", 100000, 10f, 50);
            invoice.PrintDetails();
            Console.ReadKey();
            
        }
    }
}
