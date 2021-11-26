using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonBMIApp.Model;

namespace PersonBMIApp
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[2];
            p[0] = new Person("Sagar", 90f, 1.889f, 20, "Male");
            p[1] = new Person("dhanraj", 76.3f, 1.62f, 22, "Male");
            p[0].PersonWorkout();
            //p[0].EatPerson();
            PrintArrayInfo(p);

            Console.ReadLine();
        }

        public static void PrintArrayInfo(Person[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                PrintDetails(p[i]);
            }
        }

        public static void PrintDetails(Person p)
        {
            Console.WriteLine("\nName : {0} \nWeight : {1}kg \nHeight : {2}m \nAge : {3} \nGender : {4}", p.GetName(), p.GetWeight(), p.GetHeight(), p.GetAge(), p.GetGender());
            Console.WriteLine("\nAfter Workout:");
            Console.WriteLine("Your weight is loss by: {0}", p.GetLossWeight());
            Console.WriteLine("\nBMI is: {0:F2}", p.CalcBMI());

            Console.WriteLine("Your weight status is: {0}", p.GetBodyStrucure());
            Console.WriteLine("----------------------------------------------------------------");
        }
    
    }
}
