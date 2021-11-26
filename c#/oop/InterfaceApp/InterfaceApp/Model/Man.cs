using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Man : IManner
    {
        public void Depart()
        {
            Console.WriteLine("man depart");
        }

        public void Wish()
        {
            Console.WriteLine("Man wishung");
        }
    }
}
