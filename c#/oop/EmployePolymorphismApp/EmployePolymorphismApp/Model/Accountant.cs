using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePolymorphismApp.Model
{
    class Accountant:Employe
    {
        double _Perks;
        
        public Accountant(int empno, string name, double basicSalary) :base(empno,name,basicSalary)
        {

        }
        public override void Calculate()
        {
            _Perks = (double)30 / 100 * BasicSalary;
            Console.WriteLine("Perks Salary :{0}",_Perks);
        }
    }
}
