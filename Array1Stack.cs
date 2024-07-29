namespace List
{
    //数组栈,由动态数组实现
    class Array1Stack<T>:IStack<T>
    {
        private Array1<T> arr;
        //带参构造函数
        public Array1Stack(int capacity)
        {
            arr = new Array1<T>(capacity);
        }
        //不带参构造函数
        public Array1Stack()
        {
            arr = new Array1<T>();
        }

        public int Count => arr.Count; 
        public bool IsEmpty =>arr.IsEmpty;
        //添加
        public void Push(T t)
        {
            //选择数组尾部作为栈顶时，时间复杂度为O(1)
            //选择数组头部作为栈顶时，因为涉及到其他元素的后移，实际按复杂度为O(n)
            //所以数组尾部作为栈顶
            arr.AddLast(t);
        }
        //删除栈顶元素
        public T Pop()
        {
            return arr.RemoveEnd();
        }
        //查看栈顶元素
        public T Peek()
        {
            return arr.GetLast();
        }
        //打印方法
        public override string ToString()
        {
            return "Stack" + arr.ToString() + "Top";
        }
    }
}
