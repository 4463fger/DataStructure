namespace List
{
    interface IQueue<T>
    {
        //查看元素数量
        int Count { get; }
        //判空
        bool IsEmpty { get; }
        //入队
        void Enqueue(T t);
        //出队，并返回元素
        T Dequeue();
        //查看队首的元素
        T Peek();
    }
}
