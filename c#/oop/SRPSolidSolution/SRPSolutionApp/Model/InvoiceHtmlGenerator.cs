using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRPSolutionApp.Model
{
    class InvoiceHtmlGenerator
    {
        public InvoiceHtmlGenerator(Invoice invoice)
        {
            PrintDetails(invoice);
        }
        public void PrintDetails(Invoice invoice)
        {
            string html = "<table>"; //cellpadding='1' cellspacing='0' style='width:30%;border:1px solid black;;font-size: 9pt;font-family:arial;'>";

            html += "<h1>Invoice</h1>";
            html += "<tr>";
            html += "<td><h3> Invoice Id:<h3></td>";
            html += "<td><h3>" + invoice.ID + "<h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Discription:<h3></td>";
            html += "<td><h3>" + invoice.Description + "<h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Tax Applied:<h3></td>";
            html += "<td><h3>" + invoice.Tax + "<h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Discount Applied:<h3></td>";
            html += "<td><h3>" + invoice.Discount + "<h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Discount Amount:<h3></td>";
            html += "<td><h3>" + invoice.CalculateDiscount() + "<h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Tax Amount:<h3></td>";
            html += "<td><h3>" + invoice.CalculateTax() + "<h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Final Amount:<h3></td>";
            html += "<td><h3>" + invoice.CalculateFinalAmount() + "<h3></td>";
            html += "</tr>";

            File.WriteAllText(@"F:\swabhavtech\c#\oop\SRPSolidSolution\index.html", html);
            Console.WriteLine("HTML File created.");

            /*Console.WriteLine("Invoice Id: {0}", invoice.ID);
            Console.WriteLine("Invoice Description: {0}", invoice.Description);
            Console.WriteLine("Invoice Amount: {0}", invoice.Amount);
            Console.WriteLine("Invoice GST tax: {0}%", invoice.Tax);
            Console.WriteLine("Invoice Discount: {0}%", invoice.Discount);
            Console.WriteLine("Discounted amount: {0}", invoice.CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", invoice.CalculateTax());
            Console.WriteLine("Final amount: {0}", invoice.CalculateFinalAmount());*/
        }

    }
}
