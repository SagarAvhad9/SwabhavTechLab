using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudOperationsApp.Model;

namespace CrudOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // NewMethod();
            NewMethod1();
            NewMethod2();
            Console.ReadKey();
        }

        /*  private static void NewMethod()
          {
              ArrayList1 a = new ArrayList1();

              while (true)
              {
                  Console.WriteLine("Press Y to go inside the menu and Press E to Exit");
                  char giveinput = Convert.ToChar(Console.ReadLine());
                  while (true)
                  {
                      Console.WriteLine("1:Add 2:Read 3:Update 4:Delete");
                      int input = Convert.ToInt32(Console.ReadLine());
                      switch (input)
                      {
                          case 1:
                              int num = Convert.ToInt32(Console.ReadLine());
                              a.Add(num);
                              Console.WriteLine("");
                              break;
                          case 2:
                              Console.WriteLine("Enter the input");
                              a.Read();
                              break;
                          case 3:
                              int num1 = Convert.ToInt32(Console.ReadLine());
                              int num2 = Convert.ToInt32(Console.ReadLine());
                              a.Update(num1, num2);
                              break;
                          case 4:
                              int num3 = Convert.ToInt32(Console.ReadLine());
                              a.Delete(num3);
                              break;
                      }

                  }
              }
          }*/

        private static void NewMethod1()
        {
            Dictionary1 d = new Dictionary1();

            while (true)
            {
                Console.WriteLine("Press Y to go inside the menu and Press E to Exit");
                char giveinput = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("1:Add 2:Read 3:Update 4:Delete");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            string num3 = Console.ReadLine();
                            d.Add(num, num3);
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("Enter the input");
                            d.Read();
                            break;
                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            string num2 = Console.ReadLine();
                            d.Update(num1, num2);
                            break;
                        case 4:
                            int num4 = Convert.ToInt32(Console.ReadLine());
                            d.Delete(num4);
                            break;
                    }

                }
            }
        }
        private static void NewMethod2()
        {
            Dictionary1 d = new Dictionary1();

            while (true)
            {
                Console.WriteLine("Press Y to go inside the menu and Press E to Exit");
                char giveinput = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("1:Add 2:Read 3:Update 4:Delete");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            string num3 = Console.ReadLine();
                            d.Add(num, num3);
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("Enter the input");
                            d.Read();
                            break;
                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            string num2 = Console.ReadLine();
                            d.Update(num1, num2);
                            break;
                        case 4:
                            int num4 = Convert.ToInt32(Console.ReadLine());
                            d.Delete(num4);
                            break;
                    }

                }
            }
        }
    }
}


