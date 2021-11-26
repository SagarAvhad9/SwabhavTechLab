using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;
using SubscriberClient.Subscriber;

namespace SubscriberClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101, "abc", 5000);
            account.AddNotifier(new SmsNotifier());
            account.AddNotifier(new EmailNotifier());
            account.Deposit(1000);
            Console.ReadKey();

        }
    }
}
