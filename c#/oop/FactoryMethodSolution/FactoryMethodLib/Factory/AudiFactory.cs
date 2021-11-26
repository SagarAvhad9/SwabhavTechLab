using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class AudiFactory : IAutoFactory
    {
        private static AudiFactory _Factory;
        private static object locker = new object();

        public AudiFactory()
        {
            Console.WriteLine("AudiFactory Created");
        }
        public IAuto Make()
        {
            return new Audi();
        }
        public static AudiFactory GetInstance()
        {
            lock (locker)
            {
                if (_Factory == null)
                {
                    _Factory = new AudiFactory();
                }
            }
            return _Factory;
        }
    }
}
