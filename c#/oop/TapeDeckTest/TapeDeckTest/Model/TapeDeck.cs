using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeDeckTest.Model
{
    class TapeDeck  
    {
        public  bool canRecord = false;
        public void playTape()
        {
            Console.WriteLine("tape playing");
        }
        public void recordTape()
        {
            Console.WriteLine("tape recording");
        }
    }
}
