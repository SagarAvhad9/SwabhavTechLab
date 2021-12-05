using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.onAddOperationCompleted += DisplayDetails;
            calculator.Add(10, 5);
            calculator.onSubstractOperationCompleted += DisplayDetails;
            calculator.Substract(10, 5);
            Console.ReadKey();

        }
        public static void DisplayDetails(string type,int a,int b,double c1)
        {
            Console.WriteLine("Type :{0} Value 1 :{1} Value2 :{2} Result :{3}",type,a,b,c1);
        }
    }
}
