using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstJava.Model
{
    class Movie
    {
        public string name;
        public string genre;
        public int rating;
        
        public void play()
        {
            Console.WriteLine("play movie....");
         
        }
      

        public void information()
        {
            
            Console.WriteLine("name=" + name);
            Console.WriteLine("genre="+genre);
            Console.WriteLine("rating=" + rating);
            Console.WriteLine("\n");
        }




    }
}
