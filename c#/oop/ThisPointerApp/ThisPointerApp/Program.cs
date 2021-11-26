using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisPointerApp.Model;

namespace ThisPointerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("sachin",50,GenderType.Male);
            Player p2 = new Player("virat");
            PrintDetails(p1);
            PrintDetails(p2);
            
            Player elder = p1.WhoIsElder(p2);
            PrintDetails(elder);
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(elder.GetHashCode());
            Console.ReadKey();
        }
        public static void PrintDetails(Player p)
        {
            Console.WriteLine("name:{0},age:{1},gender:{2}",p.Name,p.Age,p.Gender);
        }

    }
}
