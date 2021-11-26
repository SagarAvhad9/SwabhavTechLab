using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVoilationApp.Model
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("manager start eat");
        }

        public void StartWork()
        {
            Console.WriteLine("manager start work");
        }

        public void StopEat()
        {
            Console.WriteLine("manager stop eat");
        }

        public void StopWork()
        {
            Console.WriteLine("manager stop work");
        }
    }
}
