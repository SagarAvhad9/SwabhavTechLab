using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEncapsulationApp.Model;

namespace AccountEncapsulationApp
{
    class Program
    { 
       

        static void Main(string[] args)
        {
            Account[] a = new Account[4];
            a[0] = new Account(101,"sagar", 1000);
            a[0].Deposit(1000);
          //  a[0].Withdraw(1501);
            a[1] = new Account(102, "kunal", 10000);
            a[2] = new Account(103, "Preetam", 2000);
            a[3] = new Account(104, "shiavm", 20000);

            PrintArray(a);
            Console.WriteLine("\n");
            RichPerson(a);
            
            Console.ReadKey();




        }
        public static void PrintArray(Account[] a)
        {
            
            for( int i=0; i < a.Length; i++)
            {
                PrintDetails(a[i]);
                
            }
        }
        public static void PrintDetails(Account a)
        {
            Console.WriteLine("\nAccountNumber :{0} name:{1} Balance :{2}", a.AccountNumber,a.Name,a.Balance);
        }
        public static void RichPerson(Account[] a)
        {
            double richUser,remainingAmount,disAmt;
            int count = 0;
            richUser = a[0].Balance;
            for(int i = 1; i < a.Length; i++)
            {
                if (a[i].Balance > richUser)
                {
                    richUser = a[i].Balance;
                    count = i;
                }
            }
            Console.WriteLine("RichUser");
            Console.WriteLine("AccountNumber :{0} name:{1} Balance :{2}", a[count].AccountNumber, a[count].Name, a[count].Balance);

            remainingAmount = richUser - 500;
            disAmt = remainingAmount / (a.Length-1);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[count])
                {
                    a[count].Withdraw(remainingAmount);
                }
                else
                {
                    a[i].Deposit(disAmt);
                }
            }
            a[3].Withdraw(1);
            Console.WriteLine("\nDistributed Amount");
            PrintArray(a);
        }
    }
}
