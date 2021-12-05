using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public event Action<string, int, int, double> onAddOperationCompleted = null;
        public event Action<string, int, int, double> onSubstractOperationCompleted = null;
        public void Add(int a,int b)
        {
            var add = a + b;
            if (onAddOperationCompleted != null)
            {
                onAddOperationCompleted("Add", a, b, add);
            }
        }
        public void Substract(int a,int b)
        {
            var substract = a - b;
            if (onSubstractOperationCompleted != null)
            {
                onSubstractOperationCompleted("Substract", a, b, substract);
            }
        }
        
           
        
    }
}
