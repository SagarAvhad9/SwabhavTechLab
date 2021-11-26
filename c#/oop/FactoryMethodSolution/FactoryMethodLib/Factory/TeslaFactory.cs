using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class TeslaFactory : IAutoFactory
    {
        private static TeslaFactory _Factory;
        private static object locker = new object();
        public TeslaFactory()
        {
            Console.WriteLine("Tesla Created");
        }
        public IAuto Make()
        {
            return new Tesla();
        }
        public static TeslaFactory GetInstance()
        {
            lock (locker)
            {
                if (_Factory == null)
                {
                    _Factory = new TeslaFactory();
                }
            }
            return _Factory;
        }
    }
}
