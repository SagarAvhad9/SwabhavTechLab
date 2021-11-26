using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    { 
        
        public static void Main(string[] args)
        {
            PrintDetails(100);
            PrintDetails("Hello");
            PrintDetails(100.55);
            PrintDetails(100.55f);
            PrintDetails(true);
            PrintDetails('#');
            Console.ReadKey();
        } 
        private static void PrintDetails(int content)
        {
            Console.WriteLine("overeLoad #1 : Integer");
            Console.WriteLine(content);

        }     

        private static void PrintDetails(string content)
        {
            Console.WriteLine("overeLoad #2 : Character");
            Console.WriteLine(content);

        }

        private static void PrintDetails(double  content)
        {
            Console.WriteLine("overeLoad #3 : String ");
            Console.WriteLine(content);

        }

        private static void PrintDetails(float content)
        {
            Console.WriteLine("overeLoad #4 : float");
            Console.WriteLine(content);

        }

        private static void PrintDetails(bool content)
        {
            Console.WriteLine("overeLoad #5 : float");
            Console.WriteLine(content);

        }

        private static void PrintDetails(char content)
        {
            Console.WriteLine("overeLoad #6 : char");
            Console.WriteLine(content);

        }

    }
}
