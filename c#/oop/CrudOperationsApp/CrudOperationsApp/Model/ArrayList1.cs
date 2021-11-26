using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CrudOperationsApp.Model
{
    class ArrayList1
    {
        private List<int> a = new List<int>();
        public void Add(int add)
        {
            a.Add(add);    
        }

        public void Read()
        {
            for(int i=0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public void Update(int position,int updatevalue)
        {
            for(int i = 0; i < a.Count; i++)
            {
                if (position == i)
                {
                    a[position - 1] = updatevalue;
                }
            }
        }

        public void Delete(int position)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (position == i)
                {
                    a.Remove(a[position - 1]);
                }
            }
        }

        
    }
}
