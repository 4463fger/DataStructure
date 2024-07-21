using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    //数组栈,由动态数组实现
    class ArrayIStack<T>:IStack<T>
    {
        private MyArrayList<T> arr;
        //带参构造函数
        public ArrayIStack(int capacity)
        {
            arr = new MyArrayList<T>(capacity);
        }
        //不带参构造函数
        public ArrayIStack()
        {
            arr = new MyArrayList<T>();
        }

        public int Count {get { return arr.Count; } }
        public bool IsEmpty { get { return arr.IsEmpty; } }
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

    }
}
