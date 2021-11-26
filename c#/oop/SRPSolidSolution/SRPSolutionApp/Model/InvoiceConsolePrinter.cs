using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Model
{
    class InvoiceConsolePrinter
    {
        public InvoiceConsolePrinter(Invoice invoice)
        {
            PrintDetails(invoice);
            Console.ReadKey();
        }
        public void PrintDetails(Invoice invoice)
        {
            Console.WriteLine("Invoice Id: {0}",invoice.ID);
            Console.WriteLine("Invoice Description: {0}",invoice.Description);
            Console.WriteLine("Invoice Amount: {0}",invoice.Amount);
            Console.WriteLine("Invoice GST tax: {0}%",invoice.Tax);
            Console.WriteLine("Invoice Discount: {0}%",invoice.Discount);
            Console.WriteLine("Discounted amount: {0}",invoice.CalculateDiscount());
            Console.WriteLine("Tax amount: {0}",invoice.CalculateTax());
            Console.WriteLine("Final amount: {0}",invoice.CalculateFinalAmount());
        }
    }
}
