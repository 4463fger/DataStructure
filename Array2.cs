using System;
using System.Text;

namespace List
{
    //循环数组
    class Array2<T>
    {
        private T[] data;  //静态数组存储元素
        private int first; //记录头部
        private int last;  //记录尾部
        private int N;     //当前元素个数

        public Array2(int capacity)
        {
            data = new T[capacity];

            first = 0;
            last = 0;
            N = 0;
        }
        public Array2() : this(10) { }

        public int Count => N;
        public bool IsEmpty => N == 0;
        //添加元素
        public void AddLast(T t)
        {
            if(N ==data.Length)
                ResetCapacity(2*data.Length);

            data[last] = t;

            last = (last+1)%data.Length;
            N++;
        }
        //删除元素
        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("数组为空");

            T ret = data[first];
            data[first] = default(T);

            first = (first + 1) % data.Length;
            N--;

            if(N == data.Length/4)
                ResetCapacity(data.Length/2);

            return ret;
        }
        //获取头部元素
        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("数组为空");
           
            return data[first];
        }
        //扩容
        private void ResetCapacity(int newCapacity)
        {
            //临时数组用于转移元素
            T[] newData = new T[newCapacity];

            for (int i = 0; i < N; i++)
                newData[i] = data[(first+i)%data.Length];

            data = newData;
            first = 0;
            last = N;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[(first + i) % data.Length]);
                if ((first + i + 1) % data.Length != last)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
