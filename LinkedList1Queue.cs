namespace List
{
    class LinkedList1Queue<T>:IQueue<T>
    {
        //链表
        private LinkedList01<T> list;

        public LinkedList1Queue()
        {
            list = new LinkedList01<T>();
        }

        public int Count => list.Count;
        public bool IsEmpty => list.IsEmpty;

        //删除队列头部==删除链表头部O(1)
        public T Dequeue()
        {
            return list.RemoveFirst();
        }
        //添加到队列尾部==添加链表尾部O(n)[需要遍历到链表尾部]
        public void Enqueue(T t)
        {
           list.AddLast(t);
        }
        //查看队列头部==查看链表头部O(1)
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
