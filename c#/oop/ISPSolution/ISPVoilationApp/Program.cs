using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPVoilationApp.Model;

namespace ISPVoilationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Manager();
            var n = new Robot();
            Atthecafeteria(m);
       //   Atthecafeteria(n);
            AtTheWorkStation(m);
            AtTheWorkStation(n);
            Console.ReadKey();

        }
        public static void Atthecafeteria(IWorker worker)
        {
            Console.WriteLine("at the  cafeteria");
            worker.StartEat();
            worker.StopEat();
        }
        public static void AtTheWorkStation(IWorker worker )
        {
            Console.WriteLine("at the Workstation");
            worker.StartWork();
            worker.StopWork();

        }
    }
}
