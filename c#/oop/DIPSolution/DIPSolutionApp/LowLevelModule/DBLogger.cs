using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.CommonModule;

namespace DIPSolutionApp.LowLevelModule
{
    class DBLogger : ILogger
    {
        public string Log()
        {
            string msg="login to DB";
            return msg;
        }
    }
}
