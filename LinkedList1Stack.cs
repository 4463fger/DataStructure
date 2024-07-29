namespace List
{
    class LinkedList1Stack<T> : IStack<T>
    {
        private LinkedList01<T> list;

        public LinkedList1Stack()
        {
            list = new LinkedList01<T>();
        }

        public int Count => list.Count;
        public bool IsEmpty =>list.IsEmpty;
        //添加元素
        public void Push(T t)
        {
            //选择链表头部作为栈顶,O(1)的时间复杂度
            list.AddFirst(t);
        }
        public T Peek()
        {
            return list.GetFirst();
        }

        public T Pop()
        {
            return list.RemoveFirst();
        }
        //打印
        public override string ToString()
        {
            return "Stack: top"+list.ToString();
        }
    }
}
