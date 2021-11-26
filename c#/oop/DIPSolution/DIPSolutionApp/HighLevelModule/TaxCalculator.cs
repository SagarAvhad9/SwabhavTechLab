using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.CommonModule;

namespace DIPSolutionApp.HighLevelModule
{
    class TaxCalculator
    {
        private ILogger _policy;
        public TaxCalculator(ILogger policy)
        {
            this._policy = policy;
            Console.WriteLine(_policy.Log());
        }

        public int Calculte(int value1, int value2)
        {
            int result = 0;
            try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
