using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePolymorphismApp.Model
{
    abstract class Employe
    {
        protected int _empNo;
        protected string _name;
        protected double _basicSalary;

        public Employe(int empno,string name,double basicSalary)
        {
            _empNo = empno;
            _name = name;
            _basicSalary = basicSalary;
        }
        public abstract void Calculate();
        
        public int EmpNo
        {
            get
            {
                return _empNo;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double BasicSalary
        {
          
            get
            {
                return _basicSalary;
            }
            
        }


    }
}
