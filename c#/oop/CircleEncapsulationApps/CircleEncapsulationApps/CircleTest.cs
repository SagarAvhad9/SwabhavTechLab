using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleEncapsulationApps.Model;

namespace CircleEncapsulationApps
{
    class CircleTest
    {    
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            
        }
        public static void CaseStudy1()
        {
            Circle c1 = new Circle();
            c1.SetRadius(5.5f);
            c1.SetBorderColor("blue");
            c1.SetFillColor("green");
            PrintDetails(c1);
        }
        public static void CaseStudy2()
        {
            Console.WriteLine("Area of Anonymous Object={0}",new Circle().CalculateArea());
            Console.WriteLine("BorderColor of Anonymous Object={0}", new Circle().GetBorderColor());
            PrintDetails(new Circle());
        }
        public static void CaseStudy3()
        {
            Circle[] manyCircles = new Circle[2];

            Circle circle1 = new Circle();
            circle1.SetRadius(11.5f);
            circle1.SetBorderColor("yellow");
            circle1.SetFillColor("orange");
            manyCircles[0] = circle1;

            Circle circle2 = new Circle();
            circle2.SetRadius(1.5f);
            circle2.SetBorderColor("yellow");
            circle2.SetFillColor("blue");
            manyCircles[0] = circle2;

            PrintDetails(manyCircles);

        }
        public static void PrintDetails(Circle c1)
        {
            Console.WriteLine("Radius={0}",c1.GetRadius());
            Console.WriteLine("BodyColor={0}",c1.GetBorderColor());
            Console.WriteLine("FillColor={0}",c1.GetFillColor());
            Console.WriteLine("Area={0}",c1.CalculateArea());
            
        }
        public static void PrintDetails(Circle[] manycircle)
        {
            for (int i = 0;i<manycircle.Length;i++)
            {
                
                Circle circle1 = new Circle();
                circle1.SetRadius(11.5f);
                circle1.SetBorderColor("yellow");
                circle1.SetFillColor("orange");
                

            }
            Console.ReadKey();
        }
      
    }
}
