using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecuritySystemApp.Model;

namespace SecuritySystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityService secure = new SecurityService();
            secure.AddUser("1001", "Sagar", "Avhad", "savhad@gmail.com", "123789");
            secure.AddUser("1002", "aksha", "sawant", "savhad@gmail.com", "454500");
            secure.Login("1002", "455");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
