using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    delegate void DMathOperations(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            DMathOperations f1;
            f1 = Add;
            f1 += Subtract;
            f1 += Modulus;
            f1 += Division;
            f1(5, 3);

            Console.ReadKey();


        }
        public static void Add(int a, int b)
        {
            Console.WriteLine("Add is : " + (a + b));
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract is : " + (a - b));
        }
        public static void Modulus(int a, int b)
        {
            Console.WriteLine("Modulus is : " + (a % b));
        }
        public static void Division(int a, int b)
        {
            float result = a / b;

            Console.WriteLine("Division is : " + result);
        }
    }
}
