using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;

namespace SubscriberClient.Subscriber
{
    public class EmailNotifier : INotifier
    {
       
        public void Notify(Account account)
        {
            Console.WriteLine("Email sent successfully:{0} {1} {2}",account.AccNO,account.Name,account.Balance);
        }
    }
}
