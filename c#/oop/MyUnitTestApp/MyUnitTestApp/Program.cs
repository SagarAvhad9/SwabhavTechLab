using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyUnitTestApp.Model;
namespace MyUnitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyUnitTestClass>().Count() > 0);
            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
                var methods = t.GetMethods().Where(m => m.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
                object obj = Activator.CreateInstance(t);
                Console.WriteLine("Number of Methods annoted: {0}", methods.Count());
                foreach (var m in methods)
                {
                    var a = m.Invoke(obj, null);
                    if (a.Equals(true))
                    {
                        Console.WriteLine(m.Name + " : --- passed");
                    }
                    else
                    {
                        Console.WriteLine(m.Name + " : --- failed");
                    }
                    
                }
            }   
            Console.ReadLine();
        }
    }
}
