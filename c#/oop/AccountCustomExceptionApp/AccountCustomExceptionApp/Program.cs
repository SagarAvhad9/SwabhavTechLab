using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountCustomExceptionApp.Model;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(104, "Sagar", 5000);
            try
            {
                account1.Withdraw(4501);
            }
            catch (InsufficientFundException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nexecutes no matter exceptions or not");
                PrintDetails(account1);
            }
            Console.WriteLine("end of main");
            Console.ReadLine();
        }
        public static void PrintDetails(Account a)
        {
            Console.WriteLine("Account No: {0}", a.AccNo);
            Console.WriteLine("Account Name: {0}", a.Name);
            Console.WriteLine("Account Balance: {0}", a.Balance);
        }


    }
}

