using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    abstract class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("customer created");        }

        public void Read()
        {
            Console.WriteLine("customer Readed");
        }

        public abstract void Update();

        public abstract void Delete();
       
    }
}
