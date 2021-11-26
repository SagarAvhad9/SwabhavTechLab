using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPSolutionApp.Model;

namespace SRPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Bank Invoice", 100000, 10f, 50);
            InvoiceHtmlGenerator html = new InvoiceHtmlGenerator(invoice);
            Console.ReadKey();
        }
    }
}
