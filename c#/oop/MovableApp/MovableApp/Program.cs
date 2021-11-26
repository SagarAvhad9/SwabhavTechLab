using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovableApp.Model;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] a = new IMovable[3];
            a[0] = new Car();
            a[1] = new Truck();
            a[2] = new Bike();
            
            StartRace(a);
            Console.ReadLine();

        }
        public static void StartRace(IMovable[] mo)
        {
            for (int i = 0; i < mo.Length; i++)
            {

            }

            foreach (IMovable m in mo)
            {
                m.Move();
            }
        }

    }
}
