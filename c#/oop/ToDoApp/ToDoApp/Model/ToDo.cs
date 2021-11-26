using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApp.Model
{
    class ToDo
    {
        string FilePath = @"F:/swabhavtech/c#/oop/ToDoApp/SavedFile.txt";
        public void Display()
        {
            FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while(str !=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            fs.Close();
            sr.Close();
        }
        public void AddInList(string value)
        {
           using(StreamWriter writer=new StreamWriter(FilePath, true))
            {
                writer.WriteLine(value.ToString());
                Console.WriteLine("Task Added");
                Console.WriteLine("");
                writer.Close();
            }
        }
        public void Exit()
        {
            FileStream fs1 = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            Console.WriteLine("Data Saved");
            Console.WriteLine("Exit");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
