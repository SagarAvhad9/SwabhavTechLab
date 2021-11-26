using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Man
    {
        public virtual void Jump()
        {
            Console.WriteLine("jump");
        }
        public void Read()
        {
            Console.WriteLine( "Man read");
        }
        public void Play()
        {
            Console.WriteLine("man playing");
        }
        public void Walk()
        {
            Console.WriteLine("man walking");
        }
    }
}
