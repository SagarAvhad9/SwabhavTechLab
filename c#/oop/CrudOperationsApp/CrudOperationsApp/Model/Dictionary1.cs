using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationsApp.Model
{
    class Dictionary1
    {
        private Dictionary<int,string> D1 = new Dictionary<int,string>();
        public void Add(int add,string value)
        {
            D1.Add(add,value);
        }

        public void Read()
        {
            foreach(KeyValuePair<int,string>item in D1 )
            {
                Console.WriteLine("key :{0} value :{1}",item.Key,item.Value);
            }
        }

        public void Update(int position, string updatevalue)
        {
            D1.Remove(position);
            D1.Add(position,updatevalue);
        }

        public void Delete(int position)
        {
            D1.Remove(position);
        }

    }
}
