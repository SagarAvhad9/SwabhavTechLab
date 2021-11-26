using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Model
{
    class Child:Parent
    {
        public Child():base(100)
        {
            Console.WriteLine("child created");      
        }
        public Child(int foo):base(foo)
        {
            Console.WriteLine("child created");
        }
    }
}
