using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationApp.Model;


namespace SerializationApp
{
    class SerializationTest
    {
        static void Main(string[] args)
        {
            Serialization s = new Serialization(2000,"sagar",101);
            PrintDetails(s);
            s.Deposit(1000);
            //s.Withdraw(2500);
            PrintDetails1(s);

            string filePath = @"F:\swabhavtech\c#\oop\dataserialize.txt";
            DataSerialized d = new DataSerialized();
            d.BinarySerialize(s, filePath);
            Console.WriteLine("serialized obj");
            Serialization b = null;
            b = d.BinaryDeSerialize(filePath) as Serialization;
            Console.WriteLine("deserilaized data");
            PrintDetails1(b);
            Console.ReadKey();
        }
        public static void PrintDetails(Serialization S)
        {
            Console.WriteLine("old Infomation");
            Console.WriteLine("Balance:{0} Name:{1} AccountNumber {2}",S.Balance,S.Name,S.AccountNumber);
            
        }
        public static void PrintDetails1(Serialization S1)
        {
            Console.WriteLine("New InFormation");
            Console.WriteLine("Balance:{0} Name:{1} AccountNumber {2}", S1.Balance, S1.Name, S1.AccountNumber);
        }
    }
}
