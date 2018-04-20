using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            Random rnd = new Random();
            
            queue.Push(0);
            Console.WriteLine("{0} added to queue", 0);

            Action act = () =>
            {
                for (int i = 1; i <= 5000; i++)
                    if (rnd.Next(0, i < 100 ? 5 : 2) > 0)
                    {
                        queue.Push(i);
                        Console.WriteLine("{0} added to queue", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} popped from queue", queue.Pop());
                    }
            };


            Task t1 = new Task(act);
            t1.Start();
            Task t2 = new Task(act);
            t2.Start();
            Task t3 = new Task(act);
            t3.Start();
            Task t4 = new Task(act);
            t4.Start();
            Task t5 = new Task(act);
            t5.Start();

            t1.Wait();
            t2.Wait();
            t3.Wait();
            t4.Wait();
            t5.Wait();
            Console.ReadKey();
        }
    }
}
