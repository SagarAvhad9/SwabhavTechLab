using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    class MyQueue<T>:IQueue<T>
    {
        LinkedList<T> ls = new LinkedList<T>();
        public MyQueue()
        {
                
        }

        public int Count()
        {
            return this.ls.Count();
        }

        public T Deque()
        {
            this.ls.RemoveFirst();
            return ls.First();
        }

        public void Enque(T item)
        {
            this.ls.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ls.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ls.GetEnumerator();
        }
    }
}
