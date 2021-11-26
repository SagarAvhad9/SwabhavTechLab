using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleEncapsulationApp.Model;

namespace CircleEncapsulationApp
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();

            c1.SetRadius(5.5f);
            c1.SetBorderColor("bLUe");
            c1.SetFillColor("green");

            Console.WriteLine("Radius set: {0}", c1.GetRadius());
            Console.WriteLine("Border Color set: {0}", c1.GetBorderColor());
            Console.WriteLine("Fill Color set: {0}", c1.GetFillColor());
            Console.WriteLine("Area of circle is: {0} ", c1.CalculateArea());

            Console.ReadLine();
        }
    }
}
