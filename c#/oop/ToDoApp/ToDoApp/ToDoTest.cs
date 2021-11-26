using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;

namespace ToDoApp
{
    class ToDoTest
    {
        static void Main(string[] args)
        {
            GetDetails();
        }

        private static void GetDetails()
        {
            ToDo T = new ToDo();
            while (true)
            {
                Console.WriteLine("Press Y to go inside the menu and Press E to Exit");
                char giveinput = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    if (giveinput == 'y')
                    {
                        Console.WriteLine("1:Display 2:Add 3:Exit");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                T.Display();
                                break;
                            case 2:
                                Console.WriteLine("Enter the input");
                                string input1 = Convert.ToString(Console.ReadLine());
                                T.AddInList(input1);
                                break;
                            case 3:
                                T.Exit();
                                break;
                        }
                    }
                    else if (giveinput == 'n')
                    {
                        T.Exit();
                    }
                }
            }
        }
    }
}
