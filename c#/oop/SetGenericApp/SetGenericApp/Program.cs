using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetGenericApp.Model;

namespace SetGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            HashSet<int> n = new HashSet<int>();
            n.Add(10);
            n.Add(200);
            n.Add(5);
            n.Add(5);
            n.Add(300);
            Console.WriteLine(n.Count());
            foreach(int item in n)
            {
                Console.WriteLine(item);
            }

        }
        public static void CaseStudy2()
        {
            Student student1 = new Student(101, "Sagar", "Mumbai");
            Student student2 = new Student(101, "Sagar", "Mumbai");
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student2.GetHashCode());
            HashSet<Student> students = new HashSet<Student>();
            students.Add(student1);
            students.Add(student2);
            Console.WriteLine(students.Count());

        }
        
    }
}
