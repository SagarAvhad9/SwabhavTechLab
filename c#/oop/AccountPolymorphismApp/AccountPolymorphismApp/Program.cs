using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPolymorphismApp.Model;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount A1 = new SavingAccount(101,"Sagar",5000);
            PrintDetails(A1);
            CurrentAccount A2 = new CurrentAccount(105, "Kunal",5000);
            PrintDetails(A2);
            A1.WithDraw(4501);
            PrintDetails(A1);
            A2.WithDraw(10000);
            PrintDetails(A2);
            Console.ReadKey();

        }
        public static void PrintDetails(Account a)
        {
            Console.WriteLine("Account No. :{0}",a.AccNo);
            Console.WriteLine("Name :{0}",a.Name);
            Console.WriteLine("Balance :{0}",a.Balance);


        }
    }
}
