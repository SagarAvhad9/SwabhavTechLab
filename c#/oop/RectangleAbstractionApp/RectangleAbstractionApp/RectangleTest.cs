using RectangleAbstractionApp.Model;
using System;


namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Rectangle small;
            small = new Rectangle();
            small.height = 10;
            small.width = 5;

            Rectangle big;
            big = new Rectangle();
            big.height = 6;
            big.width = 120;

            Rectangle temp = small;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            temp.width = temp.width + 7;



            int area = small.CalculateArea();
            int a = big.CalculateArea();
            Console.WriteLine("temp width= {0}", temp.width);
            Console.WriteLine("small width= {0}", small.width);
            Console.WriteLine("Small Rectangle width={0},height={1},area={2}", small.width, small.height, area);
            Console.WriteLine("Big Rectangle width={0},height={1},area={2}", big.width, big.height, a);
            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(big.GetHashCode());
            Console.WriteLine(temp.GetHashCode());
            Console.ReadKey();



        }
    }
}