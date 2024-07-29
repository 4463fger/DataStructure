using System;
using System.Diagnostics;


namespace List
{
    class Program
    {
        //测试队列的性能
        private static long TestQueue(IQueue<int> queue, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(i);
            }
            for (int i = 0; i < N; i++)
            {
                queue.Dequeue();
            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        static void Main(string[] args)
        {
            int N = 100000;
            //链表队列(头指针)
            LinkedList1Queue<int> linkedList1Queue = new LinkedList1Queue<int>();
            long t1 = TestQueue(linkedList1Queue, N);
            Console.WriteLine("linkedList1Queue Time:" + t1+"ms");
            //链表队列(头尾指针)
            LinkedList2Queue<int> linkedList2Queue = new LinkedList2Queue<int>();
            long t2 = TestQueue(linkedList2Queue, N);
            Console.WriteLine("linkedList2Queue Time:" + t2 + "ms");

            Console.ReadKey();
        }
    }
}
