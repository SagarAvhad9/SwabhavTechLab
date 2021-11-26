using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy : IManner, IEmotion
    {
        public void Cry()
        {
            Console.WriteLine("Boy crying");
        }

        public void Depart()
        {
            Console.WriteLine("boy depart");
        }

        public void Laugh()
        {
            Console.WriteLine("boy laugh");
        }

        public void Wish()
        {
            Console.WriteLine("boy wish");
        }
    }
}
