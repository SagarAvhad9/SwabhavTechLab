using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateAppV2
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;
            f1 = (n) =>
            {
                Console.WriteLine("inside lambda 1");
                Console.WriteLine("Howdy Says " + n);
            };
            f1("Sagar");
            f1 = (n) =>
            {
                Console.WriteLine("Ola .. Says " + n);

            };
            f1("Swabahv");
        }

    }
}
