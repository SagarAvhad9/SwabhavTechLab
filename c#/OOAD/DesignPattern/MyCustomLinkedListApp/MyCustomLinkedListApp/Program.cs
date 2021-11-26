using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomLinkedList<int> myList = new MyCustomLinkedList<int>();
            myList.Add(500);
            myList.Add(1000);
            myList.Add(1500);
            myList.Add(2000);



            myList.Display();
            Console.WriteLine("\nTotal ELements : {0} \n", myList.Count());

            myList.Add(3000);

            myList.Remove(2000);

            myList.Display();

            Console.WriteLine("\nTotal ELements : {0} \n", myList.Count());
            myList.Count();
        }
    }
}
