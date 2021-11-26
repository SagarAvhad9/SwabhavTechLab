using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = Convert.ToInt32(args[0]);
            int secondNo =Convert.ToInt32(args[1]);
            int result = firstNo / secondNo;
            Console.WriteLine("{0}/{1}={2}",firstNo,secondNo,result);
            Console.WriteLine("end of main");
            Main(args);
            Console.ReadKey();
           
        }
    }
}
