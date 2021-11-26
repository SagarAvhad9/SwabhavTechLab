using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnginneringApp.Model;

namespace EnginneringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmp p1 = new Professor(101, "Pune", "15/08/1970", 50000);
            SalaryEmp p2 = new Professor(102, "Mumbai", "19/09/1980", 70000);
            Student s1 = new Student(103, "Delhi", "23/04/1998", "Computer");
            Student s2 = new Student(104, "chennai", "22/03/1997", "IT");
            PrintDetails(p1);
            PrintDetails(p2);
            PrintDetails1(s1);
            PrintDetails1(s2);
            Console.ReadKey();
        }
        public static void PrintDetails(SalaryEmp p)
        {
            Console.WriteLine("\nId: " + p.Id);
            Console.WriteLine("Location: " + p.Address);
            Console.WriteLine("Date of Birth: " + p.Dateofbirth);
            Console.WriteLine("Basic Salary: " + p.Basicsalary);
            Console.WriteLine("salary with bonus:"+p.CalcSalary());
        }
        public static void PrintDetails1(Student s)
        {
            Console.WriteLine("\nId: " + s.Id);
            Console.WriteLine("Location: " + s.Address);
            Console.WriteLine("Date of Birth: " + s.DateOfBirth);
            Console.WriteLine("Branch: " + s.Branch);
        }
    }
}
