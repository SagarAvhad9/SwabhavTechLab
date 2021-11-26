using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp.Model
{
    class DataService
    {
        private static object locker = new object();
        private static DataService _bucket;
        public DataService()
        {
            Console.WriteLine("data service created");
        }
        public void DoSomething()
        {
            Console.WriteLine("WorkDone by"+this.GetHashCode());
        }
       /* public static DataService GetInstance()
        {
            if (_bucket == null)
            {
                _bucket = new DataService();
            }
            return _bucket;
        }*/
        public static DataService GetInsatance()
        {              
            lock (locker) 
            {
                if (_bucket == null)
                {
                    _bucket = new DataService();
                }
            }
            return _bucket;
        }
    }
}
