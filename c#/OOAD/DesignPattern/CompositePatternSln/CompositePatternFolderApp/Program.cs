using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder moviefolder = new Folder("Movies");
            moviefolder.AddChild(new File("Ready", "850kb"));
            moviefolder.AddChild(new File("Thor", "2GB"));

            Folder comedy = new Folder("comedy");
            moviefolder.AddChild(comedy);
            comedy.AddChild(new File("ironman", "1GB"));

            moviefolder.Display();
            Console.ReadKey();
        }
    }
}
