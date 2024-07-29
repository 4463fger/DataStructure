namespace List
{ 
    //循环队列
    class Array2Queue<T> :IQueue<T>
    {
        //循环数组作为底层的数据结构
        private Array2<T> arr;

        //创建容量为capacity的队列
        public Array2Queue(int capacity)
        {
            arr =new Array2<T>(capacity);
        }
        //使用默认的容量创建队列
        public Array2Queue()
        {
            arr = new Array2<T>();
        }

        //获取队列元素的个数O(1)
        public int Count => arr.Count;

        //查看队列是否为空O(1)
        public bool IsEmpty => arr.IsEmpty;

        //入队,往队尾添加元素O(1)
        public void Enqueue(T t)
        {
            arr.AddLast(t);
        }

        //出队，删除队首的元素O(1)
        public T Dequeue()
        {
            return arr.RemoveFirst();
        }

        //查看队首的元素O(1)
        public T Peek()
        {
            return arr.GetFirst();
        }

        //打印循环队列信息
        public override string ToString()
        {
            return "Queue: front" + arr.ToString() + "tail";
        }
    }
}
