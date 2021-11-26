using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertySyntaxApp.Model;

namespace PropertySyntaxApp
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            PropertySyntax p1 = new PropertySyntax();
            Console.WriteLine("bar={0}",p1.Baz);
            p1.Bar = 200;
            Console.WriteLine("baz={0}",p1.Bar);
            Console.ReadLine();
        }
    }
}
