using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountIdGenrate.Model;

namespace AccountIdGenrate
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            
            AccountId A1 = new AccountId("sagar",4000);
            AccountId A2 = new AccountId("Kunal", 3000);
            AccountId A3 = new AccountId("Preetam", 10000);
            Console.WriteLine(A1.Id);
            Console.WriteLine(A2.Id);
            Console.WriteLine(A3.Id);
            Console.WriteLine(A2.Id);
            Console.WriteLine("");
            PrintDeatils(A1);
            PrintDeatils(A2);
            PrintDeatils(A3);
            Console.WriteLine("-----------------------------------------------------------------------");

            Reflector r = new Reflector();
            r.DoReflector(typeof(Program));
        }
        public static void PrintDeatils(AccountId a)
        {
            Console.WriteLine("Name :{0} Balance :{1} Id :{2} Gender :{3}",a.Name,a.Balance,a.Id,a.Gender);
        }
    }
}
