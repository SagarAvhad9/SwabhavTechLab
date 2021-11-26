using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleConstructorApp.Model;

namespace RectangleConstructorApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            Rectangle r1 = new Rectangle(-20,50,"green");
            PrintDetails(r1);
        }
        public static void CaseStudy2()
        {
            Rectangle r2 = new Rectangle(30, 40, "yellow");
            PrintDetails(r2);
            Rectangle r3 = new Rectangle(105, 50, "white","blue");
            PrintDetails(r3);
        }
        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Height={0},Width={1},Color={2},BorderColor={3},Area={4}",r.GetHeight(),r.GetWidth(),r.GetColor(),r.GetBorderColor(),r.Area());

        }
    }
}
