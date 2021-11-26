using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployePolymorphismApp.Model;

namespace EmployePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe emp = new Accountant(101,"Sagar",25000);
            DisplaySalarySlip(emp);
            emp.Calculate();
            Console.WriteLine("----------------------------------");
            
            Employe emp1 = new Developer(501, "Shivam", 10000);
            DisplaySalarySlip(emp1);
            emp1.Calculate();
            Console.WriteLine("----------------------------------");

            Employe emp2 = new Manager(203, "Akshay", 20000);
            DisplaySalarySlip(emp2);
            emp2.Calculate();
            Console.WriteLine("----------------------------------");

            Console.ReadKey();

        }
        public static void DisplaySalarySlip(Employe E)
        {
            Console.WriteLine( E.GetType().Name);
            Console.WriteLine("EmpNo :{0} Name:{1} Salary:{2}",E.EmpNo,E.Name,E.BasicSalary);

        }
    }
}
