using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Robot : IWorkable
    {
        public void StartWork()
        {
            Console.WriteLine("robot start working");
        }

        public void StopWork()
        {
            Console.WriteLine("robot stop working");
        }
    }
}
