using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();
            AtTheWorkStation(robot);
            AtTheWorkStation(manager);
            AtTheCafeteria(manager);

            Console.ReadKey();

        }
        public static void AtTheWorkStation(IWorkable workable)
        {
            Console.WriteLine("at the work station");
            workable.StartWork();
            workable.StopWork();
        }
        public static void AtTheCafeteria(IEatable eatable)
        {
            Console.WriteLine("at the cafeteria");
            eatable.StartEat();
            eatable.StopEat();

        }
    }
}
