using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("oreder created");
        }

        public void Delete()
        {
            Console.WriteLine("order deleted");
        }

        public void Read()
        {
            Console.WriteLine("order readed");
        }

        public void Update()
        {
            Console.WriteLine("order updated");
        }
    }
}
