using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //int guess; //= g.Next();

            while (true)
            {
                Random rand = new Random();
                int value = rand.Next(1, 101);
                // Game g = new Game(System.in);
                Console.WriteLine("Enter the guessed random number");
                int tries = 0;
                while (true)
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < value)
                    {
                        Console.WriteLine("Your guess is too low");
                        tries++;
                    }
                    else if (guess > value)
                    {
                        Console.WriteLine("Your guess is too high");
                        tries++;
                    }
                    else if(guess==value)
                    {
                        Console.WriteLine("Correct answer , the no. of tries by you is " + tries);
                        break;
                    }  
                }
                
                Console.WriteLine("do you wanna play again Y for yes and N for no");
                string s = Convert.ToString(Console.ReadLine());
                if (s.Equals("Y"))
                {
                    continue;
                }
                else
                {
                    return;
                }
            }   Console.ReadLine();     

        }
    }
}
