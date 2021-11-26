using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPVoilationApp.Model;

namespace ISPVoilationApp.Model
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            throw new Exception("robot can not eat");
        }

        public void StartWork()
        {
            Console.WriteLine("robot start work");
        }

        public void StopEat()
        {
            throw new Exception("robot can not eat");
        }

        public void StopWork()
        {
            Console.WriteLine("robot stop work");
        }
    }
}
