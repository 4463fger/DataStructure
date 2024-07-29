using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    //带尾指针的链表队列
    class LinkedList2Queue<T>:IQueue<T>
    {
        //基于带尾指针的链表实现
        private LinkedList02<T> list;

        public LinkedList2Queue()
        {
             list = new LinkedList02<T>();
        }
        public int Count => list.Count;
        public bool IsEmpty => list.IsEmpty;

        //入队
        public void Enqueue(T t)
        {
            list.AddLast(t);
        }

        //出队，并返回元素
        public T Dequeue()
        {
            return list.RemoveFirst();
        }

        //查看队首的元素
        public T Peek()
        {
            return list.GetFirst();
        }
        public override string ToString()
        {
            return "Queue front" + list.ToString() +"tail";
        }
    }
}
