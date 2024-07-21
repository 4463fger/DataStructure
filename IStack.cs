using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    interface IStack<T>
    {
        //获取栈中元素数量
        int Count { get; }
        //栈是否为空
        bool IsEmpty { get; }
        //将元素加入栈中
        void Push(T t);
        //删除并返回栈顶元素
        T Pop();
        //查看栈顶元素
        T Peek();
    }
}
