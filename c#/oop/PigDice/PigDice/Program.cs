using System;

namespace PigGame
{
    class Program
    {

        static int MAX_SCORE = 20;
        static int diceValue;

        static int StartGame(int currentScore, int totalScore)//0 0
        {

            Random random = new Random();

            while (true)
            {
                Console.WriteLine(" Roll or Hold ? (r/h) ");
                char roll = 'r';
                char hold = 'h';
                char userDecision = Convert.ToChar(Console.ReadLine());
                if (userDecision == roll)
                {
                    diceValue = random.Next(1, 7);
                    Console.WriteLine(diceValue);
                    if (diceValue != 1)
                    {

                        currentScore += diceValue;
                        if (currentScore >= MAX_SCORE)
                        {
                            return currentScore;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Turn Over zero Score !!");
                        currentScore = totalScore;
                        return currentScore;
                    }
                }
                else if (userDecision == hold)
                {
                    totalScore = currentScore;//6

                    //   turnCount++;
                    if (totalScore >= MAX_SCORE)
                    {

                        return currentScore;
                    }
                    Console.WriteLine("Total Score : " + totalScore);
                    return totalScore;
                }

            }
        }


        static void Main(string[] args)
        {
            int currentScore = 0;
            int totalScore = 0;
            int start = 0;
            Console.WriteLine(" Welcome to the PigDice Game ");


            while (currentScore < MAX_SCORE)
            {
                start = start + 1;
                Console.WriteLine("\nTurn : " + start);
                currentScore = StartGame(currentScore, totalScore);
            }
            Console.WriteLine("You Finished in " + start + "Turns");
            Console.ReadLine();
        }
    }
}