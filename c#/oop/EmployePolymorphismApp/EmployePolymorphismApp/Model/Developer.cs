using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePolymorphismApp.Model
{
    class Developer:Employe
    {
        double PA;
        double OT;
       
        public Developer(int empno, string name, double basicSalary):base(empno,name,basicSalary)
        {

        }
        public override void Calculate()
        {
            PA = (double)40 / 100 * BasicSalary;
            OT = (double)30 / 100 * BasicSalary;
            Console.WriteLine("PA salary :{0}",PA);
            Console.WriteLine("OT Salary :{0}",OT);
            
        }
    }
}
