using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudableApp.Model;

namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperations(new ProductDB());
            DoDBOperations(new OrderDB());
            DoDBOperations(new PremiumCustomerDB());
            Console.ReadKey();
            
        }
        public static void DoDBOperations(ICrudable obj)
        {
            Console.WriteLine("Doing all DB Operations,please wait");
            obj.Create();
            obj.Update();
            obj.Read();
            obj.Delete();
        }
    }
}
