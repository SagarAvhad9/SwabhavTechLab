using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTestDrive.Dog
{
    class Dog
    {
        public int size;
        public string name;

        public void bark()
        {
            if (size>60)
            {
                Console.WriteLine("woof!!!");

            }
            else if(size>14)
            {
                Console.WriteLine("ruff!!!");
            }
            else
            {
                Console.WriteLine("yip!!!");
            }
        }

    }
}
