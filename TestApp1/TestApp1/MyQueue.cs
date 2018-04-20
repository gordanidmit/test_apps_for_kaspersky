using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp1
{
    public class MyQueue<T>
    {
        private Queue<T> _queue;

        public MyQueue ()
        {
            _queue = new Queue<T>();
        }

        public void Push(T value)
        {
            _queue.Enqueue(value);
        }

        public T Pop()
        {
            while (true)
            {
                lock (_queue)
                {
                    if (_queue.Count > 0)
                    {
                        return _queue.Dequeue();
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}
