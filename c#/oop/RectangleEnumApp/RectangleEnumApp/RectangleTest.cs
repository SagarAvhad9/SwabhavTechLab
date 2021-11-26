using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleEnumApp.Model;

namespace RectangleEnumApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 101;
            r1.Height = 20;
            r1.BorderColor=Rectangle.ColorType.Blue;
            PrintDetails(r1);
            Console.ReadLine();
        }
        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Width={0}", r.Width);
            Console.WriteLine("Height={0}", r.Height);
            Console.WriteLine("BorderColor={0}", r.BorderColor);
            Console.WriteLine("Area={0}",r.CalculateArea());
        }
        
    }
}
