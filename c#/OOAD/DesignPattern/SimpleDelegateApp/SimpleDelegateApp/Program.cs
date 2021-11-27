using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateApp
{
    delegate void DprintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DprintMessage f1;
            f1 = PrintHello;
            f1("Sagar");
            f1 = PrintGoodBye;
            f1("Kunal");
           // f1 = PrintFoo;
            MessageWizard(f1);
            MessageWizard(PrintHello);
            MessageWizard(PrintGoodBye);

            DprintMessage f2 = PrintHello;
            f2 += PrintGoodBye;
            f2 += PrintHello;
            f2 += PrintGoodBye;
            f2("Swabahv Tech");
            Console.ReadKey();


        }
        public static void PrintHello(string name)
        {
            Console.WriteLine("hello says {0}",name);
        }
        public static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye says {0}",name);
        }
        public static void PrintFoo()
        {

        }
        public static void MessageWizard(DprintMessage f)
        {
            Console.WriteLine("inside MessageWizrd");
            f("Sutar");
        }
    }
}
