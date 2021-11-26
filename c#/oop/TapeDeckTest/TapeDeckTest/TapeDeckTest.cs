using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapeDeckTest.Model;

namespace TapeDeckTest
{
    class TapeDeckTest
    {
        public static void Main(string[] args)
        {
            TapeDeck t = new TapeDeck();
            t.canRecord = true;
            t.playTape();
            if(t.canRecord==true)
            {
                t.recordTape();
            }
            Console.ReadKey();
        }
    }
}
