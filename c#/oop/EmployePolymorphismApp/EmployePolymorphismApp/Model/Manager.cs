using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePolymorphismApp.Model
{
    class Manager:Employe
    {
        double HRA;
        double TA;
        double DA;
       
        
        public Manager(int empno,string name,double basicSalary):base(empno,name,basicSalary)
        {
                
        }
        public override void Calculate()
        {
            HRA = (double)50 / 100 * BasicSalary;
            TA = (double)40 / 100 * BasicSalary;
            DA = (double)30 / 100 * BasicSalary;
            Console.WriteLine("HRA Salary :{0}",HRA);
            Console.WriteLine("TA Salary :{0}",TA);
            Console.WriteLine("DA Salary :{0}",DA);
        }
    }
}
