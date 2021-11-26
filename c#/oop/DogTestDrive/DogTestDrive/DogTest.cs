using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTestDrive.Dog
{
    class DogTest
    {
        public static void Main(string[] args)
        {
            Dog one = new Dog();
            one.size = 15;
            one.bark();
            Console.ReadKey();
        }
        
    }
}
