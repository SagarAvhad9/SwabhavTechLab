using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetWidth(101);
            small.SetHeight(-50);
            int Area = small.CalculateArea( small.GetWidth(), small.GetHeight());
            Console.WriteLine("small Rectangle width:{0},height:{1},area:{2}",small.GetWidth(), small.GetHeight(),Area);
            Console.ReadKey();


        }
    }
}
 