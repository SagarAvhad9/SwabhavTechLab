using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstJava.Model
{
    class MovieTest
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            Movie m2 = new Movie();

            m1.name = "3idiots";
            m1.genre = "Comedy";
            m1.rating = 10;
            m1.play();
            m1.information();
            

            m2.name = "The martian";
            m2.genre = "sci-fi";
            m2.rating = 9;
            m2.play();
            m2.information();
            Console.ReadKey();

        }
    }
}
