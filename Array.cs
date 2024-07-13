using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Array1
    {
        private int[] data;//数组存放的数据
        private int N; //实际数组存放元素的个数
        //有参数的构造函数
        public Array1(int capacity) 
        {
            data = new int[capacity];
            N = 0;
        }
        //无参数的构造函数
        public  Array1() : this(10) { }
        //只允许用户查看存储数据的长度
        public int Capacity
        {
            get { return data.Length; }
        }
        //返回动态数组存储的长度
        public int Count
        {
            get { return N; }
        }
        //判断动态数组是否为空
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        //实现动态数组Add方法(需要添加的位置，需要添加的元素)
        public void Add(int index , int e)
        {
            //判断添加的index位置是否有效
            if (index <0||index > N)
                throw new ArgumentException("数字索引越界");
            
            if (N == data.Length)
                throw new ArgumentException("数组已满");

            for (int i = N-1; i >= index; i--)
            {
                //让index后边的元素后退一格
                data[i+1] = data[i];
            }
            data[index] = e;
            N++;
        }
        //通过Add方法，我们可以为用户设计AddLast和AddFirst方法
        public void AddLast(int e)
        {
            Add(N,e);
        }

        //获取Array1数组中的元素(需要获取元素的索引下标)
        public int Get(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");
            return data[index];
        }
        //通过Get方法实现GetFirst和GetLast
        public int GetFirst()
        {
            return Get(0);
        }
        public int GetLast()
        {
            return Get(N-1); 
        }

        //修改数组的值(修改的位置，需要修改为)
        public void Set(int index,int Newe)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");
            data[index] = Newe;
        }

        //判断数组是否包含元素
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return true;
            }
            return false;
        }
        //返回数组元素的索引下标
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return i;
            }
            return -1;
        }
        //删除元素
        //重写父类的ToString方法用于打印Array1数组
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array1: count={0} capacity={1}\n",N,data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N-1)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
