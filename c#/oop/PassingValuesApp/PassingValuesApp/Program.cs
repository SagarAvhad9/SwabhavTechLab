using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValuesApp
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int score = 100;
            UpdateScoreToZero(score);
            Console.WriteLine(score);
            Console.ReadKey(); */

            int[] manyScores = { 70, 80, 90, 100 };
            UpdateManyScoresToZero(manyScores);
            foreach( int s in manyScores)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
        private static void UpdateManyScoresToZero(int[] manyScores)
        {
            for (int i =0;i<manyScores.Length;i++)
            {
                manyScores[i] = 0;
            }
        }
        private static void UpdateScoreToZero(int pscore)
        { 
         pscore=0;
            
        }
    }

}
