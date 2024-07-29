namespace List
{
    class Array1Queue<T> : IQueue<T>
    {
        private Array1<T> arr;

        public int Count => arr.Count;
        public bool IsEmpty => arr.IsEmpty;
        //传入容量
        public Array1Queue(int capacity)
        {
            arr = new Array1<T>(capacity);
        }
        //无参
        public Array1Queue()
        {
            arr = new Array1<T>();
        }
        //入队
        public void Enqueue(T t)
        {
            //选择数组尾部作为队尾
            arr.AddLast(t);
        }
        //出队
        public T Dequeue()
        {
            return arr.RemoveFirst();
        }
        //查看队首的元素
        public T Peek()
        {
            return arr.GetFirst();
        }
        public override string ToString()
        {
            return "Queue: Head" + arr.ToString() + "Tail";
        }
    }
}
