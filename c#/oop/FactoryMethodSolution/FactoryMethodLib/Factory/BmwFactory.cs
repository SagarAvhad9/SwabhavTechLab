using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class BmwFactory : IAutoFactory
    {
        private static BmwFactory _Factory;
        private static object locker = new object();
        public BmwFactory()
        {
            Console.WriteLine("BMW Factory Created");
        }
        public IAuto Make()
        {
            return new Bmw();
        }
        public static BmwFactory GetInstance()
        {
            lock (locker)
            {
                if (_Factory == null)
                {
                    _Factory = new BmwFactory();
                }
            }
            return _Factory;
        }
    }
}
