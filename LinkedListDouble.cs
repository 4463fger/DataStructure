using System;
using System.Text;

namespace List
{
    class LinkedListDouble<T>
    {
        //内部节点类
        private class Node
        {
            public T data;   //实际存储的数据
            public Node prev;//用来指向前一个节点
            public Node next;//用来指向下一个节点

            //构造函数,初始化链表
            public Node(T data ,Node prev ,Node next)
            {
                this.data= data;
                this.prev= prev;
                this.next= next;
            }
            public Node(T data)
            {
                this.data = data;
                this.prev = null;
                this.next = null;
            }

            //重写ToString
            public override string ToString()
            {
                return data.ToString();
            }
        }

        private Node Head; //记录链表得头部
        private Node Tail; //记录链表的尾部
        private int N;     //链表存储多少元素

        public LinkedListDouble()
        {
            //初始化链表,此时全为null
            Head = null;
            Tail = null;
            N = 0;
        }

        //访问链表元素数量
        public int Count => N;
        //判断链表是否为空
        public bool IsEmpty => N == 0;

        //在指定位置插入一个元素
        public void Add(int index, T t)
        {
            if (index <0 || index >N)
                throw new ArgumentOutOfRangeException("非法索引");

            //插入头部
            if (index == 0)
            {
                Node newNode = new Node(t);
                if (Head != null)
                {
                    Head.prev = newNode;
                    newNode.next = Head;
                }
                Head = newNode;
                //如果这是唯一一个节点，更新尾部
                if (Tail == null)
                    Tail = Head;
            }
            //尾部插入
            else if (index == N)
            {
                Node newNode = new Node(t);
                if (Tail != null)
                {
                    Tail.next = newNode;
                    newNode.prev = Tail;
                }
                Tail = newNode;
                //如果这是唯一一个节点，更新头部
                if (Head == null)
                    Head = Tail;
            }
            //链表中间插入
            else
            {
                Node newNode = new Node(t);

                //遍历节点,找到要插入位置的前一个节点
                Node current = Head;
                for (int i = 0; i < index;i++)
                    current = current.next;//此时current指向要插入的位置
                //连接节点
                newNode.prev = current.prev;
                newNode.next = current;
                current.prev.next = newNode;
                current.prev = newNode;
            }
            //增加链表长度
            N++;
        }
        //在头部插入
        public void AddFirst(T t) => Add(0, t);
        //在尾部插入
        public void AddLast(T t) => Add(N, t);

        // 查找链表是否包含元素
        public bool Contains(T t)
        {
            Node current =Head;
            while (current != null)
            {
                if (current.data.Equals(t))
                    return true;
                current = current.next;
            }
            return false;
        }
        //查询索引处的元素
        public T Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentOutOfRangeException("非法索引");

            Node current = Head;
            for (int i = 0; i < index; i++)
                current = current.next;

            return current.data;
        }

        //修改元素
        public void Set(int index, T newt)
        {
            if (index < 0 || index >= N)
                throw new ArgumentOutOfRangeException("非法索引");

            Node current = Head;
            for (int i = 0; i < index; i++)
                current = current.next;

            current.data = newt;
        }

        //删除指定位置元素
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentOutOfRangeException("非法索引");

            Node current = Head;
            if (index == 0)
            {
                //删除头部
                Head = Head.next;
                if (Head !=null)
                    Head.prev = null;
                else
                    Tail = null;
            }
            else if (index == N - 1)
            {
                //删除尾部
                Tail = Tail.prev;
                if (Tail != null)
                    Tail.next = null;
                else
                    Head = null;
            }
            else
            {
                //删除中间
                for (int i = 0; i < index; i++)
                    current = current.next;

                current.prev.next = current.next;
                current.next.prev = current.prev;
            }

            N--;
            return current.data;
        }
        //查找元素删除
        public void Remove(T t)
        {
            Node current = Head;

            while (current != null)
            {
                //找到元素
                if (current.data.Equals(t))
                {
                    if (current.prev != null)
                        current.prev.next = current.next;
                    else
                        Head = current.next;

                    if (current.next != null)
                        current.next.prev = current.prev;
                    else
                        Tail = current.prev;

                    N--;
                }
                current = current.next;
            }
        }
        //重写To string()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node current = Head;
            while (current != null)
            {
                sb.Append(current.data + "<->");
                current = current.next;
            }
            sb.Append("Null");
            return sb.ToString();
        }
    }
}
