using System;
using System.Text;

namespace List
{
    class MyArrayList<T>
    {
        private T[] _data;//数组存放的数据
        private int _size;//实际数组存放元素的个数

        //构造函数，初始化数组的容量
        public MyArrayList(int capacity)
        {
            _data = new T[capacity];
            _size = 0;
        }
        //无参数的构造函数(这里使用this复用带参的构造函数,默认传入参数10)
        public MyArrayList() : this(10) { }

        //获取动态数组的容量
        public int Capacity => _data.Length;
        //获取动态数组中存储的元素数量
        public int Count => _size;
        //判断动态数组是否为空
        public bool IsEmpty => _size == 0;

        //增加数组的容量
        private void ResetCapacity(int newCapacity)
        {
            //newData用来存储未扩容数组的数据
            T[] newData = new T[newCapacity];
            for (int i = 0; i < _size; i++)
                newData[i] = _data[i];

            _data = newData;
        }

        //实现Add方法(需要添加的位置，需要添加的元素)
        public void Add(int index ,T t)
        {
            //判断添加的index位置是否有效
            if (index < 0|| index > _size)
                throw new ArgumentException("数组索引越界");

            if (_size == _data.Length)
                ResetCapacity(2*_data.Length);

            //从数组的末尾开始，将所有大于等于index的元素向后移动一位
            for (int i = _size-1; i > index; i--)
            {
                _data[i] = _data[i - 1];
            }

            //在index位置插入新的元素
            _data[index] = t;
            // 更新数组的实际大小
            _size++;
        }
        //通过Add方法，设计AddLast和AddFirst方法
        public void AddFirst(T t) => Add(0, t);
        public void AddLast(T t) => Add(_size,t);


        // 检查是否包含元素
        public bool Contains(T t)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_data[i].Equals(t))
                    return true;
            }
            return false;
        }
        //返回数组元素的索引下标
        public int IndexOf(T t)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_data[i].Equals(t))
                    return i;
            }
            return -1;
        }
        //删除元素(按照索引删除元素)
        public T RemoveIn(int index)
        {
            if (index < 0 || index >= _size)
                throw new ArgumentException("数组索引越界");
            //记录被删除的元素
            T del = _data[index];
            //将数组元素一次往前移
            for (int i = index + 1; i <= _size - 1; i++)
                _data[i - 1] = _data[i];

            _size--;
            //数组末尾元素标为T类型的默认值
            _data[_size] = default(T);

            //自动缩容
            if (_size == _data.Length / 4)
                ResetCapacity(_data.Length / 2);

            return del;
        }
        //删除首尾元素
        public T RemoveFirst()=> RemoveIn(0);
        public T RemoveEnd()=> RemoveIn(_size - 1);
        //按照特定元素删除
        public void Remove(T t)
        {
            //先查找元素的索引
            int index = IndexOf(t);
            if (index != -1)
                RemoveIn(index);
        }

        //获取MyArrayList数组中的元素(需要获取元素的索引下标)
        public T Get(int index)
        {
            if (index < 0 || index >= _size)
                throw new ArgumentException("数组索引越界");
            return _data[index];
        }
        //通过Get方法实现GetFirst和GetLast
        public T GetFirst() => Get(0);
        public T GetLast() => Get(_size - 1);


        //修改数组的值(修改的位置，需要修改为)
        public void Set(int index, T Newt)
        {
            if (index < 0 || index >= _size)
                throw new ArgumentException("数组索引越界");
            _data[index] = Newt;
        }

        //重写父类的ToString方法用于打印Array1数组
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("MyArrayList: count={0} capacity={1}\n", _size, _data.Length));
            
            res.Append("[");
            for (int i = 0; i < _size; i++)
            {
                res.Append(_data[i]);
                if (i != _size - 1)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
