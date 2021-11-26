using System;
using System.IO;

namespace FileOperationsApp
{
    class FileOperationsTest
    {
        static void Main(string[] args)
        {
            AddData();
            Appendtext();
            ReadText();
            Console.ReadLine();
        }
        public static void AddData()
        {
            Console.WriteLine("Enter your string");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\HP\source\repos\FileOperationsApp\write.txt",text +Environment.NewLine);
            Console.WriteLine("text added");
        }
        public static void Appendtext()
        {
            Console.WriteLine("entre the content to append");
            string word=Console.ReadLine();
            File.AppendAllText(@"C:\Users\HP\source\repos\FileOperationsApp\write.txt",word+Environment.NewLine);
            Console.WriteLine("text Appended");
        }
        public static void ReadText()
        {
            var path= @"C:\Users\HP\source\repos\FileOperationsApp\write.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine("content of file write.txt\n{0}",text);
            
        }
    }
}
