using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Product;

namespace SimpleFactoryLib.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _autofactory;
        private static object locker = new object();
        public AutoMobileFactory()
        {
            Console.WriteLine("Instance Created");
        }
        public IAuto Make(AutoType autoType)
        {
            if (autoType == AutoType.BMW)
            {
                return new Bmw();
            }
            else if (autoType == AutoType.TESLA)
            {
                return new Tesla();
            }
            else
            {
                return new Audi();
            }
        }
        public static AutoMobileFactory GetInstance()
        {
            lock (locker)
            {
                if (_autofactory == null)
                {
                    _autofactory = new AutoMobileFactory();
                }
            }
            return _autofactory;
        }
    }
}
