using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class JaguarFactory : IAutoFactory
    {
        private static JaguarFactory _Factory;
        private static object locker = new object();

        public JaguarFactory()
        {
            Console.WriteLine("Jaguar Factory Created");
        }
        public IAuto Make()
        {
            return new Jaguar();
        }
        public static JaguarFactory GetInstance()
        {
            lock (locker)
            {
                if (_Factory == null)
                {
                    _Factory = new JaguarFactory();
                }
            }
            return _Factory;
        }
    }
}
