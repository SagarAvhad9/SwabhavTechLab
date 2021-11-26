using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceApp.Model;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Casestudy1();
          //  CaseStudy2();
          //  CaseStudy3();
         //   CaseStudy4();
            CaseStudy5();
            Console.ReadKey();
        }
        public static void CaseStudy3()
        {
            Man x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
            x.Jump();

        }
        public static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.Jump();
            y.Read();
            y.Walk();
        } 
        public static void Casestudy1()
        {
            Man x;
            x = new Man();
            x.Play();
            x.Read();
            x.Walk();
        }
        public static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }
        public static void CaseStudy5()
        {
            object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "hello world";
            Console.WriteLine(x.GetType());
            x = 10.55f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
        public static void AtThePark(Man x)
        {
            Console.WriteLine("At park");
            x.Jump();
            
        }
    }
}
